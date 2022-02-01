using Copylane.Model;
using Copylane.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copylane
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Control Events

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadItemGrid();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Description_Textbox.Text))
			{
				var itemId = string.IsNullOrEmpty(HiddenId_Textbox.Text) ? 0 : Convert.ToInt32(HiddenId_Textbox.Text);

				if (itemId > 0)
				{
					MessageBox.Show(" Item Already Exist (Click the 'Cancel' button first)."
						, "Error"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Error);
				}
				else
				{
					SaveItem(new ItemModel
					{
						Description = Description_Textbox.Text,
						Price = Convert.ToDecimal(Price_Textbox.Text)
					});

					LoadItemGrid();
				}
			}
			else
			{
				MessageBox.Show(" Description Missing!"
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
			}
		}

		private void Search_Click(object sender, EventArgs e)
		{
			var bindingSource = new BindingSource();

			bindingSource.DataSource = SearchItem(Search_Textbox.Text);
			ItemGrid.DataSource = bindingSource;
		}

		private void Search_Textbox_KeyDown(object sender, KeyEventArgs e)
		{
			Search_Click(this, new EventArgs());
		}

		private void ItemGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow row = ItemGrid.Rows[e.RowIndex];

			HiddenId_Textbox.Text = row.Cells[0].Value.ToString();
			Description_Textbox.Text = row.Cells[1].Value.ToString();
			Price_Textbox.Text = row.Cells[2].Value.ToString();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			HiddenId_Textbox.Clear();
			Description_Textbox.Clear();
			Price_Textbox.Clear();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			var itemId = string.IsNullOrEmpty(HiddenId_Textbox.Text) ? 0 : Convert.ToInt32(HiddenId_Textbox.Text);

			if (itemId > 0)
			{
				var isSuccessful = SaveItem(new ItemModel
				{
					Id = Convert.ToInt32(HiddenId_Textbox.Text),
					Description = Description_Textbox.Text,
					Price = Convert.ToDecimal(Price_Textbox.Text)
				});

				if (isSuccessful)
				{
					MessageBox.Show(" Item has been successfully saved.");
					LoadItemGrid();
				}
			}
			else
				MessageBox.Show(" No Selected Item (Double click on item)."
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			var itemId = string.IsNullOrEmpty(HiddenId_Textbox.Text) ? 0 : Convert.ToInt32(HiddenId_Textbox.Text);

			if (itemId > 0)
			{
				var isSuccessful = DeleteItem(itemId);

				if (isSuccessful)
				{
					MessageBox.Show(" Item has been successfully deleted.");
					LoadItemGrid();
					Cancel_Click(this, new EventArgs());
				}
					
			}
			else
				MessageBox.Show(" No Selected Item (Double click on item)."
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
		}

		#endregion

		#region Private Methods

		private void LoadItemGrid()
		{
			var itemService = new ItemService();
			var bindingSource = new BindingSource();

			var items = itemService.GetItems();
			bindingSource.DataSource = items;
			ItemGrid.DataSource = bindingSource;
		}

		private bool SaveItem(ItemModel item)
		{
			var itemService = new ItemService();
			var isSuccessful = itemService.SaveItem(item);

			return isSuccessful;
		}

		private List<ItemModel> SearchItem(string description)
		{
			var itemService = new ItemService();
			var items = itemService.SearchItem(description);

			return items;
		}

		private bool DeleteItem(int itemId)
		{
			var itemService = new ItemService();
			var isSuccessful = itemService.DeleteItem(new ItemModel { Id = itemId });

			return isSuccessful;
		}

		#endregion
	}
}
