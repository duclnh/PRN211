namespace BookStore_HoangNT
{
    partial class InformationForm
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
            lblFormTitle = new Label();
            gbBookInfo = new GroupBox();
            txtRePassword = new TextBox();
            label1 = new Label();
            txtNewPassword = new TextBox();
            txtPassword = new TextBox();
            txtName = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            gbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(146, 24);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(339, 46);
            lblFormTitle.TabIndex = 25;
            lblFormTitle.Text = "Update Information";
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtRePassword);
            gbBookInfo.Controls.Add(label1);
            gbBookInfo.Controls.Add(txtNewPassword);
            gbBookInfo.Controls.Add(txtPassword);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(39, 92);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(514, 321);
            gbBookInfo.TabIndex = 26;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "User Info ";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(126, 227);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = 'x';
            txtRePassword.Size = new Size(353, 27);
            txtRePassword.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 9;
            label1.Text = "Re password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(126, 180);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = 'x';
            txtNewPassword.Size = new Size(353, 27);
            txtNewPassword.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(353, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 180);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(106, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "New password";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(12, 130);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(70, 20);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(459, 440);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(348, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(607, 496);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "InformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformationForm";
            Load += InformationForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private TextBox txtName;
        private Label lblName;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtRePassword;
        private Label label1;
        private TextBox txtNewPassword;
        private TextBox txtPassword;
        private Label lblCategory;
        private Label lblAuthor;
    }
}