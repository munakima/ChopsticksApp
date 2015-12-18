using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class CategoryRepository : ICategoryRepository
    {
        private ChopsticksDBEntities db = null;

        public CategoryRepository()
        {
            db = new ChopsticksDBEntities();
        }
        public IQueryable<Category> GetAllCategoriesDetails()
        {
            return db.Categories;
        }
        public Category GetCategory(int id)
        {
            Category cate = db.Categories.Find(id);
            return cate;
        }

    }
}
