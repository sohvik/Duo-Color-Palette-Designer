namespace Projekti3
{
    partial class formMenu
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
            this.btnNewDuoPalette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDuoPalette
            // 
            this.btnNewDuoPalette.Location = new System.Drawing.Point(244, 138);
            this.btnNewDuoPalette.Name = "btnNewDuoPalette";
            this.btnNewDuoPalette.Size = new System.Drawing.Size(299, 34);
            this.btnNewDuoPalette.TabIndex = 0;
            this.btnNewDuoPalette.Text = "Create a new Duo Palette";
            this.btnNewDuoPalette.UseVisualStyleBackColor = true;
            this.btnNewDuoPalette.Click += new System.EventHandler(this.btnNewDuoPalette_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewDuoPalette);
            this.Name = "formMenu";
            this.Text = "formMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDuoPalette;
    }
}