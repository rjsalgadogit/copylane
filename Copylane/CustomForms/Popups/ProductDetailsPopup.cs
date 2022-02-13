using CopyLane.Models;
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
    public partial class ProductDetailsPopup : Form
    {
        public ProductModel _productModel;
        private bool mouseDown;
        private Point lastLocation;

        public ProductDetailsPopup(ProductModel productModel)
        {
            InitializeComponent();

            this._productModel = productModel;
            this.Description.Text = productModel.Description;
            this.Price.Text = $"PHP   {productModel.Price}";
            this.Total.Text = productModel.Total.ToString("#,##0.00");
            this.Quantity.Text = productModel.Qty.ToString();
            this.Charge.Text = $"Charge  (P  {productModel.Total.ToString("#,##0.00")})";
        }

        private void ProductDetailsPopup_Load(object sender, EventArgs e)
        {
            this.Total.Select();
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

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            var quantity = !string.IsNullOrEmpty(Quantity.Text) ? Convert.ToDecimal(Quantity.Text) : 0;
            var total = _productModel.Price * quantity;

            this.Total.Text = total.ToString("#,##0.00");
            this.Charge.Text = $"Charge  (P  {total.ToString("#,##0.00")})";
        }

        private void TotalAmount_TextChanged(object sender, EventArgs e)
        {
            var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;

            this.Charge.Text = $"Charge  (P  {total.ToString("#,##0.00")})";
        }

        private void Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndOneDecimalOnly(sender, e);
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndOneDecimalOnly(sender, e);
        }

        private void Charge_Click(object sender, EventArgs e)
        {
            var total = !string.IsNullOrEmpty(Total.Text) ? Convert.ToDecimal(Total.Text) : 0;

            _productModel.Total = total;
            _productModel.Qty = Convert.ToInt32(Quantity.Text);     //TODO: restrict Quantity textbox to non-decimal

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Charge.PerformClick();
        }

        private void Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Charge.PerformClick();
        }

        private void AllowNumbersAndOneDecimalOnly(object sender, KeyPressEventArgs e)
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
    }
}
