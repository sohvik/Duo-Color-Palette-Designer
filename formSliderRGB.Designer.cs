namespace Projekti3
{
    partial class formSliderRGB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ce_trackbarGreen2 = new Ce_TrackBar();
            this.ce_trackbarBlue2 = new Ce_TrackBar();
            this.ce_trackbarRed2 = new Ce_TrackBar();
            this.ce_trackbarBlue = new Ce_TrackBar();
            this.ce_trackbarGreen = new Ce_TrackBar();
            this.ce_trackbarRed = new Ce_TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.panelSecondaryColor = new System.Windows.Forms.Panel();
            this.panelMainColor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMainColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(27, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Color Palette Editor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(48, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 66);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ce_trackbarGreen2);
            this.panel2.Controls.Add(this.ce_trackbarBlue2);
            this.panel2.Controls.Add(this.ce_trackbarRed2);
            this.panel2.Controls.Add(this.ce_trackbarBlue);
            this.panel2.Controls.Add(this.ce_trackbarGreen);
            this.panel2.Controls.Add(this.ce_trackbarRed);
            this.panel2.Controls.Add(this.lblBlue);
            this.panel2.Controls.Add(this.lblGreen);
            this.panel2.Controls.Add(this.lblMainColor);
            this.panel2.Controls.Add(this.lblRed);
            this.panel2.Location = new System.Drawing.Point(48, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 532);
            this.panel2.TabIndex = 2;
            // 
            // ce_trackbarGreen2
            // 
            this.ce_trackbarGreen2.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarGreen2.JumpToMouse = false;
            this.ce_trackbarGreen2.Location = new System.Drawing.Point(24, 322);
            this.ce_trackbarGreen2.Maximum = 100;
            this.ce_trackbarGreen2.Minimum = 0;
            this.ce_trackbarGreen2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarGreen2.Name = "ce_trackbarGreen2";
            this.ce_trackbarGreen2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarGreen2.SlideColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarGreen2.TabIndex = 4;
            this.ce_trackbarGreen2.Text = "ce_TrackBar1";
            this.ce_trackbarGreen2.Value = 0;
            this.ce_trackbarGreen2.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarGreen2.ValueToSet = 0F;
            this.ce_trackbarGreen2.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarGreen2_ValueChanged);
            // 
            // ce_trackbarBlue2
            // 
            this.ce_trackbarBlue2.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarBlue2.JumpToMouse = false;
            this.ce_trackbarBlue2.Location = new System.Drawing.Point(24, 371);
            this.ce_trackbarBlue2.Maximum = 100;
            this.ce_trackbarBlue2.Minimum = 0;
            this.ce_trackbarBlue2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarBlue2.Name = "ce_trackbarBlue2";
            this.ce_trackbarBlue2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarBlue2.SlideColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarBlue2.TabIndex = 3;
            this.ce_trackbarBlue2.Text = "ce_TrackBar1";
            this.ce_trackbarBlue2.Value = 0;
            this.ce_trackbarBlue2.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarBlue2.ValueToSet = 0F;
            this.ce_trackbarBlue2.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarBlue2_ValueChanged);
            // 
            // ce_trackbarRed2
            // 
            this.ce_trackbarRed2.BallColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarRed2.JumpToMouse = false;
            this.ce_trackbarRed2.Location = new System.Drawing.Point(24, 275);
            this.ce_trackbarRed2.Maximum = 100;
            this.ce_trackbarRed2.Minimum = 0;
            this.ce_trackbarRed2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarRed2.Name = "ce_trackbarRed2";
            this.ce_trackbarRed2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarRed2.SlideColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(62)))), ((int)(((byte)(254)))));
            this.ce_trackbarRed2.TabIndex = 2;
            this.ce_trackbarRed2.Text = "ce_TrackBar1";
            this.ce_trackbarRed2.Value = 0;
            this.ce_trackbarRed2.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarRed2.ValueToSet = 0F;
            this.ce_trackbarRed2.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarRed2_ValueChanged);
            // 
            // ce_trackbarBlue
            // 
            this.ce_trackbarBlue.BallColor = System.Drawing.Color.Blue;
            this.ce_trackbarBlue.JumpToMouse = false;
            this.ce_trackbarBlue.Location = new System.Drawing.Point(24, 185);
            this.ce_trackbarBlue.Maximum = 100;
            this.ce_trackbarBlue.Minimum = 0;
            this.ce_trackbarBlue.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarBlue.Name = "ce_trackbarBlue";
            this.ce_trackbarBlue.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarBlue.SlideColor = System.Drawing.Color.Blue;
            this.ce_trackbarBlue.TabIndex = 1;
            this.ce_trackbarBlue.Text = "ce_TrackBar1";
            this.ce_trackbarBlue.Value = 0;
            this.ce_trackbarBlue.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarBlue.ValueToSet = 0F;
            this.ce_trackbarBlue.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarBlue_ValueChanged);
            // 
            // ce_trackbarGreen
            // 
            this.ce_trackbarGreen.BallColor = System.Drawing.Color.Lime;
            this.ce_trackbarGreen.JumpToMouse = false;
            this.ce_trackbarGreen.Location = new System.Drawing.Point(25, 128);
            this.ce_trackbarGreen.Maximum = 100;
            this.ce_trackbarGreen.Minimum = 0;
            this.ce_trackbarGreen.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarGreen.Name = "ce_trackbarGreen";
            this.ce_trackbarGreen.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarGreen.SlideColor = System.Drawing.Color.Lime;
            this.ce_trackbarGreen.TabIndex = 1;
            this.ce_trackbarGreen.Text = "ce_TrackBar1";
            this.ce_trackbarGreen.Value = 0;
            this.ce_trackbarGreen.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarGreen.ValueToSet = 0F;
            this.ce_trackbarGreen.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarGreen_ValueChanged);
            // 
            // ce_trackbarRed
            // 
            this.ce_trackbarRed.BallColor = System.Drawing.Color.Red;
            this.ce_trackbarRed.JumpToMouse = false;
            this.ce_trackbarRed.Location = new System.Drawing.Point(25, 69);
            this.ce_trackbarRed.Maximum = 100;
            this.ce_trackbarRed.Minimum = 0;
            this.ce_trackbarRed.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarRed.Name = "ce_trackbarRed";
            this.ce_trackbarRed.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarRed.SlideColor = System.Drawing.Color.Red;
            this.ce_trackbarRed.TabIndex = 1;
            this.ce_trackbarRed.Text = "ce_TrackBar1";
            this.ce_trackbarRed.Value = 0;
            this.ce_trackbarRed.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarRed.ValueToSet = 0F;
            this.ce_trackbarRed.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarRed_ValueChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBlue.Location = new System.Drawing.Point(20, 156);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(52, 28);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue";
            this.lblBlue.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGreen.Location = new System.Drawing.Point(19, 97);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(67, 28);
            this.lblGreen.TabIndex = 0;
            this.lblGreen.Text = "Green";
            this.lblGreen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMainColor
            // 
            this.lblMainColor.AutoSize = true;
            this.lblMainColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainColor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMainColor.Location = new System.Drawing.Point(72, 7);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(151, 28);
            this.lblMainColor.TabIndex = 0;
            this.lblMainColor.Text = "Edit Main Color";
            this.lblMainColor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRed.Location = new System.Drawing.Point(20, 37);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(46, 28);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red";
            this.lblRed.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelSecondaryColor
            // 
            this.panelSecondaryColor.BackColor = System.Drawing.Color.Transparent;
            this.panelSecondaryColor.Location = new System.Drawing.Point(0, 0);
            this.panelSecondaryColor.Name = "panelSecondaryColor";
            this.panelSecondaryColor.Size = new System.Drawing.Size(419, 210);
            this.panelSecondaryColor.TabIndex = 0;
            this.panelSecondaryColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSecondaryColor_Paint);
            // 
            // panelMainColor
            // 
            this.panelMainColor.BackColor = System.Drawing.Color.Black;
            this.panelMainColor.Controls.Add(this.panelSecondaryColor);
            this.panelMainColor.Location = new System.Drawing.Point(433, 48);
            this.panelMainColor.Name = "panelMainColor";
            this.panelMainColor.Size = new System.Drawing.Size(419, 604);
            this.panelMainColor.TabIndex = 2;
            // 
            // formSliderRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.panelMainColor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formSliderRGB";
            this.Text = "formSliderRGB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMainColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMainColor;
        private System.Windows.Forms.Label lblRed;
        private Ce_TrackBar ce_trackbarRed;
        private Ce_TrackBar ce_trackbarBlue;
        private Ce_TrackBar ce_trackbarGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblMainColor;
        private System.Windows.Forms.Panel panelSecondaryColor;
        private Ce_TrackBar ce_trackbarRed2;
        private Ce_TrackBar ce_trackbarBlue2;
        private Ce_TrackBar ce_trackbarGreen2;
    }
}