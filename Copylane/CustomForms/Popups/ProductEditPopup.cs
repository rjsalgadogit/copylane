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
    public partial class ProductEditPopup : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public ProductEditPopup(ProductPanel posPanel)
        {
            InitializeComponent();
        }

        private void ProductEditPopup_Load(object sender, EventArgs e)
        {
            //var grid = PosPanel.dataGridView1;

            //if (grid.SelectedRows.Count > 0)
            //{
            //    HiddenID.Text = grid.SelectedRows[0].Cells["id"].Value.ToString();
            //    Description.Text = grid.SelectedRows[0].Cells["Description"].Value.ToString();
            //    Price.Text = grid.SelectedRows[0].Cells["Price"].Value.ToString();
            //    ShortcutKey.Text = grid.SelectedRows[0].Cells["ShortcutKey"].Value.ToString();
            //}
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var productService = new ProductService();

            if (!string.IsNullOrEmpty(Description.Text))
            {
                var itemId = string.IsNullOrEmpty(HiddenID.Text) ? 0 : Convert.ToInt32(HiddenID.Text);

                var isSuccessful = productService.SaveProduct(new ProductModel
                {
                    Id = itemId,
                    Description = Description.Text,
                    Price = Convert.ToDecimal(Price.Text),
                    ShortcutKey = ShortcutKey.Text
                });
                

                if (isSuccessful)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show(" An error encountered while saving."
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(" Description missing!"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
}
