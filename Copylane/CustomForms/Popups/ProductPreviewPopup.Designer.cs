
namespace CopyLane.CustomForms.Popups
{
	partial class ProductPreviewPopup
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
			this.Description = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Qty = new System.Windows.Forms.NumericUpDown();
			this.Total = new System.Windows.Forms.NumericUpDown();
			this.Additional = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.Price = new System.Windows.Forms.Label();
			this.Save = new System.Windows.Forms.Button();
			this.Discount = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Additional)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Discount)).BeginInit();
			this.SuspendLayout();
			// 
			// Description
			// 
			this.Description.AutoSize = true;
			this.Description.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Description.Location = new System.Drawing.Point(17, 21);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(101, 23);
			this.Description.TabIndex = 0;
			this.Description.Text = "Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Qty.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Additional";
			// 
			// Qty
			// 
			this.Qty.Location = new System.Drawing.Point(107, 99);
			this.Qty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.Qty.Name = "Qty";
			this.Qty.Size = new System.Drawing.Size(128, 26);
			this.Qty.TabIndex = 4;
			this.Qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Qty_KeyUp);
			// 
			// Total
			// 
			this.Total.Location = new System.Drawing.Point(107, 138);
			this.Total.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(128, 26);
			this.Total.TabIndex = 5;
			// 
			// Additional
			// 
			this.Additional.Location = new System.Drawing.Point(107, 178);
			this.Additional.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.Additional.Name = "Additional";
			this.Additional.Size = new System.Drawing.Size(128, 26);
			this.Additional.TabIndex = 6;
			this.Additional.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Additional_KeyUp);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Price";
			// 
			// Price
			// 
			this.Price.AutoSize = true;
			this.Price.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price.Location = new System.Drawing.Point(104, 66);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(39, 18);
			this.Price.TabIndex = 8;
			this.Price.Text = "Price";
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.ForestGreen;
			this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Save.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Save.FlatAppearance.BorderSize = 0;
			this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.ForeColor = System.Drawing.Color.White;
			this.Save.Location = new System.Drawing.Point(0, 281);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(377, 44);
			this.Save.TabIndex = 9;
			this.Save.Text = "Enter";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Discount
			// 
			this.Discount.Location = new System.Drawing.Point(107, 218);
			this.Discount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.Discount.Name = "Discount";
			this.Discount.Size = new System.Drawing.Size(128, 26);
			this.Discount.TabIndex = 11;
			this.Discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Discount_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Discount";
			// 
			// ProductPreviewPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(377, 325);
			this.Controls.Add(this.Discount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Additional);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.Qty);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Description);
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductPreviewPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Product Details";
			this.Load += new System.EventHandler(this.ProductPreviewPopup_Load);
			((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Additional)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Discount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown Qty;
		private System.Windows.Forms.NumericUpDown Total;
		private System.Windows.Forms.NumericUpDown Additional;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Price;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.NumericUpDown Discount;
		private System.Windows.Forms.Label label1;
	}
}