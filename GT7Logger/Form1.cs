using GT7Data;
using PDTools.SimulatorInterface;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace GT7Logger
{
    public partial class GT7Logger : Form
    {
        private bool _isRecording = false;
        private CancellationTokenSource _cts = new CancellationTokenSource();
        private string _dataRoot = "";
        private string _tracks = "tracks";
        private TelemetryCollector<Telemetry> Telemetry { get; set; } = new TelemetryCollector<Telemetry>();
        public GT7Logger()
        {
            InitializeComponent();
            timRecordUpdate.Stop();
            UpdateExport();
            barBrake.ForeColor = Color.Orange;
            txtIP.Text = System.Configuration.ConfigurationManager.AppSettings["ps7_ip"];
            btnStart.Enabled = IsValidIP(txtIP.Text);
            _dataRoot = System.Configuration.ConfigurationManager.AppSettings["dataroot"] + "";
            txtDatafile.Text= Path.Combine(_dataRoot, "telemetry");
            txtPath.Text = Path.Combine(_dataRoot, "telemetry");
            if(!Directory.Exists(_dataRoot))
            {
                Directory.CreateDirectory(_dataRoot);
            }
            if (!Directory.Exists(txtDatafile.Text))
            {
                Directory.CreateDirectory(txtDatafile.Text);
            }
            if (!Directory.Exists(txtPath.Text))
            {
                Directory.CreateDirectory(txtPath.Text);
            }
        }

        private void txtIP_KeyUp(object sender, KeyEventArgs e)
        {
            btnStart.Enabled = IsValidIP(txtIP.Text);
            if (e.KeyCode == Keys.Enter && btnStart.Enabled)
            {
                btnStart.PerformClick();
            }
        }

        private static readonly Regex _IPRegex = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$", RegexOptions.Compiled);

        private bool IsValidIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip)) return false;
            return _IPRegex.IsMatch(ip);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            _isRecording = true;
            btnStart.Visible = false;
            btnStop.Visible = true;
            timRecordUpdate.Start();

            SimulatorInterface simInterface = new SimulatorInterface(txtIP.Text, SimulatorInterfaceGameType.GT7);
            simInterface.OnReceive += SimInterface_OnReceive;

            // Cancel token from outside source to end simulator
            lstDebug.Items.Add("Simulator Interface starting..");
            _cts = new CancellationTokenSource();
            var task = simInterface.Start(_cts);

            try
            {
                await task;
            }
            catch (OperationCanceledException ex)
            {
                lstDebug.Items.Add("Simulator Interface ending..");
            }
            catch (Exception ex)
            {
                lstDebug.Items.Add($"Errored during simulation: {ex.Message}");
            }
            finally
            {
                // Important to clear up underlaying socket
                simInterface.Dispose();
            }
        }

        private void SimInterface_OnReceive(SimulatorPacketBase packet)
        {
            // Do something with game specific packet
            var gt7Packet = packet as SimulatorPacketG7S0;
            if (gt7Packet != null)
            {
                var tele= AddData(gt7Packet);
                if (tele != null)
                {
                    lblRecordId.Text = tele.Timestamp.ToString(@"hh\:mm\:ss\.fff");
                    lblLap.Text = tele.Lap.ToString();
                    lblGear.Text = tele.Gear.ToString();
                    lblSpeed.Text = (tele.SpeedMS * 3.6).ToString("F1") + " km/h";
                    barThrottle.Value = tele.Throttle==0 ? 0 : Convert.ToInt32(tele.Throttle/2.55);
                    barBrake.Value = tele.Brake == 0 ? 0 : Convert.ToInt32(tele.Brake / 2.55);
                    barRPM.Value = tele.EngineRPM == 0 ? 0 : Convert.ToInt32(tele.EngineRPM / gt7Packet.MaxAlertRPM * 100);
                    lblRPM.Text=tele.EngineRPM.ToString("F0");
                    lblThrottle.Text = tele.Throttle.ToString();
                    lblBrake.Text = tele.Brake.ToString();
                    if (tele.EngineRPM>gt7Packet.MinAlertRPM)
                    {
                        barRPM.ForeColor = Color.Red;
                    }
                    else
                    {
                        barRPM.ForeColor = Color.Green;
                    }
                    txtFL.BackColor = TireGrip(tele.TireTemp_FL);
                    txtFR.BackColor = TireGrip(tele.TireTemp_FR);
                    txtRL.BackColor = TireGrip(tele.TireTemp_RL);
                    txtRR.BackColor = TireGrip(tele.TireTemp_RR);
                    lblFL.Text = tele.TireTemp_FL.ToString("F0");
                    lblFR.Text = tele.TireTemp_FR.ToString("F0");
                    lblRL.Text = tele.TireTemp_RL.ToString("F0");
                    lblRR.Text = tele.TireTemp_RR.ToString("F0");
                }
            }
        }

        private Color TireGrip(float temp)
        {
            int red = 140;
            int green = 140;
            int blue = 140;
            if(temp>50)
            {
                green = Convert.ToInt32(green + ((temp-50)*3));
;            }

            if (temp > 90)
            {
                green = Convert.ToInt32(green - ((temp - 50) * 10));
                green = green < 140 ? 140 : green;
                red= Convert.ToInt32(red + ((temp - 90) * 20));
            }
            return Color.FromArgb(red>255?255:red, green > 255 ? 255 : green, blue);
        }

        private Telemetry AddData(SimulatorPacketG7S0 data)
        {
            if(data!=null)
            {
                var tele = new Telemetry
                {
                    Timestamp = data.TimeOfDayProgression,
                    CarCode = data.CarCode,
                    Lap = data.LapCount,
                    Throttle = data.Throttle,
                    Brake = data.Brake,
                    Gear = data.CurrentGear,
                    SpeedMS = data.MetersPerSecond,
                    Steering = 0,
                    EngineRPM = data.EngineRPM,
                    Position = new Vector3Ser(data.Position),
                    Velocity = new Vector3Ser(data.Velocity),
                    AngularVelocity = new Vector3Ser(data.AngularVelocity),
                    TireTemp_FL = data.TireFL_SurfaceTemperature,
                    TireTemp_FR = data.TireFR_SurfaceTemperature,
                    TireTemp_RL = data.TireRL_SurfaceTemperature,
                    TireTemp_RR = data.TireRR_SurfaceTemperature,
                };
                Telemetry.AddData(tele);
                return tele;
            }
            return null;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Visible = false;
            if (_isRecording && _cts != null)
            {
                _isRecording = false;
                lstDebug.Items.Add($"Stopping recording...");

                _cts.Cancel();
            }
            Task.Delay(1000);
            timRecordUpdate.Stop();
            UpdateExport();
            btnStart.Visible = true;
        }

        private void UpdateRecordStatus()
        {
            lblRecordCount.Text = Telemetry.NumberOfRecords().ToString();
            lblLapCount.Text = Telemetry.NumberOfLaps().ToString();
        }

        private void UpdateExport()
        {
            if (Telemetry.NumberOfRecords() > 0)
            {
                btnExport.Enabled = !string.IsNullOrWhiteSpace(txtPath.Text);
                ddlLap.Items.Clear();
                ddlLap.Items.Add("All");
                for (int i = 1; i <= Telemetry.NumberOfLaps(); i++)
                {
                    ddlLap.Items.Add(i);
                }
            }
            else
            {
                btnExport.Enabled = false;
                ddlLap.Items.Clear();
                ddlLap.Items.Add("All");
            }
            ddlLap.SelectedIndex = 0;
            ddlType.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Telemetry.Reset();
            UpdateExport();
        }

        private void timRecordUpdate_Tick(object sender, EventArgs e)
        {
            UpdateRecordStatus();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            switch (ddlType.SelectedItem.ToString().ToLower())
            {
                case "csv":
                    saveFileDialog1.Filter = "CSV|*.csv";
                    break;
                default:
                    saveFileDialog1.Filter = "JSON|*.json";
                    break;
            }
            saveFileDialog1.Title = "Save data";
            saveFileDialog1.InitialDirectory = txtPath.Text;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                txtPath.Text = saveFileDialog1.FileName;
                btnExport.Enabled = true;
            }
            else
            {
                txtPath.Text = "";
                btnExport.Enabled = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ddlType.SelectedItem != null)
            {
                IList<Telemetry> toExport;
                if (short.TryParse(ddlLap.SelectedItem.ToString(), out short lap))
                {
                    toExport = Telemetry.GetLap(lap);
                }
                else
                {
                    toExport = Telemetry.GetAll();
                }
                switch (ddlType.SelectedItem.ToString().ToLower())
                {
                    case "json":
                        TelemetryExporter.SaveJSON(toExport, txtPath.Text);
                        lstDebug.Items.Add("Data exported: " + txtPath.Text);
                        break;
                    default:
                        TelemetryExporter.SaveCSV(toExport, txtPath.Text);
                        lstDebug.Items.Add("Data exported: " + txtPath.Text);
                        break;
                } 
            }
        }

        #region track extract

        private void btnCreateTrack_Click(object sender, EventArgs e)
        {
            Track track = new Track(txtTrackname.Text);
            short lap = 0;
            if (short.TryParse(ddlRaceline.SelectedItem.ToString(), out lap))
            {
                track.Raceline = new List<Raceline>(Telemetry.GetLap(lap));
            }
            if (short.TryParse(ddlTrackLeft.SelectedItem.ToString(), out lap))
            {
                track.TrackLeft = new List<TrackPosition>(Telemetry.GetLap(lap));
            }
            if (short.TryParse(ddlTrackRight.SelectedItem.ToString(), out lap))
            {
                track.TrackRight = new List<TrackPosition>(Telemetry.GetLap(lap));
            }
            var trackManager = new TrackManager();
            string savefile=trackManager.SaveTrack(track, Path.Combine(_dataRoot, "tracks"), 4);
            lstDebug.Items.Add("Track saved: " + savefile);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON|*.json";
            openFileDialog1.Title = "Load data";
            openFileDialog1.InitialDirectory = txtDatafile.Text;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                txtDatafile.Text = openFileDialog1.FileName;
                LoadTelemetry();
                txtTrackname.Text = Path.GetFileNameWithoutExtension(txtDatafile.Text);
            }
            else
            {
                txtDatafile.Text = "";
                btnCreateTrack.Enabled = false;
            }
        }

        private void LoadTelemetry()
        {
            Telemetry = new TelemetryCollector<Telemetry>(TelemetryImporter.LoadData(txtDatafile.Text));
            if(Telemetry.NumberOfLaps()<3)
            {
                lstDebug.Items.Add("At least 3 laps are needed: Left track limit, right track limit and racing line");
            }
            else
            {
                for (int i = 1; i <= Telemetry.NumberOfLaps(); i++)
                {
                    ddlRaceline.Items.Add(i);
                    ddlTrackLeft.Items.Add(i);
                    ddlTrackRight.Items.Add(i);
                }
                ddlRaceline.SelectedIndex = 0;
                if(Telemetry.NumberOfLaps()>4)
                {
                    ddlTrackLeft.SelectedIndex = 2;
                    ddlTrackRight.SelectedIndex = 4;
                }
                else
                {
                    ddlTrackLeft.SelectedIndex = 1;
                    ddlTrackRight.SelectedIndex = 2;
                }
                lblLapsImported.Text = Telemetry.NumberOfLaps().ToString();
                btnCreateTrack.Enabled = true;
            }
        }
        #endregion
    }
}