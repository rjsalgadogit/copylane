
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
			this.label5 = new System.Windows.Forms.Label();
			this.Price = new System.Windows.Forms.Label();
			this.Save = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Qty = new System.Windows.Forms.TextBox();
			this.Total = new System.Windows.Forms.TextBox();
			this.Additional = new System.Windows.Forms.TextBox();
			this.Discount = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Description
			// 
			this.Description.AutoSize = true;
			this.Description.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Description.Location = new System.Drawing.Point(17, 9);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(110, 26);
			this.Description.TabIndex = 0;
			this.Description.Text = "Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Qty.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Additional";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Price";
			// 
			// Price
			// 
			this.Price.AutoSize = true;
			this.Price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price.Location = new System.Drawing.Point(110, 66);
			this.Price.Name = "Price";
			this.Price.Size = new System.Drawing.Size(43, 19);
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
			this.Save.Location = new System.Drawing.Point(0, 300);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(452, 44);
			this.Save.TabIndex = 9;
			this.Save.Text = "Enter";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Discount";
			// 
			// Qty
			// 
			this.Qty.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Qty.Location = new System.Drawing.Point(113, 98);
			this.Qty.Name = "Qty";
			this.Qty.Size = new System.Drawing.Size(128, 26);
			this.Qty.TabIndex = 12;
			this.Qty.TextChanged += new System.EventHandler(this.Qty_TextChanged);
			this.Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_KeyPress);
			// 
			// Total
			// 
			this.Total.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Total.Location = new System.Drawing.Point(113, 137);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(128, 26);
			this.Total.TabIndex = 13;
			this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
			this.Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
			// 
			// Additional
			// 
			this.Additional.Location = new System.Drawing.Point(124, 27);
			this.Additional.Name = "Additional";
			this.Additional.Size = new System.Drawing.Size(128, 26);
			this.Additional.TabIndex = 14;
			this.Additional.TextChanged += new System.EventHandler(this.Additional_TextChanged);
			this.Additional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Additional_KeyPress);
			// 
			// Discount
			// 
			this.Discount.Location = new System.Drawing.Point(124, 67);
			this.Discount.Name = "Discount";
			this.Discount.Size = new System.Drawing.Size(128, 26);
			this.Discount.TabIndex = 15;
			this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
			this.Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Discount);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Additional);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 181);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(428, 111);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.Description);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 46);
			this.panel1.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label6.Location = new System.Drawing.Point(0, 43);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(452, 3);
			this.label6.TabIndex = 5;
			// 
			// ProductPreviewPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(452, 344);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.Qty);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Price);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductPreviewPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Product Details";
			this.Load += new System.EventHandler(this.ProductPreviewPopup_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Price;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Qty;
		private System.Windows.Forms.TextBox Total;
		private System.Windows.Forms.TextBox Additional;
		private System.Windows.Forms.TextBox Discount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
	}
}