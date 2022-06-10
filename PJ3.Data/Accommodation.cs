using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ3.Data
{
    public class Accommodation : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Location { get; set; }
        public float Price { get; set; }
        public string Rating { get; set; }
        public Boolean Avaibility { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }
        public Country Country { get; set; }
        public AccommodationType AccommodationType { get; set; }
    }
}
