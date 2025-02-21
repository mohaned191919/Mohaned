using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration1
{
    public partial class StudentFrame: Form
    {
        private TextBox textPassward;
        private Button submitButton;
        public StudentFrame()
        {
            InitializeComponent();
           
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string password = textPassward.Text;
            MessageBox.Show("Your password is: " + password);
        }

        [STAThread]
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           private void button1_Enter(object sender, EventArgs e)
        {
            var email = textEmail.Text;

            // Validate the email format
            bool isValidEmail = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!isValidEmail)
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address." + "Examble : amerdsjjd@examble.com");
                return; // Exit the method if the email is invalid
            }
            var name = textName.Text;
           
            var passward = textPassward.Text;
            var gender = rdBtnM.Checked ? "Male" : rdBtnW.Checked ? "Female" : "Other";
            var country = cmboBoxBirthPlace.SelectedItem.ToString() ?? "Not selected";

            MessageBox.Show($"{name} \n- {email} \n- {passward} \n- {gender} \n- {country} ");
        }

        private void textPassward_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
