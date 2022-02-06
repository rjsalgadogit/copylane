
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Subtotal = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "SUBTOTAL";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.Subtotal);
			this.panel1.Location = new System.Drawing.Point(220, 18);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel1.Size = new System.Drawing.Size(201, 54);
			this.panel1.TabIndex = 9;
			// 
			// Subtotal
			// 
			this.Subtotal.AutoSize = true;
			this.Subtotal.Dock = System.Windows.Forms.DockStyle.Right;
			this.Subtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Subtotal.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Subtotal.ForeColor = System.Drawing.Color.White;
			this.Subtotal.Location = new System.Drawing.Point(47, 0);
			this.Subtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Subtotal.Size = new System.Drawing.Size(154, 45);
			this.Subtotal.TabIndex = 7;
			this.Subtotal.Text = "2,500.00";
			this.Subtotal.Click += new System.EventHandler(this.Subtotal_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Right;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(7, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(40, 45);
			this.label2.TabIndex = 8;
			this.label2.Text = "P";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// SubtotalView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SubtotalView";
			this.Size = new System.Drawing.Size(425, 87);
			this.Click += new System.EventHandler(this.SubtotalView_Click);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Subtotal;
	}
}
