using CopyLane.CustomControls.Contents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane
{
	public partial class MainForm : Form
	{
		private bool mouseDown;
		private Point lastLocation;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(new POSPanel());
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			lastLocation = e.Location;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				this.Location = new Point(
					(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void POSButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(new POSPanel());
		}

		private void ProductsButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(new ProductPanel());
		}
	}
}
