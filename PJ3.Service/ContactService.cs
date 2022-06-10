using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repository;
        public ContactService(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public void DeleteContact(int id)
        {
            Contact contact = GetContact(id);
            _repository.Delete(contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _repository.GetAll();
        }

        public Contact GetContact(int id)
        {
            return _repository.Get(id);
        }

        public void InsertContact(Contact contact)
        {
            _repository.Insert(contact);
        }
    }
}
