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

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadItemGrid();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			SaveItem(new ItemModel
			{
				Description = Description_Textbox.Text,
				Price = Convert.ToDecimal(Price_Textbox.Text)
			});
		}

		#region Private Methods

		private void LoadItemGrid()
		{
			var itemService = new ItemService();
			var bindingSource = new BindingSource();
			var items = itemService.GetItems();

			bindingSource.DataSource = items;
			Item_Grid.DataSource = bindingSource;
		}

		private void SaveItem(ItemModel item)
		{
			var itemService = new ItemService();
			var isSuccessful = itemService.SaveItem(item);

			if (isSuccessful)
			{
				MessageBox.Show("The data has been successfully saved.");
				LoadItemGrid();
			}
		}

		#endregion
	}
}
