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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRGB_Click(object sender, EventArgs e)
        {

        }

        private void roundPictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(roundPictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = c;
                int result = (c.R + c.B + c.G) / 3;
                Color newC = Color.FromArgb(c.A, result, result, result);
                pictureBox2.BackColor = newC;

            } catch (Exception ex)
            {
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            /*
            Bitmap bitmap = new Bitmap(roundPictureBox1.Image);

            Bitmap bmp = new Bitmap(roundPictureBox1.Image);
            int width = bmp.Width;
            int height = bmp.Height;


            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    // Get the color of the current pixel

                    Color p = bmp.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    int result = (p.R + p.B + p.G) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(p.A, result, result, result));

                    // Do something with the pixel color (for example, print RGB values)
                    /* Console.WriteLine($"Pixel at ({x}, {y}): R={pixelColor.R}, G={pixelColor.G}, B={pixelColor.B}");
                }

            }


           */


            // Koodi Picturebox kursori hommasta:
            /* Bitmap bmp = new Bitmap(roundPictureBox1.Image);
             Color c = bmp.GetPixel(e.X, e.Y);
             pictureBox2.BackColor = c;
             int result = (c.R + c.B + c.G) / 3;
             Color newC = Color.FromArgb(c.A, result, result, result);
             pictureBox2.BackColor = newC;
            */
            /*
                        bmp.Width {
                            bmp.Height
                                bmp.SetPixel } */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int trackBarValue = trackBar1.Value;
            label8.Text = $"Current Value: {trackBarValue}";

            Bitmap bmp = new Bitmap(roundPictureBox1.Image);
            int width = bmp.Width;
            int height = bmp.Height;


            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Get the color of the current pixel

                    Color p = bmp.GetPixel(x, y);
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    int result = (p.R + p.B + p.G) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(p.A, result, result, result));

                    // Do something with the pixel color (for example, print RGB values)
                    /* Console.WriteLine($"Pixel at ({x}, {y}): R={pixelColor.R}, G={pixelColor.G}, B={pixelColor.B}");*/
                }

            }

            roundPictureBox1.Image = bmp;
        }
    }
}
