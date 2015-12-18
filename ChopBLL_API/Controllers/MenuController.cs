using ChopBLL_API.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Models;

namespace ChopBLL_API.Controllers
{
    public class MenuController : ApiController
    {
        // GET: api/Menu
        public IEnumerable<Menu> GetMenus()
        {
            DALServiceGateway<IEnumerable<Menu>> gate = new DALServiceGateway<IEnumerable<Menu>>();

            var menus = gate.GetItems("api/Menu/");
            return menus;
        }
        // GET: api/Menu?Typeid=1&CategoryId=2
        public IEnumerable<Menu> getMenuById(int Typeid, int CategoryId)
        {
            DALServiceGateway<IEnumerable<Menu>> gate = new DALServiceGateway<IEnumerable<Menu>>();
            var menus = gate.GetItems("api/Menu?Typeid="+Typeid+"&CategoryId="+CategoryId+"");
            return menus;
        }

        // GET: api/Menu/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult GetMenu(int id)
        {
            DALServiceGateway<Menu> gate = new DALServiceGateway<Menu>();

            Menu item = gate.GetItems("api/Menu/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Menu/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenu(int id, Menu menu)
        {
            DALServiceGateway<Menu> gate = new DALServiceGateway<Menu>();
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menu.Id)
            {
                return BadRequest();
            }

            if (id != menu.Id)
            {
                return BadRequest();
            }

            gate.PutItems("api/Menu/" + id, menu);


            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Menu
        [ResponseType(typeof(Menu))]
        public IHttpActionResult PostMenu(Menu menu)
        {
            DALServiceGateway<Menu> gate = new DALServiceGateway<Menu>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gate.PostItems("api/Menu/", menu);
            return CreatedAtRoute("DefaultApi", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menu/5
        [ResponseType(typeof(Menu))]
        public IHttpActionResult DeleteMenu(int id)
        {
            DALServiceGateway<Menu> gate = new DALServiceGateway<Menu>();
            Menu item = gate.GetItems("api/Menu/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            gate.DeleteItems("api/Menu/" + id + "");

            return Ok(item);
        }
    }
}
