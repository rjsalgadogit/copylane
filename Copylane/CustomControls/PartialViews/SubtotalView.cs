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
			var payment = !string.IsNullOrEmpty(PosPanel.Payment.Text) ? Convert.ToDecimal(PosPanel.Payment.Text) : 0;
			var subtotal = !string.IsNullOrEmpty(Subtotal.Text) ? Convert.ToDecimal(Subtotal.Text) : 0;

			if (payment > subtotal)
			{
				if (subtotal > 0)
				{
					var change = (subtotal - payment) * -1;     // added (-1) to remove negative

					// pass parameter to another form
					using (var popup = new PaymentPopup(PosPanel, change, payment, subtotal))
					{
						var result = popup.ShowDialog();
						if (result == DialogResult.OK)
						{
							// clear transaction
							Subtotal.Text = "0.00";
							PosPanel.Payment.Clear();
							PosPanel.panel3.Controls.Clear();
						}
					}
				}
				else
					MessageBox.Show(" No transaction available."
						, "Warning"
						, MessageBoxButtons.OK
						, MessageBoxIcon.Warning);
			}
			else
				MessageBox.Show(" Payment is not enough."
					, "Warning"
					, MessageBoxButtons.OK
					, MessageBoxIcon.Warning);
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

		public void SubtotalPerformClick()
		{
			this.Subtotal_Click(this, new EventArgs());
		}
	}
}
