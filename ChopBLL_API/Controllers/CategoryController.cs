using ChopBLL_API.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChopBLL_API.Controllers
{
    public class CategoryController : ApiController
    {
        // GET: api/Category
        public IEnumerable<Category> GetCategories()
        {
            DALServiceGateway<IEnumerable<Category>> gate = new DALServiceGateway<IEnumerable<Category>>();

            var categories = gate.GetItems("api/Category/");
            return categories;
        }

        // GET: api/Category/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(int id)
        {
            DALServiceGateway<Category> gate = new DALServiceGateway<Category>();

            Category item = gate.GetItems("api/Category/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
