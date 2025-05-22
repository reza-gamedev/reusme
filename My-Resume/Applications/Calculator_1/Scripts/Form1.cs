namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text));
        }    

        private void MinusButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text));
        }

        private void MultipleButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text));
        }

        private void DevideButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox3.Text));
        }
    }
}
