using System;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double num))
            {
                if (num > 0)
                    lblResult.Text = num + " is positive.";
                else if (num < 0)
                    lblResult.Text = num + " is negative.";
                else
                    lblResult.Text = "0 is neither positive nor negative.";
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }
    }
}
