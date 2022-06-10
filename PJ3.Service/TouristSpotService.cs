using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class TouristSpotService : ITouristSpotService
    {
        private readonly IRepository<TouristSpot> _repository;
        public TouristSpotService(IRepository<TouristSpot> repository)
        {
            _repository = repository;
        }
        public void DeleteTouristSpot(int id)
        {
            TouristSpot touristSpot = GetTouristSpot(id);
            _repository.Delete(touristSpot);
        }

        public TouristSpot GetTouristSpot(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TouristSpot> GetTouristSpots()
        {
            return _repository.GetAll();
        }

        public void InsertTouristSpot(TouristSpot touristSpot)
        {
            _repository.Insert(touristSpot);
        }

        public void UpdateTouristSpot(TouristSpot touristSpot)
        {
            _repository.Update(touristSpot);
        }
    }
}
