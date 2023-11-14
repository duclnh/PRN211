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
            lblFormTitle = new Label();
            lblCateList = new Label();
            dgvCateList = new DataGridView();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
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
            tsmList = new ToolStripMenuItem();
            stbBook = new ToolStripTextBox();
            stbCategory = new ToolStripTextBox();
            tsmUser = new ToolStripMenuItem();
            updateInformationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCateList).BeginInit();
            gbSearch.SuspendLayout();
            gbTask.SuspendLayout();
            gbBookInfo.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(322, 29);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(331, 37);
            lblFormTitle.TabIndex = 26;
            lblFormTitle.Text = "Book Category Manager";
            // 
            // lblCateList
            // 
            lblCateList.AutoSize = true;
            lblCateList.ForeColor = Color.Yellow;
            lblCateList.Location = new Point(473, 82);
            lblCateList.Name = "lblCateList";
            lblCateList.Size = new Size(76, 15);
            lblCateList.TabIndex = 30;
            lblCateList.Text = "Category List";
            // 
            // dgvCateList
            // 
            dgvCateList.BackgroundColor = Color.White;
            dgvCateList.BorderStyle = BorderStyle.Fixed3D;
            dgvCateList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCateList.Location = new Point(473, 114);
            dgvCateList.Margin = new Padding(3, 2, 3, 2);
            dgvCateList.Name = "dgvCateList";
            dgvCateList.RowHeadersWidth = 51;
            dgvCateList.RowTemplate.Height = 29;
            dgvCateList.Size = new Size(458, 306);
            dgvCateList.TabIndex = 25;
            dgvCateList.SelectionChanged += dgvCateList_SelectionChanged;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(12, 345);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(433, 67);
            gbSearch.TabIndex = 29;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(342, 26);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(10, 31);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(53, 15);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(110, 28);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(309, 23);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnSearch);
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(7, 278);
            gbTask.Margin = new Padding(3, 2, 3, 2);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(3, 2, 3, 2);
            gbTask.Size = new Size(438, 60);
            gbTask.TabIndex = 28;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(228, 26);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(126, 26);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(15, 26);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            gbBookInfo.Location = new Point(7, 82);
            gbBookInfo.Margin = new Padding(3, 2, 3, 2);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(3, 2, 3, 2);
            gbBookInfo.Size = new Size(438, 192);
            gbBookInfo.TabIndex = 27;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "Category Info ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(115, 96);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(309, 78);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(309, 23);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(115, 32);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(110, 23);
            txtId.TabIndex = 0;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(15, 98);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(15, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmList, tsmUser });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(963, 24);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmList
            // 
            tsmList.DropDownItems.AddRange(new ToolStripItem[] { stbBook, stbCategory });
            tsmList.ForeColor = SystemColors.ButtonHighlight;
            tsmList.Name = "tsmList";
            tsmList.Size = new Size(50, 20);
            tsmList.Text = "Menu";
            tsmList.DropDownClosed += ChangeColorMenu;
            tsmList.Click += tsmList_Click;
            // 
            // stbBook
            // 
            stbBook.Name = "stbBook";
            stbBook.ReadOnly = true;
            stbBook.Size = new Size(100, 23);
            stbBook.Text = "Book";
            stbBook.Click += stbBook_Click;
            // 
            // stbCategory
            // 
            stbCategory.Name = "stbCategory";
            stbCategory.ReadOnly = true;
            stbCategory.Size = new Size(100, 23);
            stbCategory.Text = "Category";
            // 
            // tsmUser
            // 
            tsmUser.Alignment = ToolStripItemAlignment.Right;
            tsmUser.DropDownItems.AddRange(new ToolStripItem[] { updateInformationToolStripMenuItem, logoutToolStripMenuItem });
            tsmUser.ForeColor = SystemColors.ButtonHighlight;
            tsmUser.Name = "tsmUser";
            tsmUser.RightToLeft = RightToLeft.No;
            tsmUser.Size = new Size(99, 20);
            tsmUser.Text = "Le duc | Admin";
            tsmUser.TextAlign = ContentAlignment.TopCenter;
            tsmUser.DropDownClosed += changeColorMenuUser;
            tsmUser.Click += tsmUser_Click;
            // 
            // updateInformationToolStripMenuItem
            // 
            updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            updateInformationToolStripMenuItem.RightToLeft = RightToLeft.No;
            updateInformationToolStripMenuItem.Size = new Size(178, 22);
            updateInformationToolStripMenuItem.Text = "Update Information";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(178, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // BookCategoryManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(963, 446);
            Controls.Add(menuStrip1);
            Controls.Add(lblFormTitle);
            Controls.Add(lblCateList);
            Controls.Add(dgvCateList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookCategoryManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Category Manager";
            FormClosed += BookCategoryManagerForm_FormClosed;
            Load += BookCategoryManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCateList).EndInit();
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
        private Label lblFormTitle;
        private Label lblCateList;
        private DataGridView dgvCateList;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
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
        private ToolStripMenuItem tsmList;
        private ToolStripTextBox stbBook;
        private ToolStripTextBox stbCategory;
        private ToolStripMenuItem tsmUser;
        private ToolStripMenuItem updateInformationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}