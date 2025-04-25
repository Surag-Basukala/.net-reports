namespace WinFormClassPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            int result = number1 + number2;
            label5.Text = result.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            int result = number1 - number2;
            label5.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            int result = number1 * number2;
            label5.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);

                //if (number2 == 0)
                //{
                //    MessageBox.Show("Cannot Be Divided By Zero");
                //}
                int result = number1 / number2;
                label5.Text = result.ToString();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Unexpected error by dividing 0");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block other characters
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block other characters
            }
        }
    }
}
