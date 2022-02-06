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
		public SubtotalView()
		{
			InitializeComponent();

			this.Dock = DockStyle.Bottom;

			SetAllControlsOnSameClickEvent();
		}

		private void Subtotal_Click(object sender, EventArgs e)
		{
			using (var popup = new PaymentPopup())
			{
				var result = popup.ShowDialog();

				if (result == DialogResult.OK)
				{

				}
			}
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
