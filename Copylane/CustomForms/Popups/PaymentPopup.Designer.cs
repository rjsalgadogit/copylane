
namespace CopyLane.CustomForms.Popups
{
	partial class PaymentPopup
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.Cancel = new System.Windows.Forms.Button();
			this.Process = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.Change = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(438, 30);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.Cancel);
			this.panel2.Controls.Add(this.Process);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(438, 46);
			this.panel2.TabIndex = 1;
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.LightGray;
			this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.Cancel.FlatAppearance.BorderSize = 0;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cancel.Location = new System.Drawing.Point(219, 0);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(219, 46);
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "CANCEL";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Process
			// 
			this.Process.BackColor = System.Drawing.Color.ForestGreen;
			this.Process.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Process.Dock = System.Windows.Forms.DockStyle.Left;
			this.Process.FlatAppearance.BorderSize = 0;
			this.Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Process.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Process.ForeColor = System.Drawing.Color.White;
			this.Process.Location = new System.Drawing.Point(0, 0);
			this.Process.Name = "Process";
			this.Process.Size = new System.Drawing.Size(219, 46);
			this.Process.TabIndex = 0;
			this.Process.Text = "PROCESS";
			this.Process.UseVisualStyleBackColor = false;
			this.Process.Click += new System.EventHandler(this.Process_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.Change);
			this.panel5.Location = new System.Drawing.Point(152, 44);
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel5.Size = new System.Drawing.Size(272, 54);
			this.panel5.TabIndex = 15;
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
			// Change
			// 
			this.Change.AutoSize = true;
			this.Change.Dock = System.Windows.Forms.DockStyle.Right;
			this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Change.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Change.ForeColor = System.Drawing.Color.White;
			this.Change.Location = new System.Drawing.Point(185, 0);
			this.Change.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Change.Name = "Change";
			this.Change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Change.Size = new System.Drawing.Size(87, 45);
			this.Change.TabIndex = 7;
			this.Change.Text = "0.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(20, 49);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 33);
			this.label6.TabIndex = 14;
			this.label6.Text = "CHANGE";
			// 
			// PaymentPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(438, 159);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PaymentPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PaymentPopup";
			this.Load += new System.EventHandler(this.PaymentPopup_Load);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label Change;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.Button Process;
	}
}