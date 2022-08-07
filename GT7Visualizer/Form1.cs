using GT7Data;
using System.Drawing.Drawing2D;

namespace GT7Visualizer
{
    public partial class Form1 : Form
    {
        private string _dataRoot = "";
        private TelemetryManager DataManager { get; set; }

        public Form1()
        {
            InitializeComponent();
            _dataRoot = System.Configuration.ConfigurationManager.AppSettings["dataroot"] + "";
            DataManager = new TelemetryManager();
            chkRaceline.Checked = true;
        }

        #region trackhandling
        private void btnLoadTrack_Click(object sender, EventArgs e)
        {
            TrackManager trackManager = new TrackManager();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON|*.json";
            openFileDialog1.Title = "Load track";
            openFileDialog1.InitialDirectory = Path.Combine(_dataRoot, "tracks");
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                DataManager.Track = trackManager.LoadTrack(openFileDialog1.FileName);
                if(DataManager.Track != null)
                {
                    lblTrackname.Text = DataManager.Track.Name;
                    SetuptrackCanvas();
                    SetupSpeedChart();
                    SetupThrottleChart();
                    SetupBrakeChart();
                }
                else
                {
                    lblTrackname.Text = "";
                }
            }
            ctlTrack.Refresh();
            ctlFullTrack.Refresh();
            ctlSpeed.Refresh();
        }

        private void SetuptrackCanvas()
        {
            ctlFullTrack.InitializeTrack(DataManager, false);
            ctlTrack.InitializeTrack(DataManager, chkRaceline.Checked);
            ctlTrack.SetZoom(barZoom.Value);
            ctlTrack.SetPosition(DataManager.CurrentPosition);
            ctlFullTrack.SetPosition(DataManager.CurrentPosition);
        }
        #endregion trackhandling

        private void SetupSpeedChart()
        {
            var currentLap = GetCurrentLap();
            if (currentLap != null)
            {
                // max speed from data
                float maxSpeed = 280;
                if (DataManager?.ReferenceLap?.TelemetryList != null)
                    maxSpeed = DataManager.ReferenceLap.TelemetryList.Max(t => t.SpeedMS) * 3.6f;
                ctlSpeed.InitializeChart(0, maxSpeed, currentLap.TelemetryList.Count, DataManager.SampleStep);
                ctlSpeed.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Speed));
                ctlSpeed.SetPositionIndex(DataManager.CurrentPositionIndex);
            }
        }

        private void SetupThrottleChart()
        {
            var currentLap = GetCurrentLap();
            if (currentLap != null)
            {
                // max speed from data
                float max = 255;
                ctlThrottle.InitializeChart(0, max, currentLap.TelemetryList.Count, DataManager.SampleStep);
                ctlThrottle.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Throttle));
                ctlThrottle.SetPositionIndex(DataManager.CurrentPositionIndex);
            }
        }

        private void SetupBrakeChart()
        {
            var currentLap = GetCurrentLap();
            if (currentLap != null)
            {
                // max speed from data
                float max = 255;
                ctlBrake.InitializeChart(0, max, currentLap.TelemetryList.Count, DataManager.SampleStep);
                ctlBrake.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Brake));
                ctlBrake.SetPositionIndex(DataManager.CurrentPositionIndex);
            }
        }

        private void RedrawAll()
        {
            ctlTrack.Refresh();
            ctlFullTrack.Refresh();
            ctlSpeed.Refresh();
        }

        private Chartline ConvertRaceline(IList<Raceline> raceline)
        {
            Chartline line = new Chartline();
            line.Type = DataType.Speed;
            line.LapId = (int)DataType.Speed + "_0";
            foreach(var entry in raceline)
            {
                line.Samples.Add(entry.SpeedMS*3.6f);
            }
            return line;
        }
        private void barZoom_ValueChanged(object sender, EventArgs e)
        {
            ctlTrack.SetZoom(barZoom.Value);
        }

        private void barLapPos_ValueChanged(object sender, EventArgs e)
        {
            if(DataManager?.Track!=null)
            {
                // check for selected lap
                var currentLap = GetCurrentLap();
                if (currentLap != null)
                {
                    int samples = currentLap.TelemetryList.Count;
                    int index = samples * barLapPos.Value / barLapPos.Maximum;
                    DataManager.CurrentPositionIndex = index - 1;
                    DataManager.CurrentPosition = currentLap.TelemetryList[index - 1].Position;
                }
                else
                {
                    int samples = DataManager.Track.Raceline.Count;
                    int index = samples * barLapPos.Value / barLapPos.Maximum;
                    DataManager.CurrentPositionIndex = index - 1;
                    DataManager.CurrentPosition = DataManager.Track.Raceline[index - 1].Position;
                }
                ctlTrack.SetPosition(DataManager.CurrentPosition);
                ctlFullTrack.SetPosition(DataManager.CurrentPosition);
                ctlSpeed.SetPositionIndex(DataManager.CurrentPositionIndex);
                ctlThrottle.SetPositionIndex(DataManager.CurrentPositionIndex);
                ctlBrake.SetPositionIndex(DataManager.CurrentPositionIndex);
            }
        }

        private void chkRaceline_CheckedChanged(object sender, EventArgs e)
        {
            ctlTrack.ShowRaceline = chkRaceline.Checked;
        }

        private void btnLoadLaps_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON|*.json";
            openFileDialog1.Title = "Load laps";
            openFileDialog1.InitialDirectory = Path.Combine(_dataRoot, "telemetry");
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                var telemetry=TelemetryImporter.LoadData(openFileDialog1.FileName);
                if(telemetry!=null)
                {
                    var laps = DataManager.ConvertToLapList(telemetry);
                    DataManager.Laps = laps;
                    foreach (var lap in laps)
                    {
                        lstLaps.Items.Add(lap.Laptime.ToString(@"hh\:mm\:ss\.fff") + " Lap " + lap.Lap);
                    }
                }
            }
            RedrawAll();
        }

        private LapData GetCurrentLap()
        {
            // check for selected lap
            return DataManager.Laps.FirstOrDefault(t => t.Show);
        }

        private void lstLaps_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataManager.Laps.Count; i++)
            {
                DataManager.Laps[i].Show = i == lstLaps.SelectedIndex;
            }
            var currentLap = DataManager.Laps.FirstOrDefault(t => t.Show);
            if (currentLap != null)
            {
                ctlSpeed.Lines.Clear();
                ctlSpeed.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Speed));
                ctlSpeed.SetPositionIndex(0);
                ctlThrottle.Lines.Clear();
                ctlThrottle.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Throttle));
                ctlThrottle.SetPositionIndex(0);
                ctlBrake.Lines.Clear();
                ctlBrake.Lines.Add(DataManager.ConvertToChartline(currentLap, DataType.Brake));
                ctlBrake.SetPositionIndex(0);

                ctlTrack.CurrentLap = currentLap;
                ctlFullTrack.CurrentLap = currentLap;
                SetupSpeedChart();
                SetupThrottleChart();
                SetupBrakeChart();
            }
            RedrawAll();
        }
    }
}