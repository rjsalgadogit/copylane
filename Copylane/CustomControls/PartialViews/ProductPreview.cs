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
		public POSPanel _posPanel;
		public ProductModel _productModel;

		public ProductPreview(ProductModel productModel, POSPanel posPanel)
		{
			InitializeComponent();

			this.Dock = DockStyle.Top;
			this.TabIndex = 5;
			this.Select();
			
			_posPanel = posPanel;
			_productModel = productModel;
			_productModel.Total = productModel.Price;

			Updatevalues(_productModel);
			SetAllControlsOnSameClickEvent();
		}

		private void ProductPreview_DoubleClick(object sender, EventArgs e)
		{
			using (var popup = new ProductDetailsPopup(_productModel))
            {
				var result = popup.ShowDialog();

				if (result == DialogResult.OK)
                {
					Updatevalues(popup._productModel);
					_posPanel.ComputeSubtotal();
                }
            }
		}

		private void Updatevalues(ProductModel productModel)
		{
			this.label1.Text = productModel.Description;
			this.label2.Text = $"x {productModel.Qty}";
			this.label3.Text = (productModel.Total + productModel.Additional - productModel.Discount).ToString("#,##0.00");

			_productModel.Qty = _productModel.Qty;
			_productModel.Total = _productModel.Total;
		}

		private void SetAllControlsOnSameClickEvent()
        {
			//this.DoubleClick += new EventHandler(ProductPreview_DoubleClick);

			// loop all controls inside of each panels
			// and set click event
			foreach (var control in this.Controls.OfType<Control>().OrderBy(x => x.TabIndex))
			{
				foreach (var subControl in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))
				{
					subControl.DoubleClick += new EventHandler(ProductPreview_DoubleClick);
				}

				control.DoubleClick += new EventHandler(ProductPreview_DoubleClick);
			}
		}

        private void Remove_Click(object sender, EventArgs e)
        {
			_posPanel.panel3.Controls.Remove(this);
        }
    }
}
