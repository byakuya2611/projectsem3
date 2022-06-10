using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface IBookingService
    {
        IEnumerable<Booking> GetAll();
        Booking GetBooking(int id);
        void InsertBooking(Booking booking);
        void DeleteBooking(int id);
    }
}
