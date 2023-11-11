namespace BookStore_HoangNT
{
    partial class BookCategoryManagerForm
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
            lblHello = new Label();
            lblFormTitle = new Label();
            lblBookList = new Label();
            dgvBookList = new DataGridView();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbBookInfo = new GroupBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblDesc = new Label();
            lblName = new Label();
            lblId = new Label();
            menuStrip1 = new MenuStrip();
            productToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            gbSearch.SuspendLayout();
            gbTask.SuspendLayout();
            gbBookInfo.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.AutoSize = true;
            lblHello.ForeColor = Color.Yellow;
            lblHello.Location = new Point(938, 39);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(132, 20);
            lblHello.TabIndex = 31;
            lblHello.Text = "Welcomev | admin";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(368, 39);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(409, 46);
            lblFormTitle.TabIndex = 26;
            lblFormTitle.Text = "Book Category Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(547, 217);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(95, 20);
            lblBookList.TabIndex = 30;
            lblBookList.Text = "Category List";
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = Color.White;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(547, 249);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(523, 300);
            dgvBookList.TabIndex = 25;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(547, 109);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(522, 89);
            gbSearch.TabIndex = 29;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(372, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(59, 41);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(132, 38);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(221, 27);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(8, 469);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(500, 80);
            gbTask.TabIndex = 28;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(388, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(264, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(141, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(17, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
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
            gbBookInfo.Location = new Point(8, 109);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(500, 283);
            gbBookInfo.TabIndex = 27;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "Category Info ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(353, 102);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 86);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(131, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
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
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1079, 28);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
            productToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(60, 24);
            productToolStripMenuItem.Text = "Menu";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "Book";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "Category";
            // 
            // BookCategoryManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1079, 594);
            Controls.Add(menuStrip1);
            Controls.Add(lblHello);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookCategoryManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookCategoryManagerForm";
            Load += BookCategoryManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTask.ResumeLayout(false);
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHello;
        private Label lblFormTitle;
        private Label lblBookList;
        private DataGridView dgvBookList;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbBookInfo;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblDesc;
        private Label lblName;
        private Label lblId;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
    }
}