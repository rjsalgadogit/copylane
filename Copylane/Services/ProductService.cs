﻿using CopyLane.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CopyLane.Services
{
	public class ProductService
	{
		private string Server { get; set; }
		private string Database { get; set; }
		private string ConnectionString { get; set; }

		public ProductService()
		{
			Server = "localhost\\SQLEXPRESS";
			Database = "CopyLane";
			ConnectionString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True";
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

		public List<ProductModel> GetProducts()
		{
			var query = @"SELECT * FROM dbo.Items";

			SqlDataReader sqlReader;
			DataTable dataTable = new DataTable();

			try
			{
				using (SqlConnection conn = new SqlConnection(ConnectionString))
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

			var records = new List<ProductModel>();
			records = JsonConvert.DeserializeObject<List<ProductModel>>(JsonConvert.SerializeObject(dataTable));

			return records;
		}

		public List<ProductModel> SearchProduct(ProductModel product)
        {
			var sp = "SearchItem";

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
						comm.Parameters.AddWithValue("@Description", product.Description);

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

			var records = new List<ProductModel>();
			records = JsonConvert.DeserializeObject<List<ProductModel>>(JsonConvert.SerializeObject(dataTable));

			return records;
		}

		public ProductModel GetProductByKey(ProductModel product)
		{
			var sp = "GetProductByKey";

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
						comm.Parameters.AddWithValue("@ShortcutKey", product.ShortcutKey);

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

			var records = new List<ProductModel>();
			records = JsonConvert.DeserializeObject<List<ProductModel>>(JsonConvert.SerializeObject(dataTable));

			return records.FirstOrDefault();
		}

		public bool SaveProduct(ProductModel product)
        {
			var sp = "SaveItem";

			try
            {
				using (SqlConnection conn = new SqlConnection(ConnectionString))
				{
					conn.Open();

					using (SqlCommand comm = new SqlCommand(sp, conn))
                    {
						comm.CommandType = CommandType.StoredProcedure;
						comm.Parameters.AddWithValue("@Id", product.Id);
						comm.Parameters.AddWithValue("@Description", product.Description);
						comm.Parameters.AddWithValue("@Price", product.Price);
						comm.Parameters.AddWithValue("@ShortcutKey", product.ShortcutKey);

						int rowAffected = comm.ExecuteNonQuery();
						conn.Close();
					}
				}

				return true;
            }
			catch (Exception ex)
            {
				MessageBox.Show($" {ex.Message}"
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);

				return false;
            }
        }

		public bool DeleteProduct(ProductModel product)
        {
			var sp = "DeleteItem";

			try
            {
				using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
					conn.Open();

					using (SqlCommand comm = new SqlCommand(sp, conn))
                    {
						comm.CommandType = CommandType.StoredProcedure;
						comm.Parameters.AddWithValue("@Id", product.Id);

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

		public bool SaveTransactionDetails(List<ProductModel> products, string uniqueId)
		{
			var sp = "SaveTransactionDetails";
			

			try
			{
				foreach (var product in products)
				{
					var total = product.Total + product.Additional - product.Discount;

					using (SqlConnection conn = new SqlConnection(ConnectionString))
					{
						conn.Open();

						using (SqlCommand comm = new SqlCommand(sp, conn))
						{
							comm.CommandType = CommandType.StoredProcedure;
							comm.Parameters.AddWithValue("@Id", uniqueId);
							comm.Parameters.AddWithValue("@Description", product.Description);
							comm.Parameters.AddWithValue("@Total", total);
							comm.Parameters.AddWithValue("@Qty", product.Qty);

							int rowAffected = comm.ExecuteNonQuery();
							conn.Close();
						}
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

		public bool SaveTransaction(string uniqueId, decimal change, decimal payment, decimal subtotal)
		{
			var sp = "SaveTransaction";

			try
			{
				using (SqlConnection conn = new SqlConnection(ConnectionString))
				{
					conn.Open();

					using (SqlCommand comm = new SqlCommand(sp, conn))
					{
						comm.CommandType = CommandType.StoredProcedure;
						comm.Parameters.AddWithValue("@TransactionDetailsId", uniqueId);
						comm.Parameters.AddWithValue("@Username", "system");
						comm.Parameters.AddWithValue("@Payment", payment);
						comm.Parameters.AddWithValue("@Change", change);
						comm.Parameters.AddWithValue("@Subtotal", subtotal);

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
