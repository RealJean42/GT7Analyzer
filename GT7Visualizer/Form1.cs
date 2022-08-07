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
            // max speed from data
            float maxSpeed = 280;
            if (DataManager?.ReferenceLap?.TelemetryList != null)
                maxSpeed = DataManager.ReferenceLap.TelemetryList.Max(t => t.SpeedMS)*3.6f;
            ctlSpeed.InitializeChart(0, maxSpeed, DataManager.Track.Raceline.Count, DataManager.SampleStep);
            ctlSpeed.Lines.Add(ConvertRaceline(DataManager.Track.Raceline));
            ctlSpeed.SetPositionIndex(DataManager.CurrentPositionIndex);
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
                int samples = DataManager.Track.Raceline.Count;
                int index = samples * barLapPos.Value / barLapPos.Maximum;
                DataManager.CurrentPositionIndex = index - 1;
                DataManager.CurrentPosition = DataManager.Track.Raceline[index-1].Position;
                ctlTrack.SetPosition(DataManager.CurrentPosition);
                ctlFullTrack.SetPosition(DataManager.CurrentPosition);
                ctlSpeed.SetPositionIndex(DataManager.CurrentPositionIndex);
            }
        }

        private void chkRaceline_CheckedChanged(object sender, EventArgs e)
        {
            ctlTrack.ShowRaceline = chkRaceline.Checked;
        }
    }
}