using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ3.Data
{
    public class Booking : BaseEntity
    {
        public int PakageId { get; set; }
        public int PaymentModeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CitizenCard { get; set; }
        public Pakage Pakage { get; set; }
        public PaymentMode PaymentMode { get; set; }
    }
}
