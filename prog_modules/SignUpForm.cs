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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void signUpLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text) || String.IsNullOrEmpty(fullNameTextBox.Text) || String.IsNullOrEmpty(phoneTextBox.Text) || String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = @"SELECT user_id FROM users WHERE login = '" + loginTextBox.Text + "'";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("An account with this username already exists", "Account Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loginTextBox.Text = "";
                }
                else
                {
                    if (SignUp.Registration(loginTextBox.Text, passwordTextBox.Text, fullNameTextBox.Text, phoneTextBox.Text, emailTextBox.Text))
                    {
                        MessageBox.Show("You have successfully created an account!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm login = new LoginForm();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Some error!", "???", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
