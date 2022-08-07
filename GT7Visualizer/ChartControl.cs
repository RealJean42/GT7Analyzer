using GT7Data;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT7Visualizer
{
    internal class ChartControl : Control
    {
        public List<Chartline> Lines { get; set; } = new List<Chartline>();
        /// <summary>
        /// Index of current data point
        /// </summary>
        public int CurrentPositionIndex { get; set; }
        protected float MinY { get; set; } = 0.0f;
        protected float MaxY { get; set; } = 100.0f;
        protected float MaxX { get; set; } = 1000.0f;
        /// <summary>
        /// Distance between samples.
        /// Default: 5 meters
        /// </summary>
        protected float SampleStep { get; set; } = 5.0f;
        protected BufferedGraphicsContext GfxContext { get; set; }
        protected BufferedGraphics Gfx { get; set; } 

        protected Bitmap ChartBmp { get; set; }

        protected float ScaleX { get; set; } = 1.0f;
        protected float ScaleY { get; set; } = 1.0f;


        public ChartControl()
        {
            base.DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            GfxContext = BufferedGraphicsManager.Current;
            GfxContext.MaximumBuffer = new Size(this.Width + 1, this.Height + 1);
            Gfx = GfxContext.Allocate(this.CreateGraphics(), new Rectangle(0, 0, this.Width, this.Height));
            ClearBuffer();
        }

        public void SetPositionIndex(int x)
        {
            CurrentPositionIndex = x;
            DrawChart();
        }

        /// <summary>
        /// MaxX is taken form samples count
        /// </summary>
        /// <param name="minX"></param>
        /// <param name="maxX"></param>
        /// <param name="sampleStep">meters between samples</param>
        public virtual void InitializeChart(float minY, float maxY, int maxSamples, float sampleStep)
        {
            MinY=minY;
            MaxY=maxY;
            MaxX = maxSamples;
            SampleStep = sampleStep;
            ScaleX = this.Width / MaxX;
            ScaleY = this.Height / MaxY;
            DrawChart();
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if(ChartBmp != null)
            {
                var g = Gfx.Graphics;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Rectangle src = new Rectangle(
                    0,
                    0,
                    ChartBmp.Width,
                    ChartBmp.Height
                    );
                Rectangle dest = new Rectangle(0, 0, this.Width, this.Height);
                g.DrawImage(ChartBmp, dest, src, GraphicsUnit.Pixel);
            }
            Gfx.Render(e.Graphics);
        }

        private void ClearBuffer()
        {
            Gfx.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
        }

        protected virtual void DrawPosition(Graphics g, int index, Chartline line)
        {
            Pen myPen = new Pen(Color.LightBlue);
            myPen.Width = Convert.ToInt32(ChartBmp.Width/this.Width*2);
            g.DrawLine(myPen, Convert.ToInt32(index * ScaleX), 0, Convert.ToInt32(index * ScaleX), ChartBmp.Height);
            var font = this.Font;
            TextRenderer.DrawText(g, line.Samples[index].ToString("F2"), this.Font, new Point(Convert.ToInt32((index + 10)*ScaleX), Convert.ToInt32(this.Height - (line.GetSampleConverted(index)*ScaleY))), line.LineColor);
        }

        protected virtual void DrawChart()
        {
            ClearBuffer();
            if (Lines != null)
            {
                ChartBmp = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(ChartBmp);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Pen myPen = new Pen(Color.CornflowerBlue);
                myPen.Width = 1;
                g.DrawLine(myPen, 0, Convert.ToInt32(this.Height * 0.25), this.Width, Convert.ToInt32(this.Height * 0.25));
                g.DrawLine(myPen, 0, Convert.ToInt32(this.Height * 0.5), this.Width, Convert.ToInt32(this.Height * 0.5));
                g.DrawLine(myPen, 0, Convert.ToInt32(this.Height * 0.75), this.Width, Convert.ToInt32(this.Height * 0.75));
                foreach(var line in Lines)
                {
                    myPen = new Pen(line.LineColor);
                    myPen.Width = 1;
                    List<Point> points = new List<Point>();
                    for (int i=0;i< line.Samples.Count;i++)
                    {
                        points.Add(new Point(Convert.ToInt32(i * ScaleX), Convert.ToInt32(this.Height-(line.GetSampleConverted(i)*ScaleY))));
                    }
                    g.DrawLines(myPen, points.ToArray());
                    myPen.Dispose();
                }
                foreach (var line in Lines)
                {
                    DrawPosition(g, CurrentPositionIndex, line);
                }
                g.Dispose();
            }
            Refresh();
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
            ScaleX = this.Width / MaxX;
            ScaleY = this.Height / MaxY;
            InitializeChart(MinY, MaxY, Convert.ToInt32(MaxX), SampleStep);
            Refresh();
        }

    }
}
