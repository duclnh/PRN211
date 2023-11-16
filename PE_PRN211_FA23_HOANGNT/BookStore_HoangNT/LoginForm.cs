using Microsoft.Extensions.Configuration;
using Repositories.Entities;
using Services;
using System.Configuration;

namespace BookStore_HoangNT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text; //TODO:kiểm tra rỗng!!!
            string password = txtPassword.Text; //TODO: kiểm tra rỗng
            BookManagementMemberService se = new BookManagementMemberService();

            BookManagementMember account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

                BookManagerForm bookMgt = new BookManagerForm();
                bookMgt.Account = account;
                bookMgt.Show(); //show form CRUD
                this.Hide();  //ẩn form login đi
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show(); //show form CRUD
            this.Hide();  //ẩn form login đi
        }
    }
}