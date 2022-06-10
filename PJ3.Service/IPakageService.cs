using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
namespace PJ3.Service
{
    public interface IPakageService
    {
        IEnumerable<Pakage> GetPakages();
        Pakage GetPakage(int id);
        void InsertPakage(Pakage pakage);
        void UpdatePakage(Pakage pakage);
        void DeletePakage(int id);
    }
}
