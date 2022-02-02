using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copylane.Model.Global
{
	public static class GlobalVariable
	{
		public static List<ItemModel> POSList { get; set; } = new List<ItemModel>();

		public static List<UserControl> ItemList { get; set; } = new List<UserControl>();
	}
}
