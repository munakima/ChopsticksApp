using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
   public interface IBookingRepository
    {
       IQueryable<Booking> GetAllBookingsDetails();
       Booking GetBooking(int id);

       void AddBooking(Booking booking);

       void DeleteBooking(int id);

    }
}
