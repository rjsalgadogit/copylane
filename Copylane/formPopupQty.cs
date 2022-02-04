using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copylane
{
	public partial class formPopupQty : Form
	{
		public formPopupQty()
		{
			InitializeComponent();
		}

		private void formPopupQty_Load(object sender, EventArgs e)
		{
			numericUpDown1.Focus();
		}
	}
}
