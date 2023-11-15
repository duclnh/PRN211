namespace BookStore_HoangNT
{
    partial class CategoryForm
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
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
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
            lblFormTitle.Location = new Point(65, 31);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(267, 46);
            lblFormTitle.TabIndex = 25;
            lblFormTitle.Text = "Add a Category";
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(65, 114);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(514, 267);
            gbBookInfo.TabIndex = 26;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "Category Info ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(353, 102);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(131, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(17, 131);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(85, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(17, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(485, 417);
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
            btnSave.Location = new Point(374, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(634, 483);
            Controls.Add(lblFormTitle);
            Controls.Add(gbBookInfo);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private GroupBox gbBookInfo;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private Button btnCancel;
        private Button btnSave;
    }
}