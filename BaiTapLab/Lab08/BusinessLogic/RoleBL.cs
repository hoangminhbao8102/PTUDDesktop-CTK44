using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleBL
    {
        // Đối tượng RoleDA từ DataAccess
        RoleDA roleDA = new RoleDA();

        // Phương thức lấy hết dữ liệu
        public List<Role> GetAll()
        {
            return roleDA.GetAll();
        }

        // Phương thức thêm dữ liệu
        public int Insert(Role role)
        {
            return roleDA.InsertUpdateDelete(role, 0); // Action = 0: Insert
        }

        // Phương thức cập nhật dữ liệu
        public int Update(Role role)
        {
            return roleDA.InsertUpdateDelete(role, 1); // Action = 1: Update
        }

        // Phương thức xóa dữ liệu
        public int Delete(Role role)
        {
            return roleDA.InsertUpdateDelete(role, 2); // Action = 2: Delete
        }
    }
}
