using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Repositories;
using Services;
using System.Text.RegularExpressions;

namespace BookStore_HoangNT
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text; //TODO:kiểm tra rỗng!!!
            string name = txtName.Text; //TODO:kiểm tra rỗng!!!
            string password = txtPassword.Text; //TODO: kiểm tra rỗng
            string confirmPassword = txtRepassword.Text; //TODO: kiểm tra rỗng


            BookManagementMemberService se = new BookManagementMemberService();
            // convert bool to BookManagementMember

            // Check for empty fields
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if password matches confirmed password
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(txtEmail.Text.Trim())){
                MessageBox.Show("Email invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BookManagementMember? existing = se.GetMemberByEmail(email);
            // check email duplicate in database
            if (existing != null)
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BookManagementMember newMember = new BookManagementMember
                {

                    Email = email.Trim(),
                    // Set other properties as needed
                    Password = password,
                    FullName = name,


                };

                se.InsertIntoDatabase(newMember);

                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to another form or perform additional actions upon successful registration
                LoginForm login = new LoginForm();
                login.Show(); // show form CRUD
                this.Hide();  // hide the registration form
            }
        }
        static bool IsValidEmail(string email)
        {
            // Define a regular expression pattern for a valid email address
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the regex object to match the email against the pattern
            return regex.IsMatch(email);
        }
    }
}
