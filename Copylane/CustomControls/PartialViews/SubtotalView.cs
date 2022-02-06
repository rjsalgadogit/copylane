using CopyLane.CustomControls.Contents;
using CopyLane.CustomForms.Popups;
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
		private POSPanel PosPanel;

		public SubtotalView(POSPanel posPanel)
		{
			InitializeComponent();

			this.Dock = DockStyle.Bottom;
			this.PosPanel = posPanel;

			SetAllControlsOnSameClickEvent();
		}

		private void Subtotal_Click(object sender, EventArgs e)
		{
			if (Convert.ToDecimal(PosPanel.Payment.Text) > Convert.ToDecimal(Subtotal.Text))
			{
				var change = (Convert.ToDecimal(Subtotal.Text) - Convert.ToDecimal(PosPanel.Payment.Text)) * -1;

				using (var popup = new PaymentPopup(change))
				{
					var result = popup.ShowDialog();

					if (result == DialogResult.OK)
					{

					}
				}
			}
			else
				MessageBox.Show("Payment is not enough"
					, "Error"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Error);
		}

		public void SubtotalPerformClick()
		{
			this.Subtotal_Click(this, new EventArgs());
		}

		private void SetAllControlsOnSameClickEvent()
		{
			this.Click += new EventHandler(Subtotal_Click);

			// loop all controls inside of each panels
			// and set click event
			foreach (var control in this.Controls.OfType<Control>().OrderBy(x => x.TabIndex))
			{
				foreach (var subControl in control.Controls.OfType<Control>().OrderBy(x => x.TabIndex))
				{
					subControl.Click += new EventHandler(Subtotal_Click);
				}

				control.Click += new EventHandler(Subtotal_Click);
			}
		}
	}
}
