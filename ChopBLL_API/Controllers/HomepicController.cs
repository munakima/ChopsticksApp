using ChopBLL_API.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ChopBLL_API.Controllers
{
    public class HomepicController : ApiController
    {
        // GET: api/HomePics
        public IEnumerable<HomePic> GetHomePics()
        {
            DALServiceGateway<IEnumerable<HomePic>> gate = new DALServiceGateway<IEnumerable<HomePic>>();

            var homepics = gate.GetItems("api/HomePics/");
            return homepics;
        }

        // GET: api/HomePics/5
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult GetHomePic(int id)
        {
            DALServiceGateway<HomePic> gate = new DALServiceGateway<HomePic>();

            HomePic item = gate.GetItems("api/HomePics/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/HomePics/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHomePic(int id, HomePic homePic)
        {
            DALServiceGateway<HomePic> gate = new DALServiceGateway<HomePic>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != homePic.Id)
            {
                return BadRequest();
            }

            if (id != homePic.Id)
            {
                return BadRequest();
            }
         
                gate.PutItems("api/HomePics/"+id, homePic);

               
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HomePics
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult PostHomePic(HomePic homePic)
        {
            DALServiceGateway<HomePic> gate = new DALServiceGateway<HomePic>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gate.PostItems("api/HomePics/",homePic);
            return CreatedAtRoute("DefaultApi", new { id = homePic.Id }, homePic);
        }

        // DELETE: api/HomePics/5
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult DeleteHomePic(int id)
        {
            DALServiceGateway<HomePic> gate = new DALServiceGateway<HomePic>();
            HomePic item = gate.GetItems("api/HomePics/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            gate.DeleteItems("api/HomePics/"+id+"");

            return Ok(item);
        }
    }
}
