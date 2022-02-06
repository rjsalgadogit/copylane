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
	public partial class SubtotalView : UserControl
	{
		public SubtotalView()
		{
			InitializeComponent();
			this.Dock = DockStyle.Bottom;
		}

		private void SubtotalView_Click(object sender, EventArgs e)
		{
			MessageBox.Show("PAID"); 
		}

		private void Subtotal_Click(object sender, EventArgs e)
		{
			MessageBox.Show("PAID");
		}

		private void label2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("PAID");
		}

		private void label1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("PAID");
		}
	}
}
