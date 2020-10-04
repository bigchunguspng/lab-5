using System;
using System.Windows.Forms;

namespace Lab_5_2
{
    public partial class Form1 : Form
    {
        private readonly Cone _cone;

        public Form1()
        {
            InitializeComponent();
            _cone = new TruncatedCone();
        }

        private void parameters_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(radius2_in.Text))
                _cone.Build();
            else
                (_cone as TruncatedCone)?.Build();
        }
    }
}