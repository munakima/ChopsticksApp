using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class BookingRepository:IBookingRepository
    {
        private ChopsticksDBEntities db = null;

        public BookingRepository()
        {
            db = new ChopsticksDBEntities();
        }
        public IQueryable<Booking> GetAllBookingsDetails()
        {
            return db.Bookings;
        }

        public Booking GetBooking(int id)
        {
            Booking booking = db.Bookings.Find(id);
            return booking;
        }

        public void AddBooking(Booking booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();
        }

        public void DeleteBooking(int id)
        {
            Booking booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
        }
    }
}
