using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillsDA
    {
        private string connectionString = Ultilities.ConnectionString;

        public List<Bills> GetAll()
        {
            List<Bills> bills = new List<Bills>();
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Bills_GetAll;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bills bill = new Bills
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                TableID = Convert.ToInt32(reader["TableID"]),
                                Amount = Convert.ToInt32(reader["Amount"]),
                                Discount = reader["Discount"] != DBNull.Value ? Convert.ToSingle(reader["Discount"]) : 0,
                                Tax = reader["Tax"] != DBNull.Value ? Convert.ToSingle(reader["Tax"]) : 0,
                                Status = Convert.ToBoolean(reader["Status"]),
                                // Sử dụng giá trị mặc định cho DateTime nếu không có giá trị
                                CheckoutDate = reader["CheckoutDate"] != DBNull.Value ? Convert.ToDateTime(reader["CheckoutDate"]) : DateTime.MinValue,
                                Account = reader["Account"].ToString()
                            };
                            bills.Add(bill);
                        }
                    }
                }
            }
            return bills;
        }

        public int InsertUpdateDelete(Bills bill, int action)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                using (SqlCommand command = sqlConn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = Ultilities.Bills_InsertUpdateDelete;

                    SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput,
                        Value = bill.ID
                    };
                    command.Parameters.Add(idParameter);

                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = bill.Name ?? (object)DBNull.Value;
                    command.Parameters.Add("@TableID", SqlDbType.Int).Value = bill.TableID;
                    command.Parameters.Add("@Amount", SqlDbType.Int).Value = bill.Amount;
                    command.Parameters.Add("@Discount", SqlDbType.Float).Value = bill.Discount;
                    command.Parameters.Add("@Tax", SqlDbType.Float).Value = bill.Tax;
                    command.Parameters.Add("@Status", SqlDbType.Bit).Value = bill.Status;

                    // Kiểm tra CheckoutDate hợp lệ
                    command.Parameters.Add("@CheckoutDate", SqlDbType.SmallDateTime).Value =
                        bill.CheckoutDate != DateTime.MinValue && bill.CheckoutDate >= new DateTime(1753, 1, 1)
                        ? bill.CheckoutDate
                        : (object)DBNull.Value;

                    command.Parameters.Add("@Account", SqlDbType.NVarChar, 100).Value = bill.Account ?? (object)DBNull.Value;

                    // Kiểm tra Date hợp lệ
                    command.Parameters.Add("@Date", SqlDbType.DateTime).Value =
                        bill.Date != DateTime.MinValue && bill.Date >= new DateTime(1753, 1, 1)
                        ? bill.Date
                        : (object)DBNull.Value;

                    command.Parameters.Add("@Total", SqlDbType.Decimal).Value = bill.Total;
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

        public bool PayBill(int billId, decimal discount, decimal finalTotal)
        {
            // Câu lệnh SQL để cập nhật thông tin thanh toán
            string query = "UPDATE Bills " +
                           "SET Discount = @Discount, Total = @Total, Status = 1, CheckoutDate = @CheckoutDate " +
                           "WHERE ID = @BillID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@Total", finalTotal);
                cmd.Parameters.AddWithValue("@CheckoutDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@BillID", billId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                // Trả về true nếu cập nhật thành công
                return rowsAffected > 0;
            }
        }
    }
}
