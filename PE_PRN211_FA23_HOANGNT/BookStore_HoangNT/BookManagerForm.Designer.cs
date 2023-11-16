namespace BookStore_HoangNT
{
    partial class BookManagerForm
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
            lblId = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblReleasedDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            dtpReleasedDate = new DateTimePicker();
            cboCategory = new ComboBox();
            gbBookInfo = new GroupBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            lblFormTitle = new Label();
            menuStrip1 = new MenuStrip();
            tsmList = new ToolStripMenuItem();
            stbBook = new ToolStripTextBox();
            stbCategory = new ToolStripTextBox();
            tsmUser = new ToolStripMenuItem();
            updateInformationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            gbBookInfo.SuspendLayout();
            gbTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
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
            // lblReleasedDate
            // 
            lblReleasedDate.AutoSize = true;
            lblReleasedDate.Location = new Point(15, 192);
            lblReleasedDate.Name = "lblReleasedDate";
            lblReleasedDate.Size = new Size(80, 15);
            lblReleasedDate.TabIndex = 3;
            lblReleasedDate.Text = "Released Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 226);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(254, 226);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 260);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 297);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
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
            // txtName
            // 
            txtName.Location = new Point(115, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(309, 23);
            txtName.TabIndex = 1;
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
            // txtAuthor
            // 
            txtAuthor.Location = new Point(115, 257);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(309, 23);
            txtAuthor.TabIndex = 6;
            // 
            // dtpReleasedDate
            // 
            dtpReleasedDate.CustomFormat = "dd/MM/yyyy";
            dtpReleasedDate.Format = DateTimePickerFormat.Custom;
            dtpReleasedDate.Location = new Point(115, 188);
            dtpReleasedDate.Margin = new Padding(3, 2, 3, 2);
            dtpReleasedDate.Name = "dtpReleasedDate";
            dtpReleasedDate.Size = new Size(134, 23);
            dtpReleasedDate.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(115, 295);
            cboCategory.Margin = new Padding(3, 2, 3, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(309, 23);
            cboCategory.TabIndex = 7;
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(txtPrice);
            gbBookInfo.Controls.Add(txtQuantity);
            gbBookInfo.Controls.Add(cboCategory);
            gbBookInfo.Controls.Add(dtpReleasedDate);
            gbBookInfo.Controls.Add(txtAuthor);
            gbBookInfo.Controls.Add(txtDescription);
            gbBookInfo.Controls.Add(txtName);
            gbBookInfo.Controls.Add(txtId);
            gbBookInfo.Controls.Add(lblCategory);
            gbBookInfo.Controls.Add(lblAuthor);
            gbBookInfo.Controls.Add(lblPrice);
            gbBookInfo.Controls.Add(lblQuantity);
            gbBookInfo.Controls.Add(lblReleasedDate);
            gbBookInfo.Controls.Add(lblDesc);
            gbBookInfo.Controls.Add(lblName);
            gbBookInfo.Controls.Add(lblId);
            gbBookInfo.ForeColor = Color.Yellow;
            gbBookInfo.Location = new Point(22, 68);
            gbBookInfo.Margin = new Padding(3, 2, 3, 2);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Padding = new Padding(3, 2, 3, 2);
            gbBookInfo.Size = new Size(438, 334);
            gbBookInfo.TabIndex = 18;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = " Book Info ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(314, 224);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(115, 224);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(110, 23);
            txtQuantity.TabIndex = 4;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(116, 28);
            txtKeyword.Margin = new Padding(3, 2, 3, 2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(194, 23);
            txtKeyword.TabIndex = 0;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(52, 31);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(53, 15);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(22, 411);
            gbTask.Margin = new Padding(3, 2, 3, 2);
            gbTask.Name = "gbTask";
            gbTask.Padding = new Padding(3, 2, 3, 2);
            gbTask.Size = new Size(438, 60);
            gbTask.TabIndex = 20;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(340, 26);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(231, 26);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(123, 26);
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
            // gbSearch
            // 
            gbSearch.Controls.Add(label1);
            gbSearch.Controls.Add(comboBox1);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(494, 68);
            gbSearch.Margin = new Padding(3, 2, 3, 2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 2, 3, 2);
            gbSearch.Size = new Size(457, 113);
            gbSearch.TabIndex = 21;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 76);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 27;
            label1.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 74);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(326, 28);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = Color.White;
            dgvBookList.BorderStyle = BorderStyle.Fixed3D;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(493, 220);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(458, 278);
            dgvBookList.TabIndex = 0;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(493, 196);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(55, 15);
            lblBookList.TabIndex = 23;
            lblBookList.Text = "Book List";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(432, 21);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(158, 37);
            lblFormTitle.TabIndex = 18;
            lblFormTitle.Text = "Book Store";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmList, tsmUser });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1012, 24);
            menuStrip1.TabIndex = 33;
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
            tsmList.DropDownOpened += tsmList_Click;
            tsmList.Click += tsmList_Click;
            // 
            // stbBook
            // 
            stbBook.Name = "stbBook";
            stbBook.ReadOnly = true;
            stbBook.Size = new Size(100, 23);
            stbBook.Text = "Book";
            // 
            // stbCategory
            // 
            stbCategory.Name = "stbCategory";
            stbCategory.ReadOnly = true;
            stbCategory.ShortcutsEnabled = false;
            stbCategory.Size = new Size(100, 23);
            stbCategory.Text = "Category";
            stbCategory.Click += stbCategory_Click;
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
            tsmUser.DropDownOpened += tsmUser_Click;
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
            // BookManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1012, 544);
            Controls.Add(menuStrip1);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbBookInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            FormClosed += BookManagerForm_FormClosed;
            Load += BookManagerForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblDesc;
        private Label lblReleasedDate;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private DateTimePicker dtpReleasedDate;
        private ComboBox cboCategory;
        private GroupBox gbBookInfo;
        private TextBox txtKeyword;
        private Label lblKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSearch;
        private Button btnSearch;
        private DataGridView dgvBookList;
        private Label lblBookList;
        private Label lblFormTitle;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmList;
        private ToolStripTextBox stbBook;
        private ToolStripTextBox stbCategory;
        private ToolStripMenuItem tsmUser;
        private ToolStripMenuItem updateInformationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label label1;
    }
}