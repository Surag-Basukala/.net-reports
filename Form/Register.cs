using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string province = comboBox1.SelectedItem.ToString();

            string[] bagmati = { "Kathmandu", "Bhaktapur", "Lalitpur", "Kavre" };
            string[] gandaki = { "Pokhara", "Gorkha", "Lamjung" };

            //if(comboBox1.Sele)

            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmati);
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandaki);
                    break;
                default:
                    comboBox2.Items.Add("No District Available");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string name = textBox1.Text;
            int age = Convert.ToInt32(numericUpDown1.Value);
            string province = comboBox1.SelectedItem.ToString();
            string district = comboBox2.SelectedItem.ToString();

            MessageBox.Show($"Name: {name}\nAge: {age}\nProvince: {province}\nDistrict: {district}");


        }
    }
}
