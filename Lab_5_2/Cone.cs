using System;

using static Lab_5_2.Form1;

namespace Lab_5_2
{
    public class Cone
    {
        protected double Height;
        protected double Radius;
        protected double Slant;
        
        public void Build()
        {
            string h = height_in.Text;
            string r = radius1_in.Text;
            string s = slant_in.Text;

            double.TryParse(s, out Slant);
            if (!double.TryParse(r, out Radius)) Radius = Math.Sqrt(Slant * Slant - Height * Height);
            if (!double.TryParse(h, out Height)) Height = Math.Sqrt(Slant * Slant - Radius * Radius);
            ShowResult();
        }

        private double Volume() => Math.PI * Radius * Radius * Height / 3d;

        public double BaseSurfaceArea() => Math.PI * Radius * Radius;

        private void ShowResult()
        {
            volume_label.Text = $@"Volume: {Volume()}";
            area_label.Text = $@"Base area: {BaseSurfaceArea()}";
        }
    }
}