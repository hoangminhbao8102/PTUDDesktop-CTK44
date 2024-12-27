using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TableDA
    {
        private string connectionString = Ultilities.ConnectionString;

        public List<Table> GetAll()
        {
            List<Table> tables = new List<Table>();
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Table_GetAll;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Table table = new Table
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Status = Convert.ToInt32(reader["Status"]),
                                Capacity = Convert.ToInt32(reader["Capacity"])
                            };
                            tables.Add(table);
                        }
                    }
                }
            }
            return tables;
        }

        public int InsertUpdateDelete(Table table, int action)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Table_InsertUpdateDelete;

                    SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput,
                        Value = table.ID
                    };
                    command.Parameters.Add(idParameter);

                    // Chỉ thêm các tham số này nếu action là Insert (0) hoặc Update (1)
                    if (action == 0 || action == 1)
                    {
                        command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = table.Name ?? (object)DBNull.Value;
                        command.Parameters.Add("@Status", SqlDbType.Int).Value = table.Status;
                        command.Parameters.Add("@Capacity", SqlDbType.Int).Value = table.Capacity;
                    }

                    // Thêm tham số hành động
                    command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

                    int result = command.ExecuteNonQuery();
                    if (result > 0 && action == 0) // Trả về ID nếu là thao tác Insert
                    {
                        return (int)command.Parameters["@ID"].Value;
                    }
                    return result; // Trả về số dòng bị ảnh hưởng
                }
            }
        }
    }
}
