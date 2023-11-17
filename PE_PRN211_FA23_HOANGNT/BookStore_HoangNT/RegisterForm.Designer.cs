namespace BookStore_HoangNT
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbLoginForm = new GroupBox();
            txtName = new TextBox();
            lblName = new Label();
            txtRepassword = new TextBox();
            label1 = new Label();
            lblSignIn = new Label();
            txtPassword = new TextBox();
            btnSignup = new Button();
            lblPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblAppName = new Label();
            gbLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // gbLoginForm
            // 
            gbLoginForm.BackColor = Color.LimeGreen;
            gbLoginForm.Controls.Add(txtName);
            gbLoginForm.Controls.Add(lblName);
            gbLoginForm.Controls.Add(txtRepassword);
            gbLoginForm.Controls.Add(label1);
            gbLoginForm.Controls.Add(lblSignIn);
            gbLoginForm.Controls.Add(txtPassword);
            gbLoginForm.Controls.Add(btnSignup);
            gbLoginForm.Controls.Add(lblPassword);
            gbLoginForm.Controls.Add(txtEmail);
            gbLoginForm.Controls.Add(lblEmail);
            gbLoginForm.FlatStyle = FlatStyle.Flat;
            gbLoginForm.Location = new Point(47, 79);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Size = new Size(339, 467);
            gbLoginForm.TabIndex = 0;
            gbLoginForm.TabStop = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(61, 168);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(61, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtRepassword
            // 
            txtRepassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.Location = new Point(61, 291);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.PasswordChar = 'x';
            txtRepassword.Size = new Size(220, 27);
            txtRepassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(61, 267);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Repassword";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(117, 23);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(117, 38);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign up";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(61, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 192, 192);
            btnSignup.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Location = new Point(57, 345);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(219, 44);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(57, 197);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(61, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(61, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(119, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(196, 46);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Book Store";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(433, 567);
            Controls.Add(gbLoginForm);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            gbLoginForm.ResumeLayout(false);
            gbLoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbLoginForm;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtRepassword;
        private Label label1;
        private Label lblSignIn;
        private TextBox txtPassword;
        private Button btnSignup;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblAppName;
    }
}