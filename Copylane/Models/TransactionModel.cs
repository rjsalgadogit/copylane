using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyLane.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }

        public string TransactionDetailsId { get; set; }

        public string Username { get; set; }

        public decimal Payment { get; set; }

        public decimal Change { get; set; }

        public decimal Subtotal { get; set; }

        public DateTime Date { get; set; }
    }
}
