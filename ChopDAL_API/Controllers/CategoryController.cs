using DAL;
using DAL.Repositories;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChopDAL_API.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategoryRepository repository = (new DALFacade()).CategoryRepository;
        // GET: api/Category
        public IQueryable<Category> GetCategories()
        {
            return repository.GetAllCategoriesDetails();
        }

        // GET: api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(int id)
        {
            Category cate = repository.GetCategory(id);
            if (cate == null)
            {
                return NotFound();
            }

            return Ok(cate);
        }

       
    }
}
