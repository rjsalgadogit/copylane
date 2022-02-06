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
			this.Price.Text = $"P  {product.Price}";
			this.Qty.Text = product.Qty.ToString();
			this.Total.Text = product.Total.ToString();
			this.Additional.Text = product.Additional.ToString();
			this.Discount.Text = product.Discount.ToString();
			this.Save.Text = "Charge    (P " + (product.Total + product.Additional - product.Discount) + ")";
		}

		private void ProductPreviewPopup_Load(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{
			var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;
			var additional = !string.IsNullOrEmpty(Additional.Text) ? Convert.ToDecimal(Additional.Text) : 0;
			var discount = !string.IsNullOrEmpty(Discount.Text) ? Convert.ToDecimal(Discount.Text) : 0;
			//var subtotal = total + additional - discount;

			Product.Total = total;
			Product.Qty = Convert.ToInt32(Qty.Text);
			Product.Additional = additional;
			Product.Discount = discount;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Qty_TextChanged(object sender, EventArgs e)
		{
			var qty = !string.IsNullOrEmpty(Qty.Text) ? Convert.ToDecimal(Qty.Text) : 0;
			var additional = !string.IsNullOrEmpty(Additional.Text) ? Convert.ToDecimal(Additional.Text) : 0;
			var discount = !string.IsNullOrEmpty(Discount.Text) ? Convert.ToDecimal(Discount.Text) : 0;
			var total = Product.Price * qty;
			var subtotal = total + additional - discount;

			Total.Text = total.ToString();
			Save.Text = $"Charge    (P  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Total_TextChanged(object sender, EventArgs e)
		{
			var additional = !string.IsNullOrEmpty(Additional.Text) ? Convert.ToDecimal(Additional.Text) : 0;
			var discount = !string.IsNullOrEmpty(Discount.Text) ? Convert.ToDecimal(Discount.Text) : 0;
			var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;
			var subtotal = total + additional - discount;

			Save.Text = $"Charge    (P  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Additional_TextChanged(object sender, EventArgs e)
		{
			var additional = !string.IsNullOrEmpty(Additional.Text) ? Convert.ToDecimal(Additional.Text) : 0;
			var discount = !string.IsNullOrEmpty(Discount.Text) ? Convert.ToDecimal(Discount.Text) : 0;
			var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;
			var subtotal = total + additional - discount;

			Save.Text = $"Charge    (P  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Discount_TextChanged(object sender, EventArgs e)
		{
			var additional = !string.IsNullOrEmpty(Additional.Text) ? Convert.ToDecimal(Additional.Text) : 0;
			var discount = !string.IsNullOrEmpty(Discount.Text) ? Convert.ToDecimal(Discount.Text) : 0;
			var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;
			var subtotal = total + additional - discount;

			Save.Text = $"Charge    (P  " + subtotal.ToString("#,##0.00") + ")";
		}

		private void Qty_KeyPress(object sender, KeyPressEventArgs e)
		{
			AllowNumbersAndOneDecimalOnly(sender, e);
		}

		private void Total_KeyPress(object sender, KeyPressEventArgs e)
		{
			AllowNumbersAndOneDecimalOnly(sender, e);
		}

		private void Additional_KeyPress(object sender, KeyPressEventArgs e)
		{
			AllowNumbersAndOneDecimalOnly(sender, e);
		}

		private void Discount_KeyPress(object sender, KeyPressEventArgs e)
		{
			AllowNumbersAndOneDecimalOnly(sender, e);
		}

		private void AllowNumbersAndOneDecimalOnly(object sender, KeyPressEventArgs e)
		{
			// only allow numbers
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
	}
}
