using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore_HoangNT
{
    public partial class CategoryForm : Form
    {
        public int? CateId { get; set; }
        private BookCategoryService _categoryService = new();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (this.CateId != null)
            {
                //edit mode, thì phải hiển thị data 
                //new mode, do nothing, form trống trơn
                var Cate = _categoryService.GetACategory((int)CateId);

                txtId.Text = Cate.BookCategoryId.ToString();
                txtCategory.Text = Cate.BookGenreType;
                txtDescription.Text = Cate.Description;
                lblFormTitle.Text = "Update a Book...";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int categoryId;
            bool isNumeric = int.TryParse(txtId.Text.Trim(), out categoryId);
            if (!isNumeric)
            {
                MessageBox.Show("Invalid ID. Please enter a numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryType = txtCategory.Text.Trim();
            if (string.IsNullOrEmpty(categoryType))
            {
                MessageBox.Show("Category type cannot be empty. Please enter a category type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryDescription = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(categoryDescription))
            {
                MessageBox.Show("Category description cannot be empty. Please enter a category description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BookCategory Cate = new()
            {
                BookCategoryId = int.Parse(txtId.Text.Trim()),
                BookGenreType = txtCategory.Text.Trim(),
                Description = txtDescription.Text.Trim(),
            };
            BookCategory? a = _categoryService.IdExists(categoryId);

            if (CateId != null)  //mode update
            {
                if (a != null) // Check if ID exists when updating
                {
                    _categoryService.UpdateACate(Cate);
                }
                else
                {
                    MessageBox.Show("ID does not exist. Please enter an existing ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (a == null) // Check if ID is new when creating
                {
                    _categoryService.AddACate(Cate);
                }
                else
                {
                    MessageBox.Show("ID already exists. Please enter a new ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Close();
        }
    }
}
