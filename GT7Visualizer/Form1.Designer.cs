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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDimX = new System.Windows.Forms.Label();
            this.lblDimY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1439, 809);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X (min/max):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Z (min/max):";
            // 
            // lblDimX
            // 
            this.lblDimX.AutoSize = true;
            this.lblDimX.Location = new System.Drawing.Point(226, 16);
            this.lblDimX.Name = "lblDimX";
            this.lblDimX.Size = new System.Drawing.Size(24, 15);
            this.lblDimX.TabIndex = 4;
            this.lblDimX.Text = "0/0";
            // 
            // lblDimY
            // 
            this.lblDimY.AutoSize = true;
            this.lblDimY.Location = new System.Drawing.Point(371, 16);
            this.lblDimY.Name = "lblDimY";
            this.lblDimY.Size = new System.Drawing.Size(24, 15);
            this.lblDimY.TabIndex = 5;
            this.lblDimY.Text = "0/0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 849);
            this.Controls.Add(this.lblDimY);
            this.Controls.Add(this.lblDimX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadTrack);
            this.Name = "Form1";
            this.Text = "GT7 Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoadTrack;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblDimX;
        private Label lblDimY;
    }
}