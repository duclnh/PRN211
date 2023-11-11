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
        public BookCategoryManagerForm()
        {
            InitializeComponent();
        }

        private void BookCategoryManagerForm_Load(object sender, EventArgs e)
        {

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
    }
}
