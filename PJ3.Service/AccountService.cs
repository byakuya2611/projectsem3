using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;
using PJ3.Repo;

namespace PJ3.Service
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Account> _repository;
        public AccountService(IRepository<Account> repository)
        {
            _repository = repository;
        }
        public void DeleteAccount(int id)
        {
            Account account = GetAccount(id);
            _repository.Delete(account);
        }

        public Account GetAccount(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _repository.GetAll();
        }

        public void InsertAccount(Account account)
        {
            _repository.Insert(account);
        }

        public void UpdateAccount(Account account)
        {
            _repository.Update(account);
        }
    }
}
