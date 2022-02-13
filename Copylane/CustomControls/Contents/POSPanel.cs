using CopyLane.CustomControls.PartialViews;
using CopyLane.CustomForms.Popups;
using CopyLane.Models;
using CopyLane.Models.Global;
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
		public SubtotalView SubtotalView;

		public POSPanel()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}

		#region Events

		private void POSPanel_Load(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var subtotalView = new SubtotalView(this);

			ArrangeButtonUI(productService);

			SubtotalView = subtotalView;
			this.panel1.Controls.Add(subtotalView);
			this.SubtotalView.Select();
		}

		private void F1_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F1" });

			if (product != null)
            {
				product.Qty = 1;
				AddItemToTheList(product);
            }
			else
				MessageBox.Show(" No product available", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void F2_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F2" });

			if (product != null)
			{
				product.Qty = 1;
				AddItemToTheList(product);
			}
			else
				MessageBox.Show(" No product available", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void F3_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F3" });

			if (product != null)
			{
				product.Qty = 1;
				AddItemToTheList(product);
			}
			else
				MessageBox.Show(" No product available", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void F4_Click(object sender, EventArgs e)
		{
			var productService = new ProductService();
			var product = productService.GetProductByKey(new ProductModel { ShortcutKey = "F4" });

			if (product != null)
			{
				product.Qty = 1;
				AddItemToTheList(product);
			}
			else
				MessageBox.Show(" No product available", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void Payment_KeyPress(object sender, KeyPressEventArgs e)
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

		#endregion

		#region Methods

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

		public void KeyAction(Keys key)
		{
			switch (key)
			{
				case Keys.F1:
					F1.PerformClick();
					break;

				case Keys.F2:
					F2.PerformClick();
					break;

				case Keys.F3:
					F3.PerformClick();
					break;

				case Keys.F4:
					F4.PerformClick();
					break;
			}
		}

		public void ComputeSubtotal()
		{
			var subtotal = panel3.Controls.OfType<ProductPreview>().OrderBy(x => x.TabIndex).Sum(x => x._productModel.Total);
			SubtotalView.Subtotal.Text = subtotal.ToString("#,##0.00");

			GlobalVariables.ProductList = new List<ProductModel>();

			foreach (var item in panel3.Controls.OfType<ProductPreview>().OrderBy(x => x.TabIndex))
			{
				GlobalVariables.ProductList.Add(item._productModel);
			}
		}

		public void SaveTransaction(decimal change, decimal payment, decimal subtotal)
		{
			var products = GlobalVariables.ProductList;
			var productService = new ProductService();
			var uniqueId = DateTime.Now.ToString("yy")
				+ DateTime.Now.ToString("MM")
				+ DateTime.Now.ToString("dd")
				+ Guid.NewGuid().ToString().Substring(0, 4);

			var isSuccessful = productService.SaveTransactionDetails(products, uniqueId);

			if (isSuccessful)
			{
				productService.SaveTransaction(uniqueId, change, payment, subtotal);
			}
		}

		private void AddItemToTheList(ProductModel product)
        {
			using (var popup = new ProductDetailsPopup(product))
			{
				var result = popup.ShowDialog();

				if (result == DialogResult.OK)
				{
					this.panel3.Controls.Add(new ProductPreview(popup._productModel, this));
					ComputeSubtotal();
				}
			}
		}

        #endregion

        private void Search_Click(object sender, EventArgs e)
        {

        }
    }
}
