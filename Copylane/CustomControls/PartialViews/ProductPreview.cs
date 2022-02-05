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
		public ProductPreview(ProductModel product)
		{
			InitializeComponent();

			this.Dock = DockStyle.Top;
			this.label1.Text = product.Description;
			this.label3.Text = product.Price.ToString();
		}
	}
}
