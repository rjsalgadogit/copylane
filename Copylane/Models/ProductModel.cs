using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyLane.Models
{
	public class ProductModel
	{
		public int Id { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public decimal Total { get; set; }

		public int Qty { get; set; }

		public bool IsFromPopup { get; set; }

		[DisplayName("Shortcut Key")]
		public string ShortcutKey { get; set; }

		[DisplayName("Created Date")]
		public DateTime? CreatedDate { get; set; }

		[DisplayName("Modified Date")]
		public DateTime? ModifiedDate { get; set; }
	}
}
