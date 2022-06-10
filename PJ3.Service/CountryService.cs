using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _countryRepository;
        private readonly IRepository<Accommodation> _accommodationRepository;
        private readonly IRepository<TouristSpot> _touristSpotRepository;

        public CountryService(IRepository<Country> countryRepository, 
            IRepository<Accommodation> accomodationRepository,
            IRepository<TouristSpot> touristSpotRepository)
        {
            _countryRepository = countryRepository;
            _accommodationRepository = accomodationRepository;
            _touristSpotRepository = touristSpotRepository;
        }
        public void DeleteCountry(int id)
        {
            IEnumerable<Accommodation> accommodationList = _accommodationRepository.GetAll().Where(x => x.CountryId == id);
            foreach(Accommodation accommodation in accommodationList)
            {
                _accommodationRepository.Remove(accommodation);
            }
            IEnumerable<TouristSpot> touristSpotList = _touristSpotRepository.GetAll().Where(x => x.CountryId == id);
            foreach(TouristSpot touristSpot in touristSpotList)
            {
                _touristSpotRepository.Remove(touristSpot);
            }
            Country country = GetCountry(id);
            _countryRepository.Remove(country);
            _countryRepository.SaveChange();
        }

        public IEnumerable<Country> GetCountries()
        {
            return _countryRepository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return _countryRepository.Get(id);
        }

        public void InsertCountry(Country country)
        {
            _countryRepository.Insert(country);
        }

        public void UpdateCountry(Country country)
        {
            _countryRepository.Update(country);
        }
    }
}
