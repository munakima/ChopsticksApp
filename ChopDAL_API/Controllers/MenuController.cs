using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChopDAL_API.Controllers
{
    public class MenuController : ApiController
    {
        private IMenuRepository repository = (new DALFacade()).MenuRepository;

        // GET: api/Menu
        public IQueryable<Menu> GetMenus()
        {
            return repository.GetAllMenusDetails();
        }
        //GET:api/Menu?Typeid=1&CategoryId=2
        public IQueryable<Menu> getMenuById(int Typeid, int CategoryId)
        {
            return repository.getMenuById(Typeid,CategoryId);
        }
        // GET: api/Menu/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult GetMenu(int id)
        {
            Menu menu = repository.GetMenu(id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        // PUT: api/Menu/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenu(int id, Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menu.Id)
            {
                return BadRequest();
            }
            try
            {
                repository.EditMenu(id, menu);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!repository.MenuExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Menu
        [ResponseType(typeof(Menu))]
        public IHttpActionResult PostMenu(Menu menu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repository.AddMenu(menu);

            return CreatedAtRoute("DefaultApi", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menu/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult DeleteMenu(int id)
        {
            Menu menu = repository.GetMenu(id);
            if (menu == null)
            {
                return NotFound();
            }

            repository.DeleteMenu(id);

            return Ok(menu);
        }
    }
}
