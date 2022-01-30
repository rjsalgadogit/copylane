using Copylane.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copylane.Services
{
	public class ItemService
	{
		public string Server { get; set; }
		public string Database { get; set; }

		public ItemService()
		{
			Server = "localhost\\SQLEXPRESS";
			Database = "CopyLane";
		}

		public bool Connected()
		{
			try
			{
				var connString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";

				var conn = new SqlConnection(connString);
				conn.Open();
				conn.Close();

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);

				return false;
			}
		}

		public List<ItemModel> GetItems()
		{
			var connString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";
			var query = @"SELECT * FROM dbo.Items";

			SqlDataReader sqlReader;
			DataTable dataTable = new DataTable();

			try
			{
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();

					using (SqlCommand comm = new SqlCommand(query, conn))
					{
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

			var records = new List<ItemModel>();
			records = JsonConvert.DeserializeObject<List<ItemModel>>(JsonConvert.SerializeObject(dataTable));

			return records;
		}

		public bool SaveItem(ItemModel item)
		{
			var connString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";
			var sp = "SaveItem";

			try
			{
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();

					using (SqlCommand comm = new SqlCommand(sp, conn))
					{
						comm.CommandType = CommandType.StoredProcedure;
						comm.Parameters.AddWithValue("@Id", item.Id);
						comm.Parameters.AddWithValue("@Description", item.Description);
						comm.Parameters.AddWithValue("@Price", item.Price);

						int rowAffected = comm.ExecuteNonQuery();
						conn.Close();
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);

				return false;
			}
		}
	}
}
