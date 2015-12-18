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
    public class FoodController : ApiController
    {
        private IFoodRepository repository = (new DALFacade()).FoodRepository;

        // GET: api/Food
        public IQueryable<Food> GetFoods()
        {
            return repository.GetAllFoodsDetails();
        }

        // GET: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult GetFood(int id)
        {
            Food food = repository.GetFood(id);
            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }

        // PUT: api/Food/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFood(int id, Food food)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != food.Id)
            {
                return BadRequest();
            }
            try
            {
                repository.EditFood(id, food);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!repository.FoodExists(id))
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

        // POST: api/Food
        [ResponseType(typeof(Food))]
        public IHttpActionResult PostFood(Food food)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            repository.AddFood(food);

            return CreatedAtRoute("DefaultApi", new { id = food.Id }, food);
        }

        // DELETE: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult DeleteFood(int id)
        {
            Food food = repository.GetFood(id);
            if (food == null)
            {
                return NotFound();
            }

            repository.DeleteFood(id);

            return Ok(food);
        }

    }
}
