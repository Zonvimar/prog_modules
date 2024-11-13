using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    public partial class LoginForm : Form
    {
        static public string loginActive;
        static public string whois;

        public LoginForm()
        {
            InitializeComponent();
            DBconnection.ConnectionDB();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signup = new SignUpForm();
            signup.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginTextBox.Text) || !String.IsNullOrEmpty(passwordTextBox.Text))
            {
                Login.Authorization(loginTextBox.Text, passwordTextBox.Text);
                if(Login.role != null)
                {
                    loginActive = loginTextBox.Text;
                    string full_name = Login.AuthorizationName(loginTextBox.Text);
                    Login.full_name = full_name;
                    MessageBox.Show(Login.role + " " + full_name + ", welcome!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Account doesn`t exist!", "Check data and try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
