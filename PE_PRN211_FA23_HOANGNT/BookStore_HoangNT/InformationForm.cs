using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;
using Repositories.Entities;
using Services;

namespace BookStore_HoangNT
{
    public partial class InformationForm : Form
    {
        public string email { get; set; }
        private readonly BookManagementMemberService _memberRepository;
        private BookManagementMember? account;
        public InformationForm( )
        {
            InitializeComponent();
            _memberRepository = new BookManagementMemberService();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            account = _memberRepository.GetMemberByEmail(email);
            if (account != null)
            {
                txtName.Text = account.FullName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtRePassword.Text))
            {
                MessageBox.Show("Please enter re password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtPassword.Text != account.Password)
            {
                MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("RePassword is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ask = MessageBox.Show("Are you sure want to update account", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                BookManagementMember updateAccount = new BookManagementMember()
                {
                    MemberId = account.MemberId,
                    Password = txtNewPassword.Text,
                    Email = account.Email,
                    FullName = txtName.Text.Trim(),
                    MemberRole = account.MemberRole,
                };
                bool checkUpdate = _memberRepository.UpdateAccount(updateAccount);
                if (checkUpdate)
                {
                    MessageBox.Show("Update account is successfullly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtRePassword.Text = "";
                }
                else
                {
                    MessageBox.Show("RePassword is incorrect", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
