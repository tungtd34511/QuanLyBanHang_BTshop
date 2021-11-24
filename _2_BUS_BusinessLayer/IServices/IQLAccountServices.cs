using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    interface IQLAccountServices
    {
        List<Account> GetlstAccounts();
        void AddAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(int index);
    }
}
