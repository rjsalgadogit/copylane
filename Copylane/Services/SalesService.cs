using CopyLane.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane.Services
{
    public class SalesService
    {
        private string Server { get; set; }
        private string Database { get; set; }
        private string ConnectionString { get; set; }

        public SalesService()
        {
            Server = "localhost\\SQLEXPRESS";
            Database = "CopyLane";
            ConnectionString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";
        }

        public List<TransactionModel> GetTransactionToday()
        {
            var sp = "GetTransactionToday";

            SqlDataReader sqlReader;
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand comm = new SqlCommand(sp, conn))
                    {
                        comm.CommandType = CommandType.StoredProcedure;

                        sqlReader = comm.ExecuteReader();
                        dataTable.Load(sqlReader);
                        sqlReader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

            var records = new List<TransactionModel>();
            records = JsonConvert.DeserializeObject<List<TransactionModel>>(JsonConvert.SerializeObject(dataTable));

            return records;
        }

        public List<TransactionModel> GetTransactionByDate(DateTime? from, DateTime? to)
        {
            var sp = "GetTransactionByDate";

            SqlDataReader sqlReader;
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand comm = new SqlCommand(sp, conn))
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@From", from);
                        comm.Parameters.AddWithValue("@To", to);

                        sqlReader = comm.ExecuteReader();
                        dataTable.Load(sqlReader);
                        sqlReader.Close();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

            var records = new List<TransactionModel>();
            records = JsonConvert.DeserializeObject<List<TransactionModel>>(JsonConvert.SerializeObject(dataTable));

            return records;
        }
    }
}
