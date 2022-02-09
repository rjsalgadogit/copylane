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

		private void LoadItemGrid()
        {
			var productService = new ProductService();
			var products = productService.GetProducts();

			foreach (var product in products)
            {
				dataGridView1.Rows.Add(product.Description
					, product.Price
					, product.ShortcutKey
					, product.CreatedDate
					, product.ModifiedDate);
            }
		}
    }
}
