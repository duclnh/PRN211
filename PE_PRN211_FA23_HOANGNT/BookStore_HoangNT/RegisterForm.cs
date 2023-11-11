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



namespace BookStore_HoangNT
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text; //TODO:kiểm tra rỗng!!!
            string name = txtName.Text; //TODO:kiểm tra rỗng!!!
            string password = txtPassword.Text; //TODO: kiểm tra rỗng
            string confirmPassword = txtRepassword.Text; //TODO: kiểm tra rỗng
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

            // Check for duplicate email
            if (IsEmailDuplicate(email))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert data into the database
            if (InsertDataIntoDatabase(email, name, password))
            {
                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can add code here to navigate to another form or perform additional actions upon successful registration
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function to check for duplicate email
        private bool IsEmailDuplicate(string email)
        {
            using ( SqlConnection connection = new SqlConnection())
            {
                connection.Open();

                // You need to replace "YourTableName" with the actual table name where you store user data
                string query = $"SELECT COUNT(*) FROM YourTableName WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Function to insert data into the database
        private bool InsertDataIntoDatabase(string email, string name, string password)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();

                // You need to replace "YourTableName" with the actual table name where you want to store user data
                string query = "INSERT INTO YourTableName (Email, Name, Password) VALUES (@Email, @Name, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
