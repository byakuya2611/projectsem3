using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface ICountryService
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int id);
        void InsertCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(int id);
    }
}
