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
    public class FoodController : ApiController
    {
        // GET: api/Food
        public IEnumerable<Food> GetFoods()
        {
            DALServiceGateway<IEnumerable<Food>> gate = new DALServiceGateway<IEnumerable<Food>>();

            var foods = gate.GetItems("api/Food/");
            return foods;
        }
        // GET: api/Food?CategoryId=2
        public IEnumerable<Food> getMenuById(int CategaryId)
        {
            DALServiceGateway<IEnumerable<Food>> gate = new DALServiceGateway<IEnumerable<Food>>();
            var food = gate.GetItems("api/Food?CategoryId=" + CategaryId + "");
            return food;
        }

        // GET: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult GetFood(int id)
        {
            DALServiceGateway<Food> gate = new DALServiceGateway<Food>();

            Food item = gate.GetItems("api/Food/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Food/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFood(int id, Food food)
        {
            DALServiceGateway<Food> gate = new DALServiceGateway<Food>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != food.Id)
            {
                return BadRequest();
            }

            if (id != food.Id)
            {
                return BadRequest();
            }

            gate.PutItems("api/Food/" + id, food);


            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Food
        [ResponseType(typeof(Food))]
        public IHttpActionResult PostFood(Food food)
        {
            DALServiceGateway<Food> gate = new DALServiceGateway<Food>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gate.PostItems("api/Food/", food);
            return CreatedAtRoute("DefaultApi", new { id = food.Id }, food);
        }

        // DELETE: api/Food/5
        [ResponseType(typeof(Food))]
        public IHttpActionResult DeleteFood(int id)
        {
            DALServiceGateway<Food> gate = new DALServiceGateway<Food>();
            Food item = gate.GetItems("api/Food/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            gate.DeleteItems("api/Food/" + id + "");

            return Ok(item);
        }
    }
}
