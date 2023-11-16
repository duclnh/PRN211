using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_HoangNT
{
    public partial class BookCategoryManagerForm : Form
    {
        private BookCategoryService _categoryService = new BookCategoryService();
        public BookCategoryManagerForm()
        {
            InitializeComponent();
        }


        private void changeColorMenuUser(object sender, EventArgs e)
        {
            tsmUser.ForeColor = Color.White;
        }

        private void ChangeColorMenu(object sender, EventArgs e)
        {
            tsmList.ForeColor = Color.White;
        }

        private void tsmList_Click(object sender, EventArgs e)
        {
            tsmList.ForeColor = Color.Black;
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            tsmUser.ForeColor = Color.Black;
        }

        private void stbBook_Click(object sender, EventArgs e)
        {
            BookManagerForm bookMgt = new BookManagerForm();
            bookMgt.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookCategoryManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BookCategoryManagerForm_Load(object sender, EventArgs e)
        {
            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void dgvCateList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCateList.SelectedRows.Count > 0)
            {
                var selectedBook = (BookCategory)dgvCateList.SelectedRows[0].DataBoundItem;
                //có trong tay 1 object/1 cuốn sách đang được lựa chọn rồi
                //chấm từng field của nó đổ vào form
                txtId.Text = selectedBook.BookCategoryId.ToString();
                txtName.Text = selectedBook.BookGenreType;
                txtDescription.Text = selectedBook.Description;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = _categoryService.SearchCategories(txtKeyword.Text.Trim());

            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
            dgvCateList.Columns["Books"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out _))
            {
                MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CategoryForm CateFrm = new CategoryForm();
            CateFrm.CateId = int.Parse(txtId.Text);
            CateFrm.ShowDialog();
            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;
            dgvCateList.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            CategoryForm CateFrm = new CategoryForm();
            CateFrm.CateId = null;
            CateFrm.ShowDialog();
            //NEW THÌ SHOW FORM TRỐNG, DO NOTHING
            //xong, đóng form thì show lại lưới/grid
            //load cái danh sách Sách vào grid
            var result = _categoryService.GetAllCategories();
            dgvCateList.DataSource = null;    //vip, xoá lưới, lấy danh sách mới
            dgvCateList.DataSource = result;

        }


    }
}
