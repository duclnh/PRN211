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
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
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
            stbBook = new ToolStripMenuItem();
            stbCategory = new ToolStripMenuItem();
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
            lblFormTitle.Location = new Point(368, 39);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(409, 46);
            lblFormTitle.TabIndex = 26;
            lblFormTitle.Text = "Book Category Manager";
            // 
            // lblCateList
            // 
            lblCateList.AutoSize = true;
            lblCateList.ForeColor = Color.Yellow;
            lblCateList.Location = new Point(541, 109);
            lblCateList.Name = "lblCateList";
            lblCateList.Size = new Size(95, 20);
            lblCateList.TabIndex = 30;
            lblCateList.Text = "Category List";
            // 
            // dgvCateList
            // 
            dgvCateList.BackgroundColor = Color.White;
            dgvCateList.BorderStyle = BorderStyle.Fixed3D;
            dgvCateList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCateList.Location = new Point(541, 152);
            dgvCateList.Name = "dgvCateList";
            dgvCateList.RowHeadersWidth = 51;
            dgvCateList.RowTemplate.Height = 29;
            dgvCateList.Size = new Size(523, 408);
            dgvCateList.TabIndex = 25;
            dgvCateList.SelectionChanged += dgvCateList_SelectionChanged;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(14, 460);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(495, 89);
            gbSearch.TabIndex = 29;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(11, 41);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(126, 37);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(353, 27);
            txtKeyword.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(391, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnSearch);
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(8, 371);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(501, 80);
            gbTask.TabIndex = 28;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(261, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(144, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            gbBookInfo.Location = new Point(8, 109);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(501, 256);
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
            txtDescription.Size = new Size(353, 103);
            txtDescription.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 85);
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
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmList, tsmUser });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1101, 30);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmList
            // 
            tsmList.DropDownItems.AddRange(new ToolStripItem[] { stbBook, stbCategory });
            tsmList.ForeColor = SystemColors.ButtonHighlight;
            tsmList.Name = "tsmList";
            tsmList.Size = new Size(60, 24);
            tsmList.Text = "Menu";
            tsmList.DropDownClosed += ChangeColorMenu;
            tsmList.Click += tsmList_Click;
            // 
            // stbBook
            // 
            stbBook.Name = "stbBook";
            stbBook.Size = new Size(152, 26);
            stbBook.Text = "Book";
            stbBook.Click += stbBook_Click;
            // 
            // stbCategory
            // 
            stbCategory.Name = "stbCategory";
            stbCategory.Size = new Size(152, 26);
            stbCategory.Text = "Category";
            // 
            // tsmUser
            // 
            tsmUser.Alignment = ToolStripItemAlignment.Right;
            tsmUser.DropDownItems.AddRange(new ToolStripItem[] { updateInformationToolStripMenuItem, logoutToolStripMenuItem });
            tsmUser.ForeColor = SystemColors.ButtonHighlight;
            tsmUser.Name = "tsmUser";
            tsmUser.RightToLeft = RightToLeft.No;
            tsmUser.Size = new Size(122, 24);
            tsmUser.Text = "Le duc | Admin";
            tsmUser.TextAlign = ContentAlignment.TopCenter;
            tsmUser.DropDownClosed += changeColorMenuUser;
            tsmUser.Click += tsmUser_Click;
            // 
            // updateInformationToolStripMenuItem
            // 
            updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            updateInformationToolStripMenuItem.RightToLeft = RightToLeft.No;
            updateInformationToolStripMenuItem.Size = new Size(224, 26);
            updateInformationToolStripMenuItem.Text = "Update Information";
            updateInformationToolStripMenuItem.Click += updateInformationToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // BookCategoryManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1101, 595);
            Controls.Add(menuStrip1);
            Controls.Add(lblFormTitle);
            Controls.Add(lblCateList);
            Controls.Add(dgvCateList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private ToolStripMenuItem stbBook;
        private ToolStripMenuItem stbCategory;
        private ToolStripMenuItem tsmUser;
        private ToolStripMenuItem updateInformationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}