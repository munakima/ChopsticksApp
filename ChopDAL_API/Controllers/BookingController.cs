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
    public class BookingController : ApiController
    {
        private IBookingRepository repository = (new DALFacade()).BookingRepository;

        // GET: api/Booking
        public IQueryable<Booking> GetBookings()
        {
            return repository.GetAllBookingsDetails();
        }

        // GET: api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult GetBooking(int id)
        {
            Booking booking = repository.GetBooking(id);
            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }


        // POST: api/Booking
        [ResponseType(typeof(Booking))]
        public IHttpActionResult PostBooking(Booking booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repository.AddBooking(booking);

            return CreatedAtRoute("DefaultApi", new { id = booking.Id }, booking);
        }

        // DELETE: api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult DeleteBooking(int id)
        {
            Booking booking = repository.GetBooking(id);
            if (booking == null)
            {
                return NotFound();
            }

            repository.DeleteBooking(id);

            return Ok(booking);
        }
    }
}
