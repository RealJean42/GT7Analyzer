using GT7Data;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT7Visualizer
{
    internal class TrackControl : Control
    {
        protected BufferedGraphicsContext GfxContext { get; set; }
        protected BufferedGraphics Gfx { get; set; } 

        public TelemetryManager DataManager { get; set; }

        public LapData CurrentLap { get; set; }

        protected int _border = 50;
        private bool _showRaceline=false;
        public bool ShowRaceline 
        { 
            get => _showRaceline; 
            set
            {
                if(_showRaceline!=value)
                {
                    _showRaceline=value;
                    DrawTrack();
                }
            }
        }
        protected int Zoom { get; set; } = 1;

        protected Bitmap TrackBmp { get; set; }

        public TrackControl()
        {
            base.DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            GfxContext = BufferedGraphicsManager.Current;
            GfxContext.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            Gfx = GfxContext.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height));
            ClearBuffer();
        }

        public void SetZoom(int zoom)
        {
            Zoom = zoom;
            DrawTrack();
        }

        public void SetPosition(Vector3Ser position)
        {
            DrawTrack();
        }

        public virtual void InitializeTrack(TelemetryManager dataManager, bool showRaceline)
        {
            DataManager = dataManager;
            ShowRaceline = showRaceline;
            if (DataManager?.Track != null)
            {
                if (DataManager.CurrentPosition.AsStruct().Length() == 0.0f)
                {
                    DataManager.CurrentPosition = DataManager.Track.Raceline[0].Position;
                }
                DrawTrack();
            }
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Zoom < 1) Zoom = 1;
            if (DataManager?.Track != null && TrackBmp != null)
            {
                int clipWidth = this.Width;
                int clipHeight = this.Height;
                //var buffer = new Bitmap(TrackBmp.Width, TrackBmp.Height);
                //var g = Graphics.FromImage(buffer);
                var g = Gfx.Graphics;
                g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                int trackMaxPixel = TrackBmp.Width > TrackBmp.Height ? TrackBmp.Width : TrackBmp.Height;
                Vector3Ser center = DataManager.CurrentPosition;
                float offset = trackMaxPixel / (2 * Zoom);
                float xOffset = Math.Abs(DataManager.Track.MinX) + _border / 2;
                float yOffset = Math.Abs(DataManager.Track.MinZ) + _border / 2;
                Rectangle src = new Rectangle(
                    Convert.ToInt32(center.X + xOffset - offset),
                    Convert.ToInt32(center.Z + yOffset - offset),
                    Convert.ToInt32(offset * 2),
                    Convert.ToInt32(offset * 2)
                    );
                Rectangle dest = new Rectangle(0, 0, clipWidth, clipHeight);
                g.DrawImage(TrackBmp, dest, src, GraphicsUnit.Pixel);
                DrawCar(g, clipWidth / 2, clipHeight / 2);
            }
            Gfx.Render(e.Graphics);
        }

        private void ClearBuffer()
        {
            Gfx.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
        }

        protected virtual void DrawCar(Graphics g, int x, int y)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;
            g.DrawEllipse(myPen, x - 4, y - 4, 7, 7);
        }

        protected virtual void DrawTrack()
        {
            if (DataManager?.Track != null)
            {
                ClearBuffer();
                if (DataManager?.Track != null)
                {
                    var track = DataManager.Track;
                    int sizeX = Convert.ToInt32(Math.Abs(track.MinX) + track.MaxX + _border);
                    int sizeY = Convert.ToInt32(Math.Abs(track.MinZ) + track.MaxZ + _border);
                    int xOffset = Convert.ToInt32(Math.Abs(track.MinX) + _border / 2);
                    int yOffset = Convert.ToInt32(Math.Abs(track.MinZ) + _border / 2);
                    TrackBmp = new Bitmap(sizeX, sizeY);
                    Graphics g = Graphics.FromImage(TrackBmp);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    Pen myPen = new Pen(Color.OrangeRed);
                    myPen.Width = 2;
                    List<Point> points = new List<Point>();
                    if (ShowRaceline)
                    {
                        foreach (var point in track.Raceline)
                        {
                            points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
                        }
                        g.DrawLines(myPen, points.ToArray());
                    }
                    myPen.Dispose();
                    myPen = new Pen(Color.Black);
                    myPen.Width = 1;
                    points = new List<Point>();
                    foreach (var point in track.TrackLeft)
                    {
                        points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
                    }
                    g.DrawLines(myPen, points.ToArray());

                    points = new List<Point>();
                    foreach (var point in track.TrackRight)
                    {
                        points.Add(new Point(Convert.ToInt32(point.Position.X + xOffset), Convert.ToInt32(point.Position.Z + yOffset)));
                    }

                    g.DrawLines(myPen, points.ToArray());
                    g.Dispose();
                }
                Refresh();
            }
        }
        protected override void OnResize(EventArgs e)
        {
            GfxContext.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            if (Gfx != null)
            {
                Gfx.Dispose();
                Gfx = null;
            }        
            Gfx = GfxContext.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height));
            Refresh();
        }

    }
}
