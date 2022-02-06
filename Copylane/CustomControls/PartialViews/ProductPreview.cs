using CopyLane.CustomControls.Contents;
using CopyLane.CustomForms.Popups;
using CopyLane.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane.CustomControls.PartialViews
{
	public partial class ProductPreview : UserControl
	{
		public POSPanel PosPanel { get; set; }
		public ProductModel Product { get; set; }

		public ProductPreview(ProductModel product, POSPanel posPanel)
		{
			InitializeComponent();

			this.Dock = DockStyle.Top;

			Product = product;
			Product.Total = product.Price;
			PosPanel = posPanel;

			Updatevalues(product);
		}

		private void ProductPreview_DoubleClick(object sender, EventArgs e)
		{
			using (var formPopup = new ProductPreviewPopup(Product))
			{
				var result = formPopup.ShowDialog();
				if (result == DialogResult.OK)
				{
					Updatevalues(formPopup.Product);
					PosPanel.ComputeSubtotal();
				}
			}
		}

		private void Updatevalues(ProductModel product)
		{
			this.label1.Text = product.Description;
			this.label2.Text = $"x {product.Qty}";
			this.label3.Text = product.Total.ToString("#,##0.00");
		}
	}
}
