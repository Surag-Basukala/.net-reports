using System.Text.RegularExpressions;

namespace WinFormsApp1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = maskedTextBox1.Text;
            string passWord = maskedTextBox2.Text;
            string uNamePattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            //MessageBox.Show(uName);
            //MessageBox.Show(passWord);

            if (Regex.IsMatch(uName, uNamePattern))
            {
                if (uName == "abc@gmail.com" && passWord == "abc")
                {
                    MessageBox.Show("Login Success");
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Username and Password");
                }
            }
            else
            {
                MessageBox.Show("The entered email is invalid");
            }
        }
    }
}
