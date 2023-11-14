using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Class này dùng để CRUD table Category - Thể loại Sách
    /// Thường thể loại sách hiếm khi thay đổi, chủ yếu là lấy ra
    /// danh sách đưa vào dropdown/combobox
    /// </summary>
    public class BookCategoryRepository
    {
        private BookManagement2023DbContext _context;

        public BookCategory? Get(int CateId)
        {
            _context = new BookManagement2023DbContext();
            return _context.BookCategories.Find(CateId);
        }

        public List<BookCategory> GetAll()
        {
            return new BookManagement2023DbContext().BookCategories.ToList();
        }

        public void Create(BookCategory cate)
        {
            _context = new BookManagement2023DbContext();
            _context.BookCategories.Add(cate); 
            _context.SaveChanges();
        }
        public void Update(BookCategory cate)
        {
            _context = new BookManagement2023DbContext();
            _context.BookCategories.Update(cate);
            _context.SaveChanges();
        }
    }
}
