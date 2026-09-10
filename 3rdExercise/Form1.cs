namespace DSTALGOExercise_Eustaquio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (num % 2 == 0)
            {
                lblResult.Text = "Your number is even!";
            }
            else
            {
                lblResult.Text = "Your number is odd!";
            }

        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
