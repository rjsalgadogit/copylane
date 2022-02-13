using CopyLane.CustomControls.PartialViews;
using CopyLane.Models.Global;
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

namespace CopyLane.CustomForms.Popups
{
    public partial class PaymentPopup : Form
    {
        private SubtotalView _subtotalView;
        public string change;
        private bool mouseDown;
        private Point lastLocation;

        public PaymentPopup(SubtotalView subtotalView)
        {
            InitializeComponent();

            _subtotalView = subtotalView;
        }

        private void ChargePopup_Load(object sender, EventArgs e)
        {
            this.Payment.Select();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Process_Click(object sender, EventArgs e)
        {
            var payment = !string.IsNullOrEmpty(Payment.Text) ? Convert.ToDecimal(Payment.Text) : 0;
            var subtotal = !string.IsNullOrEmpty(_subtotalView.Subtotal.Text) ? Convert.ToDecimal(_subtotalView.Subtotal.Text) : 0;
            var totalChange = (subtotal - payment) * -1;  // (* -1) to remove negative

            if (payment > subtotal)
            {
                var isSuccessful = SaveTransaction(totalChange, payment, subtotal);

                if (isSuccessful)
                {
                    change = totalChange.ToString("#,##0.00");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
                MessageBox.Show(" Payment is not enough."
                    , "Warning"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
        }

        private void Payment_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Payment.Text))
            {
                Payment.Text = Convert.ToDecimal(Payment.Text).ToString("#,###.00");
            }
        }

        private void Payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Process.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                this.Cancel.PerformClick();
        }

        private bool SaveTransaction(decimal change, decimal payment, decimal subtotal)
        {
            var productService = new ProductService();

            var products = GlobalVariables.ProductList;
            var uniqueId = DateTime.Now.ToString("yy")
                + DateTime.Now.ToString("MM")
                + DateTime.Now.ToString("dd")
                + Guid.NewGuid().ToString().Substring(0, 4);

            var isSuccessful = productService.SaveTransactionDetails(products, uniqueId);

            if (isSuccessful)
            {
                return productService.SaveTransaction(uniqueId, change, payment, subtotal);
            }
            else
                return false;
        }
    }
}
