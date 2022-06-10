using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class AccommodationService : IAccommodationService
    {
        private readonly IRepository<Accommodation> _accommodationRepository;
        private readonly IRepository<Pakage> _pakageRepository;
        private readonly IRepository<Booking> _bookingRepository;
        public AccommodationService(IRepository<Accommodation> accommodationRepository,
            IRepository<Pakage> pakageRepository,
            IRepository<Booking> bookingRepository)
        {
            _accommodationRepository = accommodationRepository;
            _pakageRepository = pakageRepository;
            _bookingRepository = bookingRepository;
        }
        public void DeleteAccomodation(int id)
        {
            IEnumerable<Pakage> pakageList = _pakageRepository.GetAll().Where(x => x.AccommodationId == id);
            foreach(Pakage pakage in pakageList)
            {
                IEnumerable<Booking> bookingList = _bookingRepository.GetAll().Where(p => p.PakageId == pakage.Id);
                foreach(Booking booking in bookingList)
                {
                    _bookingRepository.Remove(booking);
                }
                _pakageRepository.Remove(pakage);
            }
            Accommodation accommodation = GetAccommodation(id);
            _accommodationRepository.Remove(accommodation);
            _accommodationRepository.SaveChange();
        }

        public Accommodation GetAccommodation(int id)
        {
            return _accommodationRepository.Get(id);
        }

        public IEnumerable<Accommodation> GetAccommodations()
        {
            return _accommodationRepository.GetAll();
        }

        public IEnumerable<Accommodation> GetAccommodationsByType(int typeId)
        {
            return _accommodationRepository.GetAll().Where(x => x.TypeId == typeId);
        }

        public void InsertAccomodation(Accommodation accommodation)
        {
            _accommodationRepository.Insert(accommodation);
        }

        public void UpdateAccomodation(Accommodation accommodation)
        {
            _accommodationRepository.Update(accommodation);
        }
    }
}
