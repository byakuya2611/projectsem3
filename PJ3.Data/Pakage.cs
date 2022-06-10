using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ3.Data
{
    public class Pakage : BaseEntity
    {
        public int AccommodationId { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
