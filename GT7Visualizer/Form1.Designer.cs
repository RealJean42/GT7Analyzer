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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadTrack = new System.Windows.Forms.Button();
            this.lblTrackname = new System.Windows.Forms.Label();
            this.barZoom = new System.Windows.Forms.TrackBar();
            this.ctlTrack = new GT7Visualizer.TrackControl();
            this.barLapPos = new System.Windows.Forms.TrackBar();
            this.chkRaceline = new System.Windows.Forms.CheckBox();
            this.ctlFullTrack = new GT7Visualizer.FullTrackControl();
            this.ctlSpeed = new GT7Visualizer.ChartControl();
            this.btnLoadLaps = new System.Windows.Forms.Button();
            this.lstLaps = new System.Windows.Forms.CheckedListBox();
            this.ctlThrottle = new GT7Visualizer.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlBrake = new GT7Visualizer.ChartControl();
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
            this.ctlTrack.CurrentLap = null;
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
            this.chkRaceline.Location = new System.Drawing.Point(388, 12);
            this.chkRaceline.Name = "chkRaceline";
            this.chkRaceline.Size = new System.Drawing.Size(70, 19);
            this.chkRaceline.TabIndex = 11;
            this.chkRaceline.Text = "Raceline";
            this.chkRaceline.UseVisualStyleBackColor = true;
            this.chkRaceline.CheckedChanged += new System.EventHandler(this.chkRaceline_CheckedChanged);
            // 
            // ctlFullTrack
            // 
            this.ctlFullTrack.CurrentLap = null;
            this.ctlFullTrack.DataManager = null;
            this.ctlFullTrack.Location = new System.Drawing.Point(12, 41);
            this.ctlFullTrack.Name = "ctlFullTrack";
            this.ctlFullTrack.ShowRaceline = false;
            this.ctlFullTrack.Size = new System.Drawing.Size(220, 220);
            this.ctlFullTrack.TabIndex = 12;
            this.ctlFullTrack.Text = "fullTrackControl1";
            // 
            // ctlSpeed
            // 
            this.ctlSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSpeed.BackColor = System.Drawing.Color.Navy;
            this.ctlSpeed.CurrentPositionIndex = 0;
            this.ctlSpeed.ForeColor = System.Drawing.Color.White;
            this.ctlSpeed.Location = new System.Drawing.Point(12, 318);
            this.ctlSpeed.Name = "ctlSpeed";
            this.ctlSpeed.Size = new System.Drawing.Size(1414, 160);
            this.ctlSpeed.TabIndex = 13;
            this.ctlSpeed.Text = "chartControl1";
            // 
            // btnLoadLaps
            // 
            this.btnLoadLaps.Location = new System.Drawing.Point(526, 8);
            this.btnLoadLaps.Name = "btnLoadLaps";
            this.btnLoadLaps.Size = new System.Drawing.Size(90, 24);
            this.btnLoadLaps.TabIndex = 15;
            this.btnLoadLaps.Text = "Load Laps";
            this.btnLoadLaps.UseVisualStyleBackColor = true;
            this.btnLoadLaps.Click += new System.EventHandler(this.btnLoadLaps_Click);
            // 
            // lstLaps
            // 
            this.lstLaps.FormattingEnabled = true;
            this.lstLaps.Location = new System.Drawing.Point(526, 41);
            this.lstLaps.Name = "lstLaps";
            this.lstLaps.Size = new System.Drawing.Size(657, 220);
            this.lstLaps.TabIndex = 16;
            this.lstLaps.SelectedValueChanged += new System.EventHandler(this.lstLaps_SelectedValueChanged);
            // 
            // ctlThrottle
            // 
            this.ctlThrottle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlThrottle.BackColor = System.Drawing.Color.Navy;
            this.ctlThrottle.CurrentPositionIndex = 0;
            this.ctlThrottle.ForeColor = System.Drawing.Color.White;
            this.ctlThrottle.Location = new System.Drawing.Point(12, 507);
            this.ctlThrottle.Name = "ctlThrottle";
            this.ctlThrottle.Size = new System.Drawing.Size(1414, 160);
            this.ctlThrottle.TabIndex = 17;
            this.ctlThrottle.Text = "chartControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Speed (km/h)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Throttle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 679);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Brake";
            // 
            // ctlBrake
            // 
            this.ctlBrake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlBrake.BackColor = System.Drawing.Color.Navy;
            this.ctlBrake.CurrentPositionIndex = 0;
            this.ctlBrake.ForeColor = System.Drawing.Color.White;
            this.ctlBrake.Location = new System.Drawing.Point(12, 697);
            this.ctlBrake.Name = "ctlBrake";
            this.ctlBrake.Size = new System.Drawing.Size(1414, 160);
            this.ctlBrake.TabIndex = 20;
            this.ctlBrake.Text = "chartControl2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 866);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctlBrake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlThrottle);
            this.Controls.Add(this.lstLaps);
            this.Controls.Add(this.btnLoadLaps);
            this.Controls.Add(this.ctlSpeed);
            this.Controls.Add(this.ctlFullTrack);
            this.Controls.Add(this.chkRaceline);
            this.Controls.Add(this.barLapPos);
            this.Controls.Add(this.ctlTrack);
            this.Controls.Add(this.barZoom);
            this.Controls.Add(this.lblTrackname);
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
        private Label lblTrackname;
        private TrackBar barZoom;
        private TrackControl ctlTrack;
        private TrackBar barLapPos;
        private CheckBox chkRaceline;
        private FullTrackControl ctlFullTrack;
        private ChartControl ctlSpeed;
        private Button btnLoadLaps;
        private CheckedListBox lstLaps;
        private ChartControl ctlThrottle;
        private Label label1;
        private Label label2;
        private Label label3;
        private ChartControl ctlBrake;
    }
}