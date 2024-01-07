using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekti3
{
    public partial class formSliderRGB : Form
    {
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


        private void ApplySettings2()
        {

            panelSecondaryColor.BackColor = Color.FromArgb(Red2, Green2, Blue2);
        }


        private void ApplySettings()
        {
            panelMainColor.BackColor = Color.FromArgb(Red1, Green1, Blue1);

        }



        private void ce_trackbarRed_ValueChanged()
        {
            Red1 = Convert.ToInt32(ce_trackbarRed.Value * 2.55);
            ApplySettings();
        }

        private void ce_trackbarGreen_ValueChanged()
        {
            Green1 = Convert.ToInt32(ce_trackbarGreen.Value * 2.55);
            ApplySettings();
        }

        private void ce_trackbarBlue_ValueChanged()
        {
            Blue1 = Convert.ToInt32(ce_trackbarBlue.Value * 2.55);
            ApplySettings();
        }


        private void ce_trackbarRed2_ValueChanged()
        {

            Red2 = Convert.ToInt32(ce_trackbarRed2.Value * 2.55);
            ApplySettings2();
        }

        private void ce_trackbarBlue2_ValueChanged()
        {
            Blue2 = Convert.ToInt32(ce_trackbarBlue2.Value * 2.55);
            ApplySettings2();
        }

        private void ce_trackbarGreen2_ValueChanged()
        {
            
            Green2 = Convert.ToInt32(ce_trackbarGreen2.Value * 2.55);
            ApplySettings2();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSecondaryColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
