using System.Diagnostics;
using System.Drawing;
using static Lab_5.Form1;

namespace Lab_5
{
    public class Square
    {
        protected int _x;
        private int _y;
        private int _a;

        private readonly Bitmap _bitmap = new Bitmap(picture.Width, picture.Height);
        private readonly Pen _white = new Pen(Color.White);

        public void Init()
        {
            _x = int.Parse(x_in.Text);
            _y = int.Parse(y_in.Text);
            _a = int.Parse(a_in.Text);
            Debug.WriteLine("Square.Init()");
        }

        public void Draw()
        {
            Graphics graphics = Graphics.FromImage(_bitmap);
            graphics.Clear(Color.Black);
            graphics.DrawRectangle(_white, _x, _y, _a, _a);
            picture.Image = _bitmap;

            A_point.Text = $@"A({_x},{_y})";
            B_point.Text = $@"B({_x + _a},{_y})";
            C_point.Text = $@"C({_x},{_y + _a})";
            D_point.Text = $@"D({_x + _a},{_y + _a})";
            Debug.WriteLine("Square.Draw()");
        }

        public void MoveLeft()
        {
            _x--;
            Draw();
        }

        public void MoveRight()
        {
            _x++;
            Draw();
        }
    }
}