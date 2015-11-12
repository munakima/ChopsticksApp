using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ChopAPI.Models;
using Modules.DAL;
using Modules.DAL.Impl;
using Modules;

namespace ChopAPI.Controllers
{
    public class HomePicsController : ApiController
    {
        private IHomepicRepository repository =  (new DALFacade()).HomepicRepository;

        // GET: api/HomePics
        public IQueryable<HomePic> GetHomePics()
        {
            return repository.GetAllHomepicDetails();
        }

        // GET: api/HomePics/5
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult GetHomePic(int id)
        {
            HomePic homePic = repository.GetHomePic(id);
            if (homePic == null)
            {
                return NotFound();
            }

            return Ok(homePic);
        }

        // PUT: api/HomePics/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHomePic(int id, HomePic homePic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != homePic.Id)
            {
                return BadRequest();
            }
            try
            {
                repository.EditHomepic(id, homePic);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!repository.HomePicExists(id))
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

        // POST: api/HomePics
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult PostHomePic(HomePic homePic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repository.AddHomepic(homePic);

            return CreatedAtRoute("DefaultApi", new { id = homePic.Id }, homePic);
        }

        // DELETE: api/HomePics/5
        [ResponseType(typeof(HomePic))]
        public IHttpActionResult DeleteHomePic(int id)
        {
            HomePic homePic = repository.GetHomePic(id);
            if (homePic == null)
            {
                return NotFound();
            }

            repository.DeleteHomepic(id);

            return Ok(homePic);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool HomePicExists(int id)
        //{
        //    return db.HomePics.Count(e => e.Id == id) > 0;
        //}
    }
}