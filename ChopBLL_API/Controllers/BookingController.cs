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
    public class BookingController : ApiController
    {
        // GET: api/Booking
        public IEnumerable<Booking> GetBookings()
        {
            DALServiceGateway<IEnumerable<Booking>> gate = new DALServiceGateway<IEnumerable<Booking>>();

            var bookings = gate.GetItems("api/Booking/");
            return bookings;
        }


        // GET: api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult GetBooking(int id)
        {
            DALServiceGateway<Booking> gate = new DALServiceGateway<Booking>();

            Booking item = gate.GetItems("api/Booking/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        

        // POST: api/Booking
        [ResponseType(typeof(Booking))]
        public IHttpActionResult PostBooking(Booking booking)
        {
            DALServiceGateway<Booking> gate = new DALServiceGateway<Booking>();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            gate.PostItems("api/Booking/", booking);
            return CreatedAtRoute("DefaultApi", new { id = booking.Id }, booking);
        }

        // DELETE: api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult DeleteBooking(int id)
        {
            DALServiceGateway<Booking> gate = new DALServiceGateway<Booking>();
            Booking item = gate.GetItems("api/Booking/" + id + "");
            if (item == null)
            {
                return NotFound();
            }

            gate.DeleteItems("api/Booking/" + id + "");

            return Ok(item);
        }
    }
}
