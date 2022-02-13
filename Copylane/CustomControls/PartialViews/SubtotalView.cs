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
		private POSPanel _posPanel;

		public SubtotalView(POSPanel posPanel)
		{
			InitializeComponent();
			_posPanel = posPanel;

			this.Dock = DockStyle.Bottom;

			SetAllControlsOnSameClickEvent();
		}

		private void Subtotal_Click(object sender, EventArgs e)
		{
            var subtotal = !string.IsNullOrEmpty(Subtotal.Text) ? Convert.ToDecimal(Subtotal.Text) : 0;

			if (subtotal > 0)
            {
				using (var popup = new PaymentPopup(this))
				{
					var result = popup.ShowDialog();
					if (result == DialogResult.OK)
					{
						using (var popup2 = new ChangePopup(popup.change))
						{
							var result2 = popup2.ShowDialog();
							if (result2 == DialogResult.OK)
							{
								Subtotal.Text = "0.00";
								_posPanel.panel3.Controls.Clear();
							}
						}
					}
				}
			}
			else
				MessageBox.Show(" No transaction available."
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
