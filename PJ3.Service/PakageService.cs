using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class PakageService : IPakageService
    {
        private readonly IRepository<Pakage> _pakageRepository;
        private readonly IRepository<Booking> _bookingRepository;
        public PakageService(IRepository<Pakage> pakageRepository, IRepository<Booking> bookingRepository)
        {
            _pakageRepository = pakageRepository;
            _bookingRepository = bookingRepository;
        }
        public void DeletePakage(int id)
        {
            IEnumerable<Booking> bookingList = _bookingRepository.GetAll().Where(x => x.PakageId == id);
            foreach(Booking booking in bookingList)
            {
                _bookingRepository.Remove(booking);
            }
            Pakage pakage = GetPakage(id);
            _pakageRepository.Remove(pakage);
            _pakageRepository.SaveChange();
        }

        public Pakage GetPakage(int id)
        {
            return _pakageRepository.Get(id);
        }

        public IEnumerable<Pakage> GetPakages()
        {
            return _pakageRepository.GetAll();
        }

        public void InsertPakage(Pakage pakage)
        {
            _pakageRepository.Insert(pakage);
        }

        public void UpdatePakage(Pakage pakage)
        {
            _pakageRepository.Update(pakage);
        }
    }
}
