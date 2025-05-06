using System.DirectoryServices.ActiveDirectory;
using WinFormClassPractice;

namespace Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Calculator calculator = new Calculator();
            calculator.TopLevel = false;
            calculator.FormBorderStyle = FormBorderStyle.None;
            calculator.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(calculator);
            calculator.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Register registerForm = new Register();
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(registerForm);
            registerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Login loginForm = new Login();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(loginForm);
            loginForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
