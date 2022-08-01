using GT7Data;
using System.Drawing.Drawing2D;

namespace GT7Visualizer
{
    public partial class Form1 : Form
    {
        private string _dataRoot = "";
        private Track Track { get; set; }
        public Form1()
        {
            InitializeComponent();
            _dataRoot = System.Configuration.ConfigurationManager.AppSettings["dataroot"] + "";

        }

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
                Track = trackManager.LoadTrack(openFileDialog1.FileName);
                if(Track!=null)
                {
                    lblDimX.Text = @$"{Track.MinX.ToString("F2")}/{Track.MaxX.ToString("F2")}";
                    lblDimY.Text = $"{Track.MinZ.ToString("F2")}/{Track.MaxZ.ToString("F2")}";
                    SetupCanvas();
                }
                else
                {
                    lblDimX.Text = "0/0";
                    lblDimX.Text = "0/0";
                }
            }
        }

        private void SetupCanvas()
        {
            int sizeX = Convert.ToInt32(Math.Abs(Track.MinX) + Track.MaxX + 100);
            int sizeY = Convert.ToInt32(Math.Abs(Track.MinZ) + Track.MaxZ + 100);
            int xOffset = Convert.ToInt32(Math.Abs(Track.MinX) + 50);
            int yOffset = Convert.ToInt32(Math.Abs(Track.MinZ) + 50);
            Bitmap map = new Bitmap(sizeX, sizeY);
            Graphics g = Graphics.FromImage(map);
            g.InterpolationMode = InterpolationMode.Bicubic; 
            
            Pen myPen = new Pen(Color.OrangeRed);
            myPen.Width = 2;
            List<Point> points = new List<Point>();
            foreach (var point in Track.Raceline)
            {
                points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
             }
            g.DrawLines(myPen, points.ToArray());

            myPen.Dispose();
            myPen = new Pen(Color.Black);
            myPen.Width = 1;
            points = new List<Point>();
            foreach (var point in Track.TrackLeft)
            {
                points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
            }
            g.DrawLines(myPen, points.ToArray());

            points = new List<Point>();
            foreach (var point in Track.TrackRight)
            {
                points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
            }

            g.DrawLines(myPen, points.ToArray());
            pictureBox1.Image = map;

        }
    }
}