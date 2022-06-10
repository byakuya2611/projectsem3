using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class BookingService : IBookingService
    {
        private readonly IRepository<Booking> _repository;
        public BookingService(IRepository<Booking> repository)
        {
            _repository = repository;
        }
        public void DeleteBooking(int id)
        {
            Booking booking = GetBooking(id);
            _repository.Delete(booking);
        }

        public IEnumerable<Booking> GetAll()
        {
            return _repository.GetAll();
        }

        public Booking GetBooking(int id)
        {
            return _repository.Get(id);
        }

        public void InsertBooking(Booking booking)
        {
            _repository.Insert(booking);
        }
    }
}
