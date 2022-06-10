using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
namespace PJ3.Service
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAll();
        Contact GetContact(int id);
        void InsertContact(Contact contact);
        void DeleteContact(int id);
    }
}
