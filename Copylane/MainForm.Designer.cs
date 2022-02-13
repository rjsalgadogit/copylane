
namespace CopyLane
{
	partial class MainForm
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
            this.MaxMinForm = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.POSButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.MaxMinForm);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 30);
            this.panel1.TabIndex = 150;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MaxMinForm
            // 
            this.MaxMinForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxMinForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxMinForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MaxMinForm.FlatAppearance.BorderSize = 0;
            this.MaxMinForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxMinForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMinForm.ForeColor = System.Drawing.Color.White;
            this.MaxMinForm.Location = new System.Drawing.Point(1226, 0);
            this.MaxMinForm.Name = "MaxMinForm";
            this.MaxMinForm.Size = new System.Drawing.Size(39, 30);
            this.MaxMinForm.TabIndex = 105;
            this.MaxMinForm.Text = "[ ]";
            this.MaxMinForm.UseVisualStyleBackColor = true;
            this.MaxMinForm.Click += new System.EventHandler(this.MaxMinForm_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1265, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(39, 30);
            this.ExitButton.TabIndex = 104;
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.SalesButton);
            this.panel2.Controls.Add(this.ProductsButton);
            this.panel2.Controls.Add(this.POSButton);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 718);
            this.panel2.TabIndex = 150;
            // 
            // SalesButton
            // 
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesButton.FlatAppearance.BorderSize = 0;
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Location = new System.Drawing.Point(0, 256);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(248, 44);
            this.SalesButton.TabIndex = 103;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            this.ProductsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsButton.FlatAppearance.BorderSize = 0;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.Color.White;
            this.ProductsButton.Location = new System.Drawing.Point(0, 212);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(248, 44);
            this.ProductsButton.TabIndex = 102;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // POSButton
            // 
            this.POSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.POSButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.POSButton.FlatAppearance.BorderSize = 0;
            this.POSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POSButton.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSButton.ForeColor = System.Drawing.Color.White;
            this.POSButton.Location = new System.Drawing.Point(0, 168);
            this.POSButton.Name = "POSButton";
            this.POSButton.Size = new System.Drawing.Size(248, 44);
            this.POSButton.TabIndex = 101;
            this.POSButton.Text = "Point of Sale";
            this.POSButton.UseVisualStyleBackColor = true;
            this.POSButton.Click += new System.EventHandler(this.POSButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 168);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy Lane";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(248, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 718);
            this.panel3.TabIndex = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Lane";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button ProductsButton;
		private System.Windows.Forms.Button POSButton;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MaxMinForm;
        private System.Windows.Forms.Button SalesButton;
    }
}

