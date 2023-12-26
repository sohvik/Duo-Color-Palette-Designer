using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti3
{
    public class MutedColors
    {
        public static Color CreateMutedColor(Color originalColor, double saturationFactor)
        {
            // Ensure saturation factor is within bounds (0 to 1)
            saturationFactor = Math.Min(1, Math.Max(0, saturationFactor));

            // Convert RGB to HSL (Hue, Saturation, Lightness)
            double h, s, l;
            ColorToHSL(originalColor, out h, out s, out l);

            // Reduce saturation by a factor
            s *= saturationFactor;

            // Convert back to RGB
            return HSLToColor(h, s, l);
        }

        private static void ColorToHSL(Color color, out double hue, out double saturation, out double lightness)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            // Calculating the hue
            hue = 0;
            if (max == r && g >= b)
                hue = 60 * (g - b) / (max - min);
            else if (max == r && g < b)
                hue = 60 * (g - b) / (max - min) + 360;
            else if (max == g)
                hue = 60 * (b - r) / (max - min) + 120;
            else if (max == b)
                hue = 60 * (r - g) / (max - min) + 240;

            // Calculating lightness
            lightness = (max + min) / 2;

            // Calculating saturation
            if (max == min)
                saturation = 0;
            else if (lightness <= 0.5)
                saturation = (max - min) / (max + min);
            else
                saturation = (max - min) / (2 - max - min);
        }

        private static Color HSLToColor(double hue, double saturation, double lightness)
        {
            double c = (1 - Math.Abs(2 * lightness - 1)) * saturation;
            double x = c * (1 - Math.Abs((hue / 60) % 2 - 1));
            double m = lightness - c / 2;

            double r, g, b;
            if (0 <= hue && hue < 60)
            {
                r = c;
                g = x;
                b = 0;
            }
            else if (60 <= hue && hue < 120)
            {
                r = x;
                g = c;
                b = 0;
            }
            else if (120 <= hue && hue < 180)
            {
                r = 0;
                g = c;
                b = x;
            }
            else if (180 <= hue && hue < 240)
            {
                r = 0;
                g = x;
                b = c;
            }
            else if (240 <= hue && hue < 300)
            {
                r = x;
                g = 0;
                b = c;
            }
            else
            {
                r = c;
                g = 0;
                b = x;
            }

            byte red = (byte)((r + m) * 255);
            byte green = (byte)((g + m) * 255);
            byte blue = (byte)((b + m) * 255);

            return Color.FromArgb(red, green, blue);
        }
    }
}

