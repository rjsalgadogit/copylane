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
		public ProductModel Product { get; set; }

		public ProductPreviewPopup(ProductModel product)
		{
			InitializeComponent();
			Product = product;

			this.Description.Text = product.Description;
			this.Price.Text = product.Price.ToString();
			this.Qty.Value = 1;
			this.Total.Value = product.Price;
			this.Save.Text = "Charge    (P " + product.Price + ")";
		}

		private void ProductPreviewPopup_Load(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{
			var subtotal = Total.Value + Additional.Value - Discount.Value;

			Product.Total = subtotal;
			Product.Qty = Convert.ToInt32(Qty.Value);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Qty_KeyUp(object sender, KeyEventArgs e)
		{
			var total = Product.Price * Qty.Value;
			var subtotal = total + Additional.Value - Discount.Value;

			Total.Value = total;
			Save.Text = $"Charge    (₱  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Additional_KeyUp(object sender, KeyEventArgs e)
		{
			var subtotal = Total.Value + Additional.Value - Discount.Value;
			Save.Text = $"Charge    (₱  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Discount_KeyUp(object sender, KeyEventArgs e)
		{
			var subtotal = Total.Value + Additional.Value - Discount.Value;
			Save.Text = $"Charge    (₱  " + subtotal.ToString("#,##0.00") + ")";
		}
	}
}
