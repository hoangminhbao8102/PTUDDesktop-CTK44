using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDA
    {
        private string connectionString = Ultilities.ConnectionString;

        public List<Role> GetAll()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Role_GetAll;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                RoleName = reader["RoleName"].ToString(),
                                Path = reader["Path"] != DBNull.Value ? reader["Path"].ToString() : null,
                                Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : null
                            };
                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }

        public int InsertUpdateDelete(Role role, int action)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Role_InsertUpdateDelete;

                    SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput,
                        Value = role.ID
                    };
                    command.Parameters.Add(idParameter);

                    command.Parameters.Add("@RoleName", SqlDbType.NVarChar, 1000).Value = role.RoleName;
                    command.Parameters.Add("@Path", SqlDbType.NVarChar, 3000).Value = role.Path as object ?? DBNull.Value;
                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = role.Notes as object ?? DBNull.Value;
                    command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                    int result = command.ExecuteNonQuery();
                    if (result > 0 && action == 0)
                    {
                        return (int)command.Parameters["@ID"].Value;
                    }
                    return result;
                }
            }
        }
    }
}
