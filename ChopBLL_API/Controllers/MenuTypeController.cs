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
    public class MenuTypeController : ApiController
    {
        // GET: api/MenuType
        public IEnumerable<MenuType> GetMenuTypes()
        {
            DALServiceGateway<IEnumerable<MenuType>> gate = new DALServiceGateway<IEnumerable<MenuType>>();

            var menuTypes = gate.GetItems("api/MenuType/");
            return menuTypes;
        }

        // GET: api/MenuType/5
        [ResponseType(typeof(MenuType))]
        public IHttpActionResult GetCategory(int id)
        {
            DALServiceGateway<MenuType> gate = new DALServiceGateway<MenuType>();

            MenuType item = gate.GetItems("api/MenuType/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
