namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        char opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!txtCalc.Text.Contains("."))
            {
                txtCalc.Text += ".";
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            opt = '+';
            txtCalc.Clear();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            opt = '-';
            txtCalc.Clear();
        }

        private void buttonMulit_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            opt = '*';
            txtCalc.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            opt = '/';
               txtCalc.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtCalc.Text);

            switch (opt) 
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;

            }
            txtCalc.Text = Convert.ToString(result);
        }

        private void txtCalc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}