using CopyLane.CustomControls.Contents;
using CopyLane.CustomControls.PartialViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
		private POSPanel posPanel;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			POSButton.PerformClick();
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
			posPanel = new POSPanel();

			panel3.Controls.Clear();
			panel3.Controls.Add(posPanel);
		}

		private void ProductsButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(new ProductPanel());
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			//NOTE: set KeyPreview = True

			switch (e.KeyCode)
			{
				case Keys.F1:
					posPanel.KeyAction(Keys.F1);
					break;

				case Keys.F2:
					posPanel.KeyAction(Keys.F2);
					break;

				case Keys.F3:
					posPanel.KeyAction(Keys.F3);
					break;

				case Keys.F4:
					posPanel.KeyAction(Keys.F4);
					break;

				case Keys.Enter:
                    posPanel.SubtotalView.SubtotalPerformClick();
					break;
			}
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Process.GetCurrentProcess().Kill();
		}
    }
}
