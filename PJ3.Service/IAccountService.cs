using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ3.Data;

namespace PJ3.Service
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        Account GetAccount(int id);
        void InsertAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int id);
    }
}
