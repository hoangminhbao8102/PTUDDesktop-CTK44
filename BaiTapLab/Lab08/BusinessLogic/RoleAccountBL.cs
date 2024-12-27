using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleAccountBL
    {
        // Đối tượng RoleAccountDA từ DataAccess
        RoleAccountDA roleAccountDA = new RoleAccountDA();

        // Phương thức lấy hết dữ liệu
        public List<RoleAccount> GetAll()
        {
            return roleAccountDA.GetAll();
        }

        // Phương thức thêm dữ liệu
        public int Insert(RoleAccount roleAccount)
        {
            return roleAccountDA.InsertUpdateDelete(roleAccount, 0); // Action = 0: Insert
        }

        // Phương thức cập nhật dữ liệu
        public int Update(RoleAccount roleAccount)
        {
            return roleAccountDA.InsertUpdateDelete(roleAccount, 1); // Action = 1: Update
        }

        // Phương thức xóa dữ liệu
        public int Delete(RoleAccount roleAccount)
        {
            return roleAccountDA.InsertUpdateDelete(roleAccount, 2); // Action = 2: Delete
        }

        // Phương thức gán quyền
        public int AssignRole(string accountName, int roleId, bool isActive)
        {
            // Tầng Data Access sẽ thực hiện công việc chính
            return roleAccountDA.AssignRole(accountName, roleId, isActive);
        }
    }
}
