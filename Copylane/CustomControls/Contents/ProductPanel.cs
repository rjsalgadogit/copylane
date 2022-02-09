using CopyLane.CustomForms.Popups;
using CopyLane.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane.CustomControls.Contents
{
	public partial class ProductPanel : UserControl
	{
		public ProductPanel()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

        private void ProductPanel_Load(object sender, EventArgs e)
        {
			LoadItemGrid();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			using (var popup = new ProductEditPopup(this))
            {
				var result = popup.ShowDialog();
				if (result == DialogResult.OK)
                {

                }
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			var grid = dataGridView1;

			if (grid.SelectedRows.Count > 0)
            {
				using (var popup = new ProductEditPopup(this))
				{
					popup.HiddenID.Text = grid.SelectedRows[0].Cells["id"].Value.ToString();
					popup.Description.Text = grid.SelectedRows[0].Cells["Description"].Value.ToString();
					popup.Price.Text = grid.SelectedRows[0].Cells["Price"].Value.ToString();
					popup.ShortcutKey.Text = grid.SelectedRows[0].Cells["ShortcutKey"].Value.ToString();

                    var result = popup.ShowDialog();

					if (result == DialogResult.OK)
					{

					}
				}
			}
		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

			using (var popup = new ProductEditPopup(this))
            {
				popup.HiddenID.Text = row.Cells[0].Value.ToString();
				popup.Description.Text = row.Cells[1].Value.ToString();
				popup.Price.Text = row.Cells[2].Value.ToString();
				popup.ShortcutKey.Text = row.Cells[3].Value.ToString();

				var result = popup.ShowDialog();

				if (result == DialogResult.OK)
                {
					LoadItemGrid();
                }
            }
        }

		private void LoadItemGrid()
		{
			var productService = new ProductService();
			var products = productService.GetProducts();

			dataGridView1.Rows.Clear();
			foreach (var product in products)
			{
				dataGridView1.Rows.Add(product.Id
					, product.Description
					, product.Price
					, product.ShortcutKey
					, product.CreatedDate
					, product.ModifiedDate);
			}
		}
	}
}
