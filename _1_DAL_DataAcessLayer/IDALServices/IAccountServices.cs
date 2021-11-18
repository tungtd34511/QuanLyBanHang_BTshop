using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.Entities;

namespace _1_DAL_DataAcessLayer.IDALServices
{ 
    public interface IAccountServices
    {
        List<Account> GetlstAccounts();
        void GetlstAccountsFromDB();
        string AddAccount(Account account);
        string UpdateAccount(Account account);
        string DeleteAccount(int id);
    }
}
