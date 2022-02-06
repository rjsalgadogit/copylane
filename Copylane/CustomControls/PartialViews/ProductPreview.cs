using CopyLane.CustomForms.Popups;
using CopyLane.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane.CustomControls.PartialViews
{
	public partial class ProductPreview : UserControl
	{
		public ProductModel Product { get; set; }

		public ProductPreview(ProductModel product)
		{
			InitializeComponent();

			this.Dock = DockStyle.Top;

			Product = product;
			AssignValues(product);
		}

		private void ProductPreview_DoubleClick(object sender, EventArgs e)
		{
			using (var formPopup = new ProductPreviewPopup(Product))
			{
				var result = formPopup.ShowDialog();
				if (result == DialogResult.OK)
				{
					AssignValues(formPopup.Product);
				}
			}
		}

		private void AssignValues(ProductModel product)
		{
			this.label1.Text = product.Description;
			this.label2.Text = $"x {product.Qty}";

			if (product.IsFromPopup)
			{
				this.label3.Text = product.Total.ToString("#,##0.00");
			}
			else
				this.label3.Text = product.Price.ToString("#,##0.00");
		}
	}
}
