
namespace CopyLane.CustomControls.PartialViews
{
	partial class SubtotalView
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.Subtotal = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.Subtotal);
			this.panel5.Location = new System.Drawing.Point(142, 18);
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel5.Size = new System.Drawing.Size(272, 54);
			this.panel5.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Right;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(145, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(40, 45);
			this.label5.TabIndex = 8;
			this.label5.Text = "P";
			// 
			// Subtotal
			// 
			this.Subtotal.AutoSize = true;
			this.Subtotal.Dock = System.Windows.Forms.DockStyle.Right;
			this.Subtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Subtotal.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Subtotal.ForeColor = System.Drawing.Color.White;
			this.Subtotal.Location = new System.Drawing.Point(185, 0);
			this.Subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Subtotal.Size = new System.Drawing.Size(87, 45);
			this.Subtotal.TabIndex = 7;
			this.Subtotal.Text = "0.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(10, 22);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 36);
			this.label6.TabIndex = 12;
			this.label6.Text = "SUBTOTAL";
			// 
			// SubtotalView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label6);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "SubtotalView";
			this.Size = new System.Drawing.Size(425, 84);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label Subtotal;
	}
}
