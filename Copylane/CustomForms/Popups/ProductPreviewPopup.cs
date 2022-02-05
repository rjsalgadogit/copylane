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

namespace CopyLane.CustomForms.Popups
{
	public partial class ProductPreviewPopup : Form
	{
		private ProductModel Product { get; set; }

		public ProductPreviewPopup(ProductModel product)
		{
			InitializeComponent();
			Product = product;

			this.Description.Text = product.Description;
			this.Price.Text = product.Price.ToString();
			this.Qty.Value = 1;
			this.Total.Value = product.Price;
		}

		private void ProductPreviewPopup_Load(object sender, EventArgs e)
		{

		}
	}
}
