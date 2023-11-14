using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    /// <summary>
    /// Class này cung cấp dữ liệu từ table Category cho UI, và ngược lại
    /// Class này sẽ xài CategoryRepo vừa tạo, Repo thì lại gọi đến DbContex
    /// </summary>
    public class BookCategoryService
    {

        private BookCategoryRepository _repo = new BookCategoryRepository();
        public List<BookCategory> GetAllCategories()
        {
            _repo = new BookCategoryRepository();
            return _repo.GetAll();
        }
        public List<BookCategory> SearchCategories(string keyword)
        {
            return _repo.GetAll().Where(b => b.BookGenreType.ToLower().Contains(keyword.ToLower()) ||
                                             b.Description.ToLower().Contains(keyword.ToLower()) ||
                                             b.BookCategoryId.ToString().ToLower().Contains(keyword.ToLower())).ToList();
        }

        public BookCategory? GetACategory(int id)
        {
            return _repo.Get(id);
        }

        public void AddACate(BookCategory cate)
        {
            _repo.Create(cate); 
        }

        public void UpdateACate(BookCategory cate)
        {
            _repo.Update(cate); 
        }
    }
}
