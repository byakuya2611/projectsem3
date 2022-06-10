using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface ITouristSpotService
    {
        IEnumerable<TouristSpot> GetTouristSpots();
        TouristSpot GetTouristSpot(int id);
        void InsertTouristSpot(TouristSpot touristSpot);
        void UpdateTouristSpot(TouristSpot touristSpot);
        void DeleteTouristSpot(int id);
    }
}
