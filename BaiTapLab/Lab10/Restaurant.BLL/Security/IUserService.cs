using Restaurant.BLL.Common;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Security
{
    public interface IUserService : ICrudService<Account>
    {
        List<Account> GetAllAccounts();

        Account GetAccountByUsername(string username);

        bool ValidateAccount(string username, string password);

        List<Account> Search(string keyword, int page = 0, int pageSize = 50);

        bool ChangePassword(string accountName, string newPassword);

        bool ResetPassword(string accountName, string defaultPassword);
    }
}
