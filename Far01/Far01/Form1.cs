namespace Far01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBoxC.Text;
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
            textBoxF.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;
            textBoxC.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxC.ResetText();
            textBoxF.ResetText();

        }
    }
}