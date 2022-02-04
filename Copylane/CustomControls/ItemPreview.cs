using Copylane.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copylane.CustomControls
{
	public partial class ItemPreview : UserControl
	{
		public ItemPreview(ItemModel item)
		{
			InitializeComponent();

			this.label1.Text = item.Description;
			this.Dock = DockStyle.Top;
		}

		private void ItemPreview_DoubleClick(object sender, EventArgs e)
		{
			var popup = new formPopupQty();
			popup.ShowDialog();
		}
	}
}
