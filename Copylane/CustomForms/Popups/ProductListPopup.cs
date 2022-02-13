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

namespace CopyLane.CustomForms.Popups
{
    public partial class ProductListPopup : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ProductListPopup()
        {
            InitializeComponent();
            this.SearchProduct.Select();

            //NOTE: set DataGridView.StandardProperty = True (to disable tabstop on each column)
        }

        private void ProductListPopup_Load(object sender, EventArgs e)
        {
            var productService = new ProductService();
            var products = productService.GetProducts();

            dataGridView1.Rows.Clear();
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Id
                    , product.Description
                    , product.Price);
            }
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SearchProduct_TextChanged(object sender, EventArgs e)
        {
            var productService = new ProductService();
            var products = productService.SearchProduct(new ProductModel { Description = SearchProduct.Text });

            dataGridView1.Rows.Clear();
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Id
                    , product.Description
                    , product.Price);
            }
        }

        private void ProductListPopup_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show("Testing");
            }
        }

        private void SearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Testing");
            }
        }
    }
}
