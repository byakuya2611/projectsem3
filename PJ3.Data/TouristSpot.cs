using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ3.Data
{
    public class TouristSpot : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
        public Country Country { get; set; }
    }
}
