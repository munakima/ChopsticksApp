using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChopDAL_API.Controllers
{
    public class MenuTypeController : ApiController
    {
        private IMenuTypeRepository repository = (new DALFacade()).MenuTypeRepository;
        // GET: api/MenuType
        public IQueryable<MenuType> GetMenuTypes()
        {
            return repository.GetAllMenuTypesDetails();
        }

        // GET: api/MenuType/5
        [ResponseType(typeof(MenuType))]
        public IHttpActionResult GetMenuType(int id)
        {
            MenuType mt = repository.GetMenuType(id);
            if (mt == null)
            {
                return NotFound();
            }

            return Ok(mt);
        }
    }
}
