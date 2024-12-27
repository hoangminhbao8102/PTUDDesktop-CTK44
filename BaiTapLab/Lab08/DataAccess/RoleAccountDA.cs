using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleAccountDA
    {
        private string connectionString = Ultilities.ConnectionString;

        public List<RoleAccount> GetAll()
        {
            List<RoleAccount> roleAccounts = new List<RoleAccount>();
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.RoleAccount_GetAll;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoleAccount roleAccount = new RoleAccount
                            {
                                RoleID = Convert.ToInt32(reader["RoleID"]),
                                AccountName = reader["AccountName"].ToString(),
                                Actived = Convert.ToBoolean(reader["Actived"]),
                                Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : null
                            };
                            roleAccounts.Add(roleAccount);
                        }
                    }
                }
            }
            return roleAccounts;
        }

        public int InsertUpdateDelete(RoleAccount roleAccount, int action)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.RoleAccount_InsertUpdateDelete;

                    command.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleAccount.RoleID;
                    command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = roleAccount.AccountName;
                    command.Parameters.Add("@Actived", SqlDbType.Bit).Value = roleAccount.Actived;
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = roleAccount.Notes as object ?? DBNull.Value;
                    command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int AssignRole(string accountName, int roleId, bool isActive)
        {
            // Chuẩn bị câu lệnh SQL để thực hiện gán quyền
            string query = @"
        IF EXISTS (SELECT 1 FROM RoleAccount WHERE AccountName = @AccountName)
        BEGIN
            UPDATE RoleAccount
            SET RoleID = @RoleID, Actived = @Actived
            WHERE AccountName = @AccountName
        END
        ELSE
        BEGIN
            INSERT INTO RoleAccount (AccountName, RoleID, Actived)
            VALUES (@AccountName, @RoleID, @Actived)
        END";

            // Sử dụng SqlCommand để thực thi câu lệnh
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AccountName", accountName);
                cmd.Parameters.AddWithValue("@RoleID", roleId);
                cmd.Parameters.AddWithValue("@Actived", isActive);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected; // Số dòng bị ảnh hưởng (INSERT hoặc UPDATE)
            }
        }
    }
}
