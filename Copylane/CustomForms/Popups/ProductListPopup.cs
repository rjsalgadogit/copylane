using CopyLane.CustomControls.Contents;
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
        private POSPanel _posPanel;
        private bool mouseDown;
        private Point lastLocation;

        public ProductListPopup(POSPanel posPanel)
        {
            InitializeComponent();
            this.SearchProduct.Select();
            this._posPanel = posPanel;

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
                var grid = dataGridView1;

                if (grid.SelectedRows.Count > 0)
                {
                    var productModel = new ProductModel
                    {
                        Id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value.ToString()),
                        Description = grid.SelectedRows[0].Cells["Description"].Value.ToString(),
                        Price = Convert.ToDecimal(grid.SelectedRows[0].Cells["Price"].Value.ToString()),
                        Qty = 1
                    };

                    this._posPanel.AddItemToTheList(productModel);
                }
            }

            //NOTE: SelectedRows[0] because the Grid was restricted to select 1 row only.
        }

        private void SearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var grid = dataGridView1;

                if (grid.SelectedRows.Count > 0)
                {
                    var productModel = new ProductModel
                    {
                        Id = Convert.ToInt32(grid.SelectedRows[0].Cells["ID"].Value.ToString()),
                        Description = grid.SelectedRows[0].Cells["Description"].Value.ToString(),
                        Price = Convert.ToDecimal(grid.SelectedRows[0].Cells["Price"].Value.ToString()),
                        Qty = 1
                    };

                    this._posPanel.AddItemToTheList(productModel);
                }
            }

            //NOTE: SelectedRows[0] because the Grid was restricted to select 1 row only.
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var productModel = new ProductModel
            {
                Id = Convert.ToInt32(row.Cells[0].Value.ToString()),
                Description = row.Cells[1].Value.ToString(),
                Price = Convert.ToDecimal(row.Cells[2].Value.ToString()),
                Qty = 1
            };

            this._posPanel.AddItemToTheList(productModel);
        }
    }
}
