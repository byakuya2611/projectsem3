using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface IAccommodationService
    {
        IEnumerable<Accommodation> GetAccommodations();
        Accommodation GetAccommodation(int id);
        IEnumerable<Accommodation> GetAccommodationsByType(int typeId);
        void InsertAccomodation(Accommodation accommodation);
        void UpdateAccomodation(Accommodation accommodation);
        void DeleteAccomodation(int id);
    }
}
