using CopyLane.Models;
using CopyLane.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyLane.CustomControls.Contents
{
    public partial class SalesPanel : UserControl
    {
        public SalesPanel()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void SalesTodayBtn_Click(object sender, EventArgs e)
        {
            LoadTransactionGrid(null, null);
        }

        private void SalesDateBtn_Click(object sender, EventArgs e)
        {
            LoadTransactionGrid(null, null);
        }

        private void LoadTransactionGrid(DateTime? from, DateTime? to)
        {
            var transactions = new List<TransactionModel>();
            var salesService = new SalesService();

            if (from.HasValue && to.HasValue)
            {
                transactions = salesService.GetTransactionByDate(from, to);
            }
            else
            {
                transactions = salesService.GetTransactionToday();
            }

            dataGridView1.Rows.Clear();
            foreach (var transact in transactions)
            {
                dataGridView1.Rows.Add(transact.Id
                    , transact.TransactionDetailsId
                    , transact.Username
                    , transact.Payment
                    , transact.Change
                    , transact.Subtotal
                    , transact.Date);
            }
        }
    }
}
