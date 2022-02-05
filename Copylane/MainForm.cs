using Copylane.CustomControls;
using Copylane.Model;
using Copylane.Model.Global;
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

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					F1_Click(this, new EventArgs());
					break;

				case Keys.F2:
					F2_Click(this, new EventArgs());
					break;

				case Keys.F3:
					F3_Click(this, new EventArgs());
					break;

				case Keys.F4:
					F4_Click(this, new EventArgs());
					break;
			}
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
						Price = Convert.ToDecimal(Price_Textbox.Text),
						ShortcutKey = KeysCombo.Text
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

		private void Save_Click(object sender, EventArgs e)
		{
			var itemId = string.IsNullOrEmpty(HiddenId_Textbox.Text) ? 0 : Convert.ToInt32(HiddenId_Textbox.Text);

			if (itemId > 0)
			{
				var isSuccessful = SaveItem(new ItemModel
				{
					Id = Convert.ToInt32(HiddenId_Textbox.Text),
					Description = Description_Textbox.Text,
					Price = Convert.ToDecimal(Price_Textbox.Text),
					ShortcutKey = KeysCombo.Text
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

		private void Cancel_Click(object sender, EventArgs e)
		{
			HiddenId_Textbox.Clear();
			Description_Textbox.Clear();
			Price_Textbox.Clear();
			KeysCombo.Text = "";
		}

		private void Search_Click(object sender, EventArgs e)
		{
			var bindingSource = new BindingSource();

			bindingSource.DataSource = SearchItem(SearchTextbox.Text);
			ItemGrid.DataSource = bindingSource;
		}

		private void ItemGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow row = ItemGrid.Rows[e.RowIndex];

			HiddenId_Textbox.Text = row.Cells[0].Value.ToString();
			Description_Textbox.Text = row.Cells[1].Value.ToString();
			Price_Textbox.Text = row.Cells[2].Value.ToString();
		}

		private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
		{
			Search_Click(this, new EventArgs());
		}

		private void F1_Click(object sender, EventArgs e)
		{
			var itemService = new ItemService();
			var item = itemService.GetItemByKey(new ItemModel { ShortcutKey = "F1" });

			GlobalVariable.POSList.Add(item);
			ItemListPanel.Controls.Add(new ItemPreview(item));
		}

		private void F2_Click(object sender, EventArgs e)
		{
			var itemService = new ItemService();
			var item = itemService.GetItemByKey(new ItemModel { ShortcutKey = "F2" });

			GlobalVariable.POSList.Add(item);
			ItemListPanel.Controls.Add(new ItemPreview(item));
		}

		private void F3_Click(object sender, EventArgs e)
		{
			var itemService = new ItemService();
			var item = itemService.GetItemByKey(new ItemModel { ShortcutKey = "F3" });

			GlobalVariable.POSList.Add(item);
			ItemListPanel.Controls.Add(new ItemPreview(item));
		}

		private void F4_Click(object sender, EventArgs e)
		{
			var itemService = new ItemService();
			var item = itemService.GetItemByKey(new ItemModel { ShortcutKey = "F4" });

			GlobalVariable.POSList.Add(item);
			ItemListPanel.Controls.Add(new ItemPreview(item));
		}

		private void ChargePanel_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Paid");
		}

		private void POSButton_Click(object sender, EventArgs e)
		{
			POSPanel.Visible = true;
			ItemsPanel.Visible = false;
		}

		private void ItemButton_Click(object sender, EventArgs e)
		{
			POSPanel.Visible = false;
			ItemsPanel.Visible = true;
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
