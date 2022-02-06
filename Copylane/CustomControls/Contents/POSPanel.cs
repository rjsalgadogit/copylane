using CopyLane.CustomControls.PartialViews;
using CopyLane.Models;
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
	public partial class POSPanel : UserControl
	{
		public POSPanel()
		{
			InitializeComponent();

			this.Dock = DockStyle.Fill;
		}

		#region Control Events

		private void POSPanel_Load(object sender, EventArgs e)
		{
			var productService = new ProductService();

			ArrangeButtonUI(productService);
		}

		private void F1_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F1" });

			if (product != null)
			{
				product.Qty = 1;
				panel1.Controls.Add(new ProductPreview(product));
			}
		}

		private void F2_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F2" });

			if (product != null)
			{
				product.Qty = 1;
				panel1.Controls.Add(new ProductPreview(product));
			}
		}

		private void F3_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F3" });

			if (product != null)
			{
				product.Qty = 1;
				panel1.Controls.Add(new ProductPreview(product));
			}
		}

		private void F4_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F4" });

			if (product != null)
			{
				product.Qty = 1;
				panel1.Controls.Add(new ProductPreview(product));
			}
		}

		#endregion

		#region Private Methods

		private void ArrangeButtonUI(ProductService productService)
		{
			var products = productService.GetProducts();

			foreach (var product in products)
			{
				switch (product.ShortcutKey)
				{
					case "F1":
						F1.Text = product.Description;
						break;

					case "F2":
						F2.Text = product.Description;
						break;

					case "F3":
						F3.Text = product.Description;
						break;

					case "F4":
						F4.Text = product.Description;
						break;
				}
			}
		}

		#endregion
	}
}
