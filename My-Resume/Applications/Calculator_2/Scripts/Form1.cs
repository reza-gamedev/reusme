using Calculator;

namespace Caculator
{
    public partial class Form1 : Form
    {
        ICalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Mycalculator();
        }
        public Double number1 = 0;
        public Double number2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "+")
            {
                textBox1.Text = Convert.ToString(calculator.sum(number1, number2));
            }
            if (textBox2.Text == "-")
            {
                textBox1.Text = Convert.ToString(calculator.minus(number1, number2));
            }
            if (textBox2.Text == "*")
            {
                textBox1.Text = Convert.ToString(calculator.multiple(number1, number2));
            }
            if (textBox2.Text == "/")
            {
                textBox1.Text = Convert.ToString(calculator.devide(number1, number2));
            }
            if (textBox2.Text == "%")
            {
                textBox1.Text = Convert.ToString(calculator.remaining(number1, number2));
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "-";
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "*";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "/";
        }

        private void btnRemaining_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "%";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
