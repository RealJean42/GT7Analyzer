namespace GT7Visualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadTrack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDimX = new System.Windows.Forms.Label();
            this.lblDimY = new System.Windows.Forms.Label();
            this.lblTrackname = new System.Windows.Forms.Label();
            this.barZoom = new System.Windows.Forms.TrackBar();
            this.ctlTrack = new GT7Visualizer.TrackControl();
            this.barLapPos = new System.Windows.Forms.TrackBar();
            this.chkRaceline = new System.Windows.Forms.CheckBox();
            this.ctlFullTrack = new GT7Visualizer.FullTrackControl();
            ((System.ComponentModel.ISupportInitialize)(this.barZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLapPos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadTrack
            // 
            this.btnLoadTrack.Location = new System.Drawing.Point(12, 12);
            this.btnLoadTrack.Name = "btnLoadTrack";
            this.btnLoadTrack.Size = new System.Drawing.Size(108, 23);
            this.btnLoadTrack.TabIndex = 0;
            this.btnLoadTrack.Text = "Load track";
            this.btnLoadTrack.UseVisualStyleBackColor = true;
            this.btnLoadTrack.Click += new System.EventHandler(this.btnLoadTrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X (min/max):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Z (min/max):";
            // 
            // lblDimX
            // 
            this.lblDimX.AutoSize = true;
            this.lblDimX.Location = new System.Drawing.Point(428, 16);
            this.lblDimX.Name = "lblDimX";
            this.lblDimX.Size = new System.Drawing.Size(24, 15);
            this.lblDimX.TabIndex = 4;
            this.lblDimX.Text = "0/0";
            // 
            // lblDimY
            // 
            this.lblDimY.AutoSize = true;
            this.lblDimY.Location = new System.Drawing.Point(596, 16);
            this.lblDimY.Name = "lblDimY";
            this.lblDimY.Size = new System.Drawing.Size(24, 15);
            this.lblDimY.TabIndex = 5;
            this.lblDimY.Text = "0/0";
            // 
            // lblTrackname
            // 
            this.lblTrackname.AutoSize = true;
            this.lblTrackname.Location = new System.Drawing.Point(157, 16);
            this.lblTrackname.Name = "lblTrackname";
            this.lblTrackname.Size = new System.Drawing.Size(0, 15);
            this.lblTrackname.TabIndex = 6;
            // 
            // barZoom
            // 
            this.barZoom.Location = new System.Drawing.Point(464, 41);
            this.barZoom.Maximum = 50;
            this.barZoom.Minimum = 4;
            this.barZoom.Name = "barZoom";
            this.barZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barZoom.Size = new System.Drawing.Size(45, 220);
            this.barZoom.TabIndex = 7;
            this.barZoom.Value = 4;
            this.barZoom.ValueChanged += new System.EventHandler(this.barZoom_ValueChanged);
            // 
            // ctlTrack
            // 
            this.ctlTrack.BackColor = System.Drawing.SystemColors.Window;
            this.ctlTrack.DataManager = null;
            this.ctlTrack.Location = new System.Drawing.Point(238, 41);
            this.ctlTrack.Name = "ctlTrack";
            this.ctlTrack.ShowRaceline = false;
            this.ctlTrack.Size = new System.Drawing.Size(220, 220);
            this.ctlTrack.TabIndex = 8;
            this.ctlTrack.Text = "trackControl1";
            // 
            // barLapPos
            // 
            this.barLapPos.Location = new System.Drawing.Point(12, 267);
            this.barLapPos.Maximum = 500;
            this.barLapPos.Minimum = 1;
            this.barLapPos.Name = "barLapPos";
            this.barLapPos.Size = new System.Drawing.Size(446, 45);
            this.barLapPos.TabIndex = 10;
            this.barLapPos.Value = 1;
            this.barLapPos.ValueChanged += new System.EventHandler(this.barLapPos_ValueChanged);
            // 
            // chkRaceline
            // 
            this.chkRaceline.AutoSize = true;
            this.chkRaceline.Location = new System.Drawing.Point(507, 41);
            this.chkRaceline.Name = "chkRaceline";
            this.chkRaceline.Size = new System.Drawing.Size(70, 19);
            this.chkRaceline.TabIndex = 11;
            this.chkRaceline.Text = "Raceline";
            this.chkRaceline.UseVisualStyleBackColor = true;
            this.chkRaceline.CheckedChanged += new System.EventHandler(this.chkRaceline_CheckedChanged);
            // 
            // ctlFullTrack
            // 
            this.ctlFullTrack.DataManager = null;
            this.ctlFullTrack.Location = new System.Drawing.Point(12, 41);
            this.ctlFullTrack.Name = "ctlFullTrack";
            this.ctlFullTrack.ShowRaceline = false;
            this.ctlFullTrack.Size = new System.Drawing.Size(220, 220);
            this.ctlFullTrack.TabIndex = 12;
            this.ctlFullTrack.Text = "fullTrackControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 849);
            this.Controls.Add(this.ctlFullTrack);
            this.Controls.Add(this.chkRaceline);
            this.Controls.Add(this.barLapPos);
            this.Controls.Add(this.ctlTrack);
            this.Controls.Add(this.barZoom);
            this.Controls.Add(this.lblTrackname);
            this.Controls.Add(this.lblDimY);
            this.Controls.Add(this.lblDimX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadTrack);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "GT7 Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.barZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLapPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadTrack;
        private Label label1;
        private Label label2;
        private Label lblDimX;
        private Label lblDimY;
        private Label lblTrackname;
        private TrackBar barZoom;
        private TrackControl ctlTrack;
        private TrackBar barLapPos;
        private CheckBox chkRaceline;
        private FullTrackControl ctlFullTrack;
    }
}