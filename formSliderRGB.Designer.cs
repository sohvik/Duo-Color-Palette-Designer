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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.ce_trackbarGreen2 = new Ce_TrackBar();
            this.ce_trackbarBlue2 = new Ce_TrackBar();
            this.ce_trackbarRed2 = new Ce_TrackBar();
            this.ce_trackbarBlue = new Ce_TrackBar();
            this.ce_trackbarGreen = new Ce_TrackBar();
            this.ce_trackbarRed = new Ce_TrackBar();
            this.lblBlueMain = new System.Windows.Forms.Label();
            this.lblGreenMain = new System.Windows.Forms.Label();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.lblRedMain = new System.Windows.Forms.Label();
            this.panelSecondaryColor = new System.Windows.Forms.Panel();
            this.panelMainColor = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.lblRedSecond = new System.Windows.Forms.Label();
            this.lblGreenSecond = new System.Windows.Forms.Label();
            this.lblBlueSecond = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelMainColor.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Controls.Add(this.ce_trackbarRed2);
            this.panelContainer.Controls.Add(this.ce_trackbarGreen2);
            this.panelContainer.Controls.Add(this.ce_trackbarBlue);
            this.panelContainer.Controls.Add(this.ce_trackbarBlue2);
            this.panelContainer.Controls.Add(this.ce_trackbarGreen);
            this.panelContainer.Controls.Add(this.ce_trackbarRed);
            this.panelContainer.Controls.Add(this.lblBlueSecond);
            this.panelContainer.Controls.Add(this.lblBlueMain);
            this.panelContainer.Controls.Add(this.lblGreenSecond);
            this.panelContainer.Controls.Add(this.lblGreenMain);
            this.panelContainer.Controls.Add(this.lblSecondaryColor);
            this.panelContainer.Controls.Add(this.lblMainColor);
            this.panelContainer.Controls.Add(this.lblRedSecond);
            this.panelContainer.Controls.Add(this.lblRedMain);
            this.panelContainer.Location = new System.Drawing.Point(48, 120);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(360, 528);
            this.panelContainer.TabIndex = 2;
            // 
            // ce_trackbarGreen2
            // 
            this.ce_trackbarGreen2.BallColor = System.Drawing.Color.Lime;
            this.ce_trackbarGreen2.JumpToMouse = false;
            this.ce_trackbarGreen2.Location = new System.Drawing.Point(59, 376);
            this.ce_trackbarGreen2.Maximum = 100;
            this.ce_trackbarGreen2.Minimum = 0;
            this.ce_trackbarGreen2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarGreen2.Name = "ce_trackbarGreen2";
            this.ce_trackbarGreen2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarGreen2.SlideColor = System.Drawing.Color.Lime;
            this.ce_trackbarGreen2.TabIndex = 4;
            this.ce_trackbarGreen2.Text = "ce_TrackBar1";
            this.ce_trackbarGreen2.Value = 0;
            this.ce_trackbarGreen2.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarGreen2.ValueToSet = 0F;
            this.ce_trackbarGreen2.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarGreen2_ValueChanged);
            // 
            // ce_trackbarBlue2
            // 
            this.ce_trackbarBlue2.BallColor = System.Drawing.Color.Blue;
            this.ce_trackbarBlue2.JumpToMouse = false;
            this.ce_trackbarBlue2.Location = new System.Drawing.Point(59, 432);
            this.ce_trackbarBlue2.Maximum = 100;
            this.ce_trackbarBlue2.Minimum = 0;
            this.ce_trackbarBlue2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarBlue2.Name = "ce_trackbarBlue2";
            this.ce_trackbarBlue2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarBlue2.SlideColor = System.Drawing.Color.Blue;
            this.ce_trackbarBlue2.TabIndex = 3;
            this.ce_trackbarBlue2.Text = "ce_TrackBar1";
            this.ce_trackbarBlue2.Value = 0;
            this.ce_trackbarBlue2.ValueDivison = Ce_TrackBar.ValueDivisor.By1;
            this.ce_trackbarBlue2.ValueToSet = 0F;
            this.ce_trackbarBlue2.ValueChanged += new Ce_TrackBar.ValueChangedEventHandler(this.ce_trackbarBlue2_ValueChanged);
            // 
            // ce_trackbarRed2
            // 
            this.ce_trackbarRed2.BallColor = System.Drawing.Color.Red;
            this.ce_trackbarRed2.JumpToMouse = false;
            this.ce_trackbarRed2.Location = new System.Drawing.Point(58, 320);
            this.ce_trackbarRed2.Maximum = 100;
            this.ce_trackbarRed2.Minimum = 0;
            this.ce_trackbarRed2.MinimumSize = new System.Drawing.Size(47, 22);
            this.ce_trackbarRed2.Name = "ce_trackbarRed2";
            this.ce_trackbarRed2.Size = new System.Drawing.Size(250, 22);
            this.ce_trackbarRed2.SlideColor = System.Drawing.Color.Red;
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
            this.ce_trackbarBlue.Location = new System.Drawing.Point(58, 190);
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
            this.ce_trackbarGreen.Location = new System.Drawing.Point(59, 133);
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
            this.ce_trackbarRed.Location = new System.Drawing.Point(59, 74);
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
            // lblBlueMain
            // 
            this.lblBlueMain.AutoSize = true;
            this.lblBlueMain.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBlueMain.Location = new System.Drawing.Point(54, 161);
            this.lblBlueMain.Name = "lblBlueMain";
            this.lblBlueMain.Size = new System.Drawing.Size(52, 28);
            this.lblBlueMain.TabIndex = 0;
            this.lblBlueMain.Text = "Blue";
            this.lblBlueMain.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGreenMain
            // 
            this.lblGreenMain.AutoSize = true;
            this.lblGreenMain.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGreenMain.Location = new System.Drawing.Point(53, 102);
            this.lblGreenMain.Name = "lblGreenMain";
            this.lblGreenMain.Size = new System.Drawing.Size(67, 28);
            this.lblGreenMain.TabIndex = 0;
            this.lblGreenMain.Text = "Green";
            this.lblGreenMain.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMainColor
            // 
            this.lblMainColor.AutoSize = true;
            this.lblMainColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainColor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMainColor.Location = new System.Drawing.Point(0, 0);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(151, 28);
            this.lblMainColor.TabIndex = 0;
            this.lblMainColor.Text = "Edit Main Color";
            this.lblMainColor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRedMain
            // 
            this.lblRedMain.AutoSize = true;
            this.lblRedMain.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRedMain.Location = new System.Drawing.Point(54, 42);
            this.lblRedMain.Name = "lblRedMain";
            this.lblRedMain.Size = new System.Drawing.Size(46, 28);
            this.lblRedMain.TabIndex = 0;
            this.lblRedMain.Text = "Red";
            this.lblRedMain.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelSecondaryColor
            // 
            this.panelSecondaryColor.BackColor = System.Drawing.Color.Transparent;
            this.panelSecondaryColor.Location = new System.Drawing.Point(0, 0);
            this.panelSecondaryColor.Name = "panelSecondaryColor";
            this.panelSecondaryColor.Size = new System.Drawing.Size(420, 200);
            this.panelSecondaryColor.TabIndex = 0;
            this.panelSecondaryColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSecondaryColor_Paint);
            // 
            // panelMainColor
            // 
            this.panelMainColor.BackColor = System.Drawing.Color.Black;
            this.panelMainColor.Controls.Add(this.panelSecondaryColor);
            this.panelMainColor.Location = new System.Drawing.Point(464, 48);
            this.panelMainColor.Name = "panelMainColor";
            this.panelMainColor.Size = new System.Drawing.Size(420, 600);
            this.panelMainColor.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(32, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Duo Color Palette Editor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Location = new System.Drawing.Point(48, 48);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(360, 36);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaryColor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSecondaryColor.Location = new System.Drawing.Point(0, 249);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(201, 28);
            this.lblSecondaryColor.TabIndex = 0;
            this.lblSecondaryColor.Text = "Edit Secondary Color";
            this.lblSecondaryColor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRedSecond
            // 
            this.lblRedSecond.AutoSize = true;
            this.lblRedSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedSecond.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRedSecond.Location = new System.Drawing.Point(54, 289);
            this.lblRedSecond.Name = "lblRedSecond";
            this.lblRedSecond.Size = new System.Drawing.Size(46, 28);
            this.lblRedSecond.TabIndex = 0;
            this.lblRedSecond.Text = "Red";
            this.lblRedSecond.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGreenSecond
            // 
            this.lblGreenSecond.AutoSize = true;
            this.lblGreenSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenSecond.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGreenSecond.Location = new System.Drawing.Point(54, 345);
            this.lblGreenSecond.Name = "lblGreenSecond";
            this.lblGreenSecond.Size = new System.Drawing.Size(67, 28);
            this.lblGreenSecond.TabIndex = 0;
            this.lblGreenSecond.Text = "Green";
            this.lblGreenSecond.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBlueSecond
            // 
            this.lblBlueSecond.AutoSize = true;
            this.lblBlueSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueSecond.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBlueSecond.Location = new System.Drawing.Point(54, 401);
            this.lblBlueSecond.Name = "lblBlueSecond";
            this.lblBlueSecond.Size = new System.Drawing.Size(52, 28);
            this.lblBlueSecond.TabIndex = 0;
            this.lblBlueSecond.Text = "Blue";
            this.lblBlueSecond.Click += new System.EventHandler(this.label2_Click);
            // 
            // formSliderRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 700);
            this.Controls.Add(this.panelMainColor);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formSliderRGB";
            this.Text = "formSliderRGB";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelMainColor.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMainColor;
        private System.Windows.Forms.Label lblRedMain;
        private Ce_TrackBar ce_trackbarRed;
        private Ce_TrackBar ce_trackbarBlue;
        private Ce_TrackBar ce_trackbarGreen;
        private System.Windows.Forms.Label lblBlueMain;
        private System.Windows.Forms.Label lblGreenMain;
        private System.Windows.Forms.Label lblMainColor;
        private System.Windows.Forms.Panel panelSecondaryColor;
        private Ce_TrackBar ce_trackbarRed2;
        private Ce_TrackBar ce_trackbarBlue2;
        private Ce_TrackBar ce_trackbarGreen2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblSecondaryColor;
        private System.Windows.Forms.Label lblGreenSecond;
        private System.Windows.Forms.Label lblRedSecond;
        private System.Windows.Forms.Label lblBlueSecond;
    }
}