using Microsoft.Identity.Client;
using PagedList.Core;
using Restaurant.BLL.Common;
using Restaurant.DAL;
using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Security
{
    public class UserService : CrudService<Account>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool ChangePassword(string accountName, string newPassword)
        {
            // Tìm tài khoản theo AccountName
            var account = _repository.GetFirst(a => a.AccountName == accountName);
            if (account == null) return false;

            // Cập nhật mật khẩu mới (nên mã hóa mật khẩu trong thực tế)
            account.Password = newPassword;
            _repository.Update(account);
            _unitOfWork.SaveChanges();
            return true;
        }

        public Account GetAccountByUsername(string username)
        {
            return _repository.GetFirst(a => a.AccountName == username);
        }

        public List<Account> GetAllAccounts()
        {
            return _repository.GetAll().ToList();
        }

        public bool ResetPassword(string accountName, string defaultPassword)
        {
            // Tìm tài khoản theo AccountName
            var account = _repository.GetFirst(a => a.AccountName == accountName);
            if (account == null) return false;

            // Đặt lại mật khẩu mặc định
            account.Password = defaultPassword;
            _repository.Update(account);
            _unitOfWork.SaveChanges();
            return true;
        }

        public List<Account> Search(string keyword, int page = 0, int pageSize = 50)
        {
            var query = _repository.GetAll();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(a => a.AccountName.Contains(keyword) ||
                                         (a.FullName != null && a.FullName.Contains(keyword)) ||
                                         (a.Email != null && a.Email.Contains(keyword)));
            }

            query = query.OrderBy(a => a.AccountName);

            return new PagedList<Account>(query, page, pageSize).ToList();
        }

        public bool ValidateAccount(string username, string password)
        {
            var account = GetAccountByUsername(username);
            if (account == null) return false;

            // So sánh mật khẩu (nên sử dụng mã hóa mật khẩu trong thực tế)
            return account.Password == password;
        }
    }
}
