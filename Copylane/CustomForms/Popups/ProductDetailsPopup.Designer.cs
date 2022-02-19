
namespace CopyLane.CustomForms.Popups
{
    partial class ProductDetailsPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Charge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 30);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.DarkGray;
            this.Cancel.Image = global::CopyLane.Properties.Resources.cross_12;
            this.Cancel.Location = new System.Drawing.Point(437, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(39, 30);
            this.Cancel.TabIndex = 5;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Description.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(14, 46);
            this.Description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Description.Name = "Description";
            this.Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Description.Size = new System.Drawing.Size(154, 36);
            this.Description.TabIndex = 10;
            this.Description.Text = "Description";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.DarkOrange;
            this.Price.Location = new System.Drawing.Point(17, 82);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(89, 19);
            this.Price.TabIndex = 10;
            this.Price.Text = "PHP  101.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity:";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(160, 166);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(59, 31);
            this.Quantity.TabIndex = 1;
            this.Quantity.Text = "101";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            this.Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quantity_KeyDown);
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(160, 125);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(144, 31);
            this.Total.TabIndex = 0;
            this.Total.Text = "101.00";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.TextChanged += new System.EventHandler(this.TotalAmount_TextChanged);
            this.Total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Total_KeyDown);
            this.Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(312, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total:";
            // 
            // Charge
            // 
            this.Charge.BackColor = System.Drawing.Color.ForestGreen;
            this.Charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Charge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Charge.FlatAppearance.BorderSize = 0;
            this.Charge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Charge.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charge.ForeColor = System.Drawing.Color.White;
            this.Charge.Location = new System.Drawing.Point(0, 222);
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(476, 39);
            this.Charge.TabIndex = 4;
            this.Charge.Text = "Charge";
            this.Charge.UseVisualStyleBackColor = false;
            this.Charge.Click += new System.EventHandler(this.Charge_Click);
            // 
            // ProductDetailsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.Charge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDetailsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductDetailsPopup";
            this.Load += new System.EventHandler(this.ProductDetailsPopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductDetailsPopup_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Total;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button Charge;
        public System.Windows.Forms.Button Cancel;
    }
}