﻿using System;
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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void ce_CircularButton1_Click(object sender, EventArgs e)
        {
            var newDuo = new formSliderRGB();
            newDuo.Show();
        }


        private void btnNewDuoPalette_Click(object sender, EventArgs e)
        {
            var newDuo = new formSliderRGB();
            newDuo.Show();
        }
    }
}
