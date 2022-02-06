
namespace CopyLane.CustomControls.Contents
{
	partial class POSPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Payment = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.F4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.F3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.F2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.F1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(631, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 718);
			this.panel1.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel6.Controls.Add(this.Payment);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.ForeColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(0, 565);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(425, 69);
			this.panel6.TabIndex = 2;
			// 
			// Payment
			// 
			this.Payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Payment.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Payment.Location = new System.Drawing.Point(189, 15);
			this.Payment.Name = "Payment";
			this.Payment.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Payment.Size = new System.Drawing.Size(211, 40);
			this.Payment.TabIndex = 12;
			this.Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Payment_KeyPress);
			this.Payment.Leave += new System.EventHandler(this.Payment_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 21);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Enter Payment";
			// 
			// panel3
			// 
			this.panel3.AutoScroll = true;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(425, 565);
			this.panel3.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.F4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.F3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.F2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.F1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(631, 718);
			this.panel2.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(589, 17);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(2);
			this.label4.Size = new System.Drawing.Size(26, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "F4";
			// 
			// F4
			// 
			this.F4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F4.Location = new System.Drawing.Point(473, 10);
			this.F4.Name = "F4";
			this.F4.Size = new System.Drawing.Size(150, 115);
			this.F4.TabIndex = 9;
			this.F4.Text = "No item";
			this.F4.UseVisualStyleBackColor = true;
			this.F4.Click += new System.EventHandler(this.F4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Black;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(434, 17);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(2);
			this.label3.Size = new System.Drawing.Size(26, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "F3";
			// 
			// F3
			// 
			this.F3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F3.Location = new System.Drawing.Point(318, 10);
			this.F3.Name = "F3";
			this.F3.Size = new System.Drawing.Size(150, 115);
			this.F3.TabIndex = 7;
			this.F3.Text = "No item";
			this.F3.UseVisualStyleBackColor = true;
			this.F3.Click += new System.EventHandler(this.F3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Black;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(279, 17);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(2);
			this.label2.Size = new System.Drawing.Size(26, 22);
			this.label2.TabIndex = 6;
			this.label2.Text = "F2";
			// 
			// F2
			// 
			this.F2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F2.Location = new System.Drawing.Point(163, 10);
			this.F2.Name = "F2";
			this.F2.Size = new System.Drawing.Size(150, 115);
			this.F2.TabIndex = 5;
			this.F2.Text = "No item";
			this.F2.UseVisualStyleBackColor = true;
			this.F2.Click += new System.EventHandler(this.F2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(123, 17);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(2);
			this.label1.Size = new System.Drawing.Size(26, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "F1";
			// 
			// F1
			// 
			this.F1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F1.Location = new System.Drawing.Point(7, 10);
			this.F1.Name = "F1";
			this.F1.Size = new System.Drawing.Size(150, 115);
			this.F1.TabIndex = 0;
			this.F1.Text = "No item";
			this.F1.UseVisualStyleBackColor = true;
			this.F1.Click += new System.EventHandler(this.F1_Click);
			// 
			// POSPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "POSPanel";
			this.Size = new System.Drawing.Size(1056, 718);
			this.Load += new System.EventHandler(this.POSPanel_Load);
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button F1;
		public System.Windows.Forms.Button F4;
		public System.Windows.Forms.Button F3;
		public System.Windows.Forms.Button F2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox Payment;
		public System.Windows.Forms.Panel panel3;
	}
}
