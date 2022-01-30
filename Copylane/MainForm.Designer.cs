
namespace Copylane
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
			this.Add = new System.Windows.Forms.Button();
			this.Item_Grid = new System.Windows.Forms.DataGridView();
			this.Description_Label = new System.Windows.Forms.Label();
			this.Price_Label = new System.Windows.Forms.Label();
			this.Description_Textbox = new System.Windows.Forms.TextBox();
			this.Price_Textbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.Item_Grid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.Location = new System.Drawing.Point(595, 102);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(96, 30);
			this.Add.TabIndex = 0;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Item_Grid
			// 
			this.Item_Grid.AllowUserToAddRows = false;
			this.Item_Grid.AllowUserToDeleteRows = false;
			this.Item_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Item_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Item_Grid.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Item_Grid.Location = new System.Drawing.Point(12, 169);
			this.Item_Grid.MultiSelect = false;
			this.Item_Grid.Name = "Item_Grid";
			this.Item_Grid.ReadOnly = true;
			this.Item_Grid.RowHeadersWidth = 51;
			this.Item_Grid.RowTemplate.Height = 24;
			this.Item_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Item_Grid.Size = new System.Drawing.Size(697, 353);
			this.Item_Grid.TabIndex = 1;
			// 
			// Description_Label
			// 
			this.Description_Label.AutoSize = true;
			this.Description_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description_Label.Location = new System.Drawing.Point(9, 29);
			this.Description_Label.Name = "Description_Label";
			this.Description_Label.Size = new System.Drawing.Size(82, 17);
			this.Description_Label.TabIndex = 2;
			this.Description_Label.Text = "Description";
			// 
			// Price_Label
			// 
			this.Price_Label.AutoSize = true;
			this.Price_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_Label.Location = new System.Drawing.Point(9, 60);
			this.Price_Label.Name = "Price_Label";
			this.Price_Label.Size = new System.Drawing.Size(42, 17);
			this.Price_Label.TabIndex = 3;
			this.Price_Label.Text = "Price";
			// 
			// Description_Textbox
			// 
			this.Description_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description_Textbox.Location = new System.Drawing.Point(98, 26);
			this.Description_Textbox.Name = "Description_Textbox";
			this.Description_Textbox.Size = new System.Drawing.Size(407, 25);
			this.Description_Textbox.TabIndex = 4;
			// 
			// Price_Textbox
			// 
			this.Price_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_Textbox.Location = new System.Drawing.Point(98, 57);
			this.Price_Textbox.Name = "Price_Textbox";
			this.Price_Textbox.Size = new System.Drawing.Size(111, 25);
			this.Price_Textbox.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Description_Label);
			this.groupBox1.Controls.Add(this.Price_Textbox);
			this.groupBox1.Controls.Add(this.Add);
			this.groupBox1.Controls.Add(this.Price_Label);
			this.groupBox1.Controls.Add(this.Description_Textbox);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(697, 138);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Info.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 534);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Item_Grid);
			this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Item_Grid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.DataGridView Item_Grid;
		private System.Windows.Forms.Label Description_Label;
		private System.Windows.Forms.Label Price_Label;
		private System.Windows.Forms.TextBox Description_Textbox;
		private System.Windows.Forms.TextBox Price_Textbox;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

