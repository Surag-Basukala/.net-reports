using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winforms.Models;

namespace Winforms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            getAllUser();
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
            string gender = comboBox3.SelectedItem.ToString();
            int count = checkedListBox1.CheckedItems.Count;
            StringBuilder skills = new StringBuilder();
            //while (count > 0) {
            // skills.Append(checkedListBox1.SelectedIndices)
            //}
            //.ToString();
            for (int i = 0; i < count; i++)
            {
                skills.Append(checkedListBox1.CheckedItems[i].ToString());
                if (i < count - 1)
                    skills.Append(", ");
            }

            MessageBox.Show($"Skills: {skills.ToString()}");
            //MessageBox.Show($"Name: {name}\nAge: {age}\nProvince: {province}\nDistrict: {district}");
            RegisterForm register = new RegisterForm()
            {
                Name = name,
                Age = age,
                Gender = gender,
                District = district,
                Province = province,
                Skill = skills.ToString()
            };
            DatabaseService databaseService = new DatabaseService();
            string message = databaseService.load_register(register);

            MessageBox.Show(message);




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        public void getAllUser()
        {
            DatabaseService databaseService = new DatabaseService();
            var result = databaseService.getAllUser();
            dataGridView1.DataSource = registerFormBindingSource;
            if (result != null)
            {
                registerFormBindingSource.DataSource = result;
            }
            else
            {
                MessageBox.Show("Error :");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nameToDelete = textBox2.Text;
            DatabaseService databaseService = new DatabaseService();
            bool isDelete = databaseService.deleteUser(textBox2.Text);
            if (isDelete)
            {
                MessageBox.Show("User Deleted Sucessfully");
            }
            else
            {
                MessageBox.Show("Failed to Delete User");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = Convert.ToInt32(numericUpDown1.Value);
            string province = comboBox1.SelectedItem.ToString();
            string district = comboBox2.SelectedItem.ToString();
            string gender = comboBox3.SelectedItem.ToString();

            RegisterForm update = new RegisterForm()
            {
                Name = name,
                Age = age,
                Province = province,  
                District = district,
                Gender = gender
            };
            DatabaseService databaseService = new DatabaseService();
            bool isUpdated = databaseService.updateUser(update);
            if (isUpdated)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Failed to Update");
            }

        }
    }
}
