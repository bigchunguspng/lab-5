using static Lab_5.Form1;

namespace Lab_5
{
    public class TiltingSquare : Square
    {
        public new void MoveLeft()
        {
            string temp  = A_point.Text;
            A_point.Text = B_point.Text;
            B_point.Text = D_point.Text;
            D_point.Text = C_point.Text;
            C_point.Text = temp;
        }

        public new void MoveRight()
        {
            string temp  = A_point.Text;
            A_point.Text = C_point.Text;
            C_point.Text = D_point.Text;
            D_point.Text = B_point.Text;
            B_point.Text = temp;
        }
    }
}