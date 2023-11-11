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
            txtName = new TextBox();
            lblName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
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
            gbBookInfo.Controls.Add(textBox2);
            gbBookInfo.Controls.Add(label1);
            gbBookInfo.Controls.Add(textBox1);
            gbBookInfo.Controls.Add(txtAuthor);
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
            // txtName
            // 
            txtName.Location = new Point(126, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
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
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(126, 127);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(353, 27);
            txtAuthor.TabIndex = 6;
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
            // textBox1
            // 
            textBox1.Location = new Point(126, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 27);
            textBox2.TabIndex = 10;
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
            Text = "InformationForm";
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
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox txtAuthor;
        private Label lblCategory;
        private Label lblAuthor;
    }
}