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

                    Email = email,
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
    }
}
