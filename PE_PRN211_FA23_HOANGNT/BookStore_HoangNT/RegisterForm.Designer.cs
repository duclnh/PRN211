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
            gbLoginForm.Location = new Point(41, 59);
            gbLoginForm.Margin = new Padding(3, 2, 3, 2);
            gbLoginForm.Name = "gbLoginForm";
            gbLoginForm.Padding = new Padding(3, 2, 3, 2);
            gbLoginForm.Size = new Size(297, 350);
            gbLoginForm.TabIndex = 0;
            gbLoginForm.TabStop = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(53, 126);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 20;
            txtName.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(53, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtRepassword
            // 
            txtRepassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.Location = new Point(53, 218);
            txtRepassword.Margin = new Padding(3, 2, 3, 2);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.PasswordChar = '*';
            txtRepassword.Size = new Size(193, 23);
            txtRepassword.TabIndex = 18;
            txtRepassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 200);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 0;
            label1.Text = "Repassword";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignIn.Location = new Point(102, 17);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(91, 30);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign up";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(53, 168);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(193, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 192, 192);
            btnSignup.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Location = new Point(50, 259);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(192, 33);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(50, 148);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(53, 81);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(53, 64);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.Location = new Point(104, 7);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(158, 37);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Book Store";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(379, 425);
            Controls.Add(gbLoginForm);
            Controls.Add(lblAppName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
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