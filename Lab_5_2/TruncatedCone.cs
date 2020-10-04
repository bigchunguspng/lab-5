using System;

using static Lab_5_2.Form1;

namespace Lab_5_2
{
    public class TruncatedCone : Cone
    {
        private double _radius2;

        public new void Build()
        {
            string h = height_in.Text;
            string r1 = radius1_in.Text;
            string r2 = radius2_in.Text;
            string s = slant_in.Text;

            double.TryParse(s, out Slant);
            double.TryParse(r2, out _radius2);
            if (!double.TryParse(r1, out Radius)) Radius = Math.Sqrt(Slant * Slant - Height * Height) + _radius2;
            if (!double.TryParse(h, out Height)) Height = Math.Sqrt(Slant * Slant - Math.Pow(Radius - _radius2, 2));
            ShowResult();
        }

        public double Volume() =>
            Math.PI * Height * (Radius * Radius + Radius * _radius2 + _radius2 * _radius2) / 3d;

        private void ShowResult()
        {
            volume_label.Text = $@"Volume: {Volume()}";
            area_label.Text = $@"Base area: {BaseSurfaceArea()}";
        }
    }
}