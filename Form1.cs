using System.Security.Cryptography;

namespace Calculator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text);

            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
            {
                result = num1 / num2;
            }
            txtDisplay.Clear();
            txtDisplay.Text += result;

        }

        private void button13_Click(object sender, EventArgs e) // Multiply //
        {
            option = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtDisplay.Text);

            

            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();

        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // button Clear
        {
            result = (0);
            num1=(0);
            num2=(0);
            txtDisplay.Clear();
        }
    }
}
