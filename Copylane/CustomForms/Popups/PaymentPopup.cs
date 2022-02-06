using CopyLane.CustomControls.Contents;
using CopyLane.Models.Global;
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
	public partial class PaymentPopup : Form
	{
		private bool mouseDown;
		private Point lastLocation;
		private decimal Payment;
		private decimal Subtotal;
		private POSPanel PosPanel;

		public PaymentPopup(POSPanel posPanel, decimal change, decimal payment, decimal subtotal)
		{
			InitializeComponent();

			this.Change.Text = change.ToString("#,##0.00");
			this.Payment = payment;
			this.Subtotal = subtotal;
			this.PosPanel = posPanel;
		}

		private void PaymentPopup_Load(object sender, EventArgs e)
		{
			Process.Focus();
		}

		private void Process_Click(object sender, EventArgs e)
		{
			var change = Convert.ToDecimal(Change.Text);

			PosPanel.SaveTransaction(change, this.Payment, this.Subtotal);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
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
	}
}
