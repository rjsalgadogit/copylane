using CopyLane.CustomControls.PartialViews;
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
		public POSPanel()
		{
			InitializeComponent();

			this.Dock = DockStyle.Fill;
		}

		private void POSPanel_Load(object sender, EventArgs e)
		{
			Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Yellow };


			for (int i = 0; i < colors.Length; i++)
			{
				//flowLayoutPanel1.Controls.Add(new ProductButton(colors[i]));
			}
		}

		private void F1_Click(object sender, EventArgs e)
		{
			panel1.Controls.Add(new ProductPreview());
		}

		private void F2_Click(object sender, EventArgs e)
		{

		}

		private void F3_Click(object sender, EventArgs e)
		{

		}

		private void F4_Click(object sender, EventArgs e)
		{

		}
	}
}
