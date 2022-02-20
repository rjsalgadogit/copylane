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
		private POSPanel _posPanel;
		private bool mouseDown;
		private Point lastLocation;

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
			_posPanel = new POSPanel();

			panel3.Controls.Clear();
			panel3.Controls.Add(_posPanel);
		}

		private void ProductsButton_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Controls.Add(new SalesPanel());
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			//NOTE: set KeyPreview = True

			if (e.Control)
            {
				if (e.Control && e.KeyCode == Keys.Enter)
				{
					_posPanel.SubtotalView.SubtotalPerformClick();
					return;
				}
				else if (e.Control && e.KeyCode == Keys.S)
				{
					_posPanel.Search.PerformClick();
					return;
				}
			}
            else
            {
				switch (e.KeyCode)
				{
					case Keys.F1:
						_posPanel.KeyAction(Keys.F1);
						break;

					case Keys.F2:
						_posPanel.KeyAction(Keys.F2);
						break;

					case Keys.F3:
						_posPanel.KeyAction(Keys.F3);
						break;

					case Keys.F4:
						_posPanel.KeyAction(Keys.F4);
						break;

					case Keys.Enter:
						_posPanel.SubtotalView.SubtotalPerformClick();
						break;

					case Keys.Escape:
						if (_posPanel.panel3.Controls.Count > 0)
						{
							var result = MessageBox.Show(" Do you want to clear Transactions?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

							if (result == DialogResult.Yes)
							{
								_posPanel.ClearTransaction();
							}
						}
						break;
				}
			}
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Process.GetCurrentProcess().Kill();
		}

        private void MaxMinForm_Click(object sender, EventArgs e)
        {
			OnResizeUI();

		}

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			OnResizeUI();
		}

        private void MinButton_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
			panel3.Controls.Clear();
			panel3.Controls.Add(new ProductPanel());
		}

		private void OnResizeUI()
        {
			if (this.WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Maximized;
				this.MaxMinForm.Image = Properties.Resources.copy_12;

				_posPanel.panel3.Height = 718;
				panel2.Width = 300;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
				this.MaxMinForm.Image = Properties.Resources.stop_12;

				_posPanel.panel3.Height = 617;
				panel2.Width = 248;
			}
		}
    }
}
