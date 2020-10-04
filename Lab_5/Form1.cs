using System;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        private readonly Square _square;

        public Form1()
        {
            InitializeComponent();
            _square = new TiltingSquare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _square.Init();
            _square.Draw();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.ToLower((char) Keys.W)) _square.MoveLeft();
            if (e.KeyChar == char.ToLower((char) Keys.E)) _square.MoveRight();
            if (e.KeyChar == char.ToLower((char) Keys.Q)) (_square as TiltingSquare)?.MoveLeft();
            if (e.KeyChar == char.ToLower((char) Keys.R)) (_square as TiltingSquare)?.MoveRight();
        }
    }
}