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
            BookCategory Cate = new()
            {
                BookCategoryId = int.Parse(txtId.Text.Trim()),
                BookGenreType = txtCategory.Text.Trim(),
                Description = txtDescription.Text.Trim(),
            };

            if (CateId != null)  //mode update
                _categoryService.UpdateACate(Cate);
            else
                _categoryService.AddACate(Cate);

            Close();  
        }
    }
}
