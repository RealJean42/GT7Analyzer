using GT7Data;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT7Visualizer
{
    internal class FullTrackControl : TrackControl
    {

        public FullTrackControl() : base() { }

        public override void InitializeTrack(TelemetryManager dataManager, bool showRaceline=false)
        {
            DataManager = dataManager;
            ShowRaceline = showRaceline;
            if (DataManager?.Track != null)
            {
                DrawTrack();
            }
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DataManager?.Track!=null && TrackBmp != null)
            {
                float scale = TrackBmp.Width > TrackBmp.Height ? this.Width / (float)TrackBmp.Width : this.Height / (float)TrackBmp.Height;
                var g = Gfx.Graphics;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Rectangle src = new Rectangle(0, 0, TrackBmp.Width, TrackBmp.Height);
                Rectangle dest = new Rectangle(0, 0, Convert.ToInt32(TrackBmp.Width * scale), Convert.ToInt32(TrackBmp.Height * scale));
                g.DrawImage(TrackBmp,dest,src,GraphicsUnit.Pixel);
                Vector3Ser center = DataManager.CurrentPosition;
                float xOffset = Math.Abs(DataManager.Track.MinX) + _border / 2;
                float yOffset = Math.Abs(DataManager.Track.MinZ) + _border / 2;

                DrawCar(g, Convert.ToInt32((center.X + xOffset)*scale), Convert.ToInt32((center.Z + yOffset) * scale));
            }
            Gfx.Render(e.Graphics);
        }
        protected override void DrawCar(Graphics g, int x, int y)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;
            g.DrawEllipse(myPen, x - 4, y - 4, 7, 7);
        }

    }
}
