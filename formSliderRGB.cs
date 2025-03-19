using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Projekti3
{
    public partial class formSliderRGB : Form
    {
        String mainHex;
        String secondaryHex;

        public formSliderRGB()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int Red1;
        private int Green1;
        private int Blue1;

        private int Red2;
        private int Green2;
        private int Blue2;


        private void formSliderRGB_Load_1(object sender, EventArgs e)
        {

          //  ce_trackbarGreen2.Minimum = 0;
          //  ce_trackbarGreen2.Maximum = 100;
          //  ce_trackbarGreen2.Value = 50; // Initial value for trackbar
          //  txtbxRGB2ndGreen.Text = ce_trackbarGreen2.Value.ToString(); // Set initial value for textbox
        }


        private void ApplySettings()
    {

        //txtbxSecondaryHex.BackColor = Color.FromArgb(Red1, Green1, Blue1);
            panelMainColor.BackColor = Color.FromArgb(Red1, Green1, Blue1);
            txtbxMainHex.BackColor = Color.FromArgb(Red1, Green1, Blue1);
            lblSecondaryHex.ForeColor = Color.FromArgb(Red1, Green1, Blue1);
            txtbxSecondaryHex.ForeColor = Color.FromArgb(Red1, Green1, Blue1);
            

            ce_trackbarRed.SlideColor = Color.FromArgb(Red1, 0, 0);
            ce_trackbarGreen.SlideColor = Color.FromArgb(0, Green1, 0);
            ce_trackbarBlue.SlideColor = Color.FromArgb(0, 0, Blue1);
        }

        private void ApplySettings2()
        {

            txtbxSecondaryHex.BackColor = Color.FromArgb(Red2, Green2, Blue2);
            panelSecondaryColor.BackColor = Color.FromArgb(Red2, Green2, Blue2);
            lblMainHex.ForeColor = Color.FromArgb(Red2, Green2, Blue2);
            txtbxMainHex.ForeColor = Color.FromArgb(Red2, Green2, Blue2);
            txtbxSecondaryHex.Visible = true;

            ce_trackbarRed2.SlideColor = Color.FromArgb(Red2, 0, 0);
            ce_trackbarGreen2.SlideColor = Color.FromArgb(0, Green2, 0);
            ce_trackbarBlue2.SlideColor = Color.FromArgb(0, 0, Blue2);

            /*  int ConvertTo2ndGreen = Convert.ToInt32(txtbxRGB2ndGreen.Text);
              int newvari = ConvertTo2ndGreen * 2.55;
              ce_trackbarGreen2.Value = newvari; */

        }

        private void ce_trackbarRed_ValueChanged()
        {
            Red1 = Convert.ToInt32(ce_trackbarRed.Value);
            mainHex = string.Format("{0:X2}{1:X2}{2:X2}", Red1, Green1, Blue1);
            txtbxMainHex.Text = "#" + mainHex;

            int RedTxtbx = Convert.ToInt32(ce_trackbarRed.Value);
            txtbxRGBMainRed.Text = RedTxtbx.ToString();
            ApplySettings();
        }

        private void ce_trackbarGreen_ValueChanged()
        {
            Green1 = Convert.ToInt32(ce_trackbarGreen.Value);
            mainHex = string.Format("{0:X2}{1:X2}{2:X2}", Red1, Green1, Blue1);
            txtbxMainHex.Text = "#" + mainHex;

            int GreenTxtbx = Convert.ToInt32(ce_trackbarGreen.Value);
            txtbxRGBMainGreen.Text = GreenTxtbx.ToString();
            ApplySettings();
        }

        private void ce_trackbarBlue_ValueChanged()
        {
            Blue1 = Convert.ToInt32(ce_trackbarBlue.Value);
            mainHex = string.Format("{0:X2}{1:X2}{2:X2}", Red1, Green1, Blue1);
            txtbxMainHex.Text = "#" + mainHex;

            int BlueTxtbx = Convert.ToInt32(ce_trackbarBlue.Value);
            txtbxRGBMainBlue.Text = BlueTxtbx.ToString();
            ApplySettings();
        }


        private void ce_trackbarRed2_ValueChanged()
        {

            Red2 = Convert.ToInt32(ce_trackbarRed2.Value);
            secondaryHex = string.Format("{0:X2}{1:X2}{2:X2}", Red2, Green2, Blue2);
            txtbxSecondaryHex.Text = "#" + secondaryHex;

            int Red2Txtbx = Convert.ToInt32(ce_trackbarRed2.Value);
            txtbxRGB2ndRed.Text = Red2Txtbx.ToString();
            ApplySettings2();
        }

        private void ce_trackbarBlue2_ValueChanged()
        {
            Blue2 = Convert.ToInt32(ce_trackbarBlue2.Value);
            secondaryHex = string.Format("{0:X2}{1:X2}{2:X2}", Red2, Green2, Blue2);
            txtbxSecondaryHex.Text = "#" + secondaryHex;

            int Blue2Txtbx = Convert.ToInt32(ce_trackbarBlue2.Value);
            txtbxRGB2ndBlue.Text = Blue2Txtbx.ToString();
            ApplySettings2();
        }

        private void ce_trackbarGreen2_ValueChanged()
        {
            Green2 = Convert.ToInt32(ce_trackbarGreen2.Value);
            secondaryHex = string.Format("{0:X2}{1:X2}{2:X2}", Red2, Green2, Blue2);
            txtbxSecondaryHex.Text = "#" + secondaryHex;

            int Green2Txtbx = Convert.ToInt32(ce_trackbarGreen2.Value);
            txtbxRGB2ndGreen.Text = Green2Txtbx.ToString();
            ApplySettings2();
        }

        private void panelSecondaryColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblMainHex_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbxSecondaryHex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMainHex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxSecondaryHex_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(panelMainColor.Width);
                int height = Convert.ToInt32(panelMainColor.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    panelMainColor.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }

            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            //saveFileDialog1.Title = "Save an Image File";
            //saveFileDialog1.ShowDialog();

            // using (Bitmap mypalette = new Bitmap(this.Width, this.Height))
            //{
            //   this.DrawToBitmap(mypalette, new Rectangle(Point.Empty, mypalette.Size));
            // mypalette.Save(@"C:\Users\s3koan04\source\repos\ColorPaletteTool\Sample.png", ImageFormat.Png); // make sure path exists!

            //}
            // If the file name is not an empty string open it for saving.

            //if (saveFileDialog1.FileName != "")
            //{
            //    // Saves the Image via a FileStream created by the OpenFile method.

            //    System.IO.FileStream fs =
            //        (System.IO.FileStream)saveFileDialog1.OpenFile();

            //    // Saves the Image in the appropriate ImageFormat based upon the
            //    // File type selected in the dialog box.
            //    // NOTE that the FilterIndex property is one-based.

            //    switch (saveFileDialog1.FilterIndex)
            //    {
            //        case 1:
            //            this.button1.Image.Save(fs,
            //              System.Drawing.Imaging.ImageFormat.Jpeg);
            //            break;

            //        case 2:
            //            this.button1.Image.Save(fs,
            //              System.Drawing.Imaging.ImageFormat.Bmp);
            //            break;

            //        case 3:
            //            this.button1.Image.Save(fs,
            //              System.Drawing.Imaging.ImageFormat.Gif);
            //            break;
            //    }

            //    fs.Close();
            //}

            //string Location = @"C:\Users\s3koan04\source\repos\ColorPaletteTool";
            //string file = System.IO.Path.Combine(Location, "MyFile.docx");
            //if (!System.IO.File.Exists(file))
            //{
            //    System.IO.File.Create(file);
            //}
            /*  using (Bitmap bmp = new Bitmap(this.Width, this.Height))
              {
                  this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                  bmp.Save(@"C:\Users\s3koan04\source\repos\ColorPaletteTool\Sample.png", ImageFormat.Png); // make sure path exists!

              } */



            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            //ImageFormat format = ImageFormat.Png;
            //if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string ext = System.IO.Path.GetExtension(sfd.FileName);
            //    switch (ext)
            //    {
            //        case ".jpg":
            //            format = ImageFormat.Jpeg;
            //            break;
            //        case ".bmp":
            //            format = ImageFormat.Bmp;
            //            break;
            //    }
            //    this.Image.Save(sfd.FileName, format);
            //}
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void formSliderRGB_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void panelContainer_TabStopChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Segoe UI", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Segoe UI", lblSecondaryHex.Font.Size, FontStyle.Italic);
            txtbxMainHex.Font = new Font("Segoe UI", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Segoe UI", txtbxSecondaryHex.Font.Size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Creato Display", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Creato Display", lblSecondaryHex.Font.Size, FontStyle.Italic);
            txtbxMainHex.Font = new Font("Creato Display", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Creato Display", txtbxSecondaryHex.Font.Size);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMainHex.Font = new Font("Times Sans Serif", lblMainHex.Font.Size, FontStyle.Bold);
            lblSecondaryHex.Font = new Font("Times Sans Serif", lblSecondaryHex.Font.Size, FontStyle.Regular);
            txtbxMainHex.Font = new Font("Times Sans Serif", txtbxMainHex.Font.Size);
            txtbxSecondaryHex.Font = new Font("Times Sans Serif", txtbxSecondaryHex.Font.Size);
        }

        private void btnCopyMainRed_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGBMainRed.Text);
        }

        private void txtbxRGB2ndGreen_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGB2ndGreen.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarGreen2.Value = value;
        }

        private void ce_trackbarGreen2_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void txtbxRGB2ndGreen_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtbxRGBMainGreen_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGBMainGreen.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarGreen.Value = value;
        }

        private void txtbxRGBMainRed_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGBMainRed.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarRed.Value = value;
        }

        private void txtbxRGBMainBlue_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGBMainBlue.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarBlue.Value = value;
        }

        private void btnCopyMainGreen_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGBMainGreen.Text);
        }

        private void btnCopyMainBlue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGBMainBlue.Text);
        }

        private void btnThemeDark_Click(object sender, EventArgs e)
        {
        }

        private void formSliderRGB_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void txtbxRGB2ndRed_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGB2ndRed.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarRed2.Value = value;
        }

        private void txtbxRGB2ndBlue_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtbxRGB2ndBlue.Text, out int value);
            Convert.ToInt32(value);
            ce_trackbarBlue2.Value = value;
        }

        private void btnCopy2ndRed_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGB2ndRed.Text);
        }

        private void btnCopy2ndGreen_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGB2ndGreen.Text);
        }

        private void btnCopy2ndBlue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbxRGB2ndBlue.Text);
        }
    }
}

