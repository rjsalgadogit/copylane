using CopyLane.CustomForms.Popups;
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
            LoadTransactionGrid(null, null);

            this.label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void SalesTodayBtn_Click(object sender, EventArgs e)
        {
            LoadTransactionGrid(null, null);
        }

        private void SalesDateBtn_Click(object sender, EventArgs e)
        {
            using (var popup = new SalesDatePopup())
            {
                var result = popup.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadTransactionGrid(popup.dateTimePicker1.Value, popup.dateTimePicker2.Value);
                }
            }
        }

        private void LoadTransactionGrid(DateTime? from, DateTime? to)
        {
            var transactions = new List<TransactionModel>();
            var salesService = new SalesService();
            decimal totalSales = 0;

            if (from.HasValue && to.HasValue)
            {
                transactions = salesService.GetTransactionByDate(from, to);
                this.label1.Text = $"{from.Value.ToString("dddd, dd MMMM yyyy")}  -  {to.Value.ToString("dddd, dd MMMM yyyy")}";
            }
            else
            {
                transactions = salesService.GetTransactionToday();
                this.label1.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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

                totalSales = totalSales + transact.Subtotal;
            }

            this.label4.Text = totalSales.ToString();
        }
    }
}
