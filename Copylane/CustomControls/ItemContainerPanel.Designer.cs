
namespace Copylane.CustomControls
{
	partial class ItemPanel
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ItemGrid = new System.Windows.Forms.DataGridView();
			this.Search = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.KeysCombo = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Delete = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.HiddenId_Textbox = new System.Windows.Forms.TextBox();
			this.Description_Label = new System.Windows.Forms.Label();
			this.Price_Textbox = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.Price_Label = new System.Windows.Forms.Label();
			this.Description_Textbox = new System.Windows.Forms.TextBox();
			this.SearchTextbox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.OrangeRed;
			this.label3.Location = new System.Drawing.Point(484, 408);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(340, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "* Double click on the table row to update (edit) or delete item.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Search Item";
			// 
			// ItemGrid
			// 
			this.ItemGrid.AllowUserToAddRows = false;
			this.ItemGrid.AllowUserToDeleteRows = false;
			this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemGrid.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemGrid.Location = new System.Drawing.Point(13, 72);
			this.ItemGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ItemGrid.MultiSelect = false;
			this.ItemGrid.Name = "ItemGrid";
			this.ItemGrid.ReadOnly = true;
			this.ItemGrid.RowHeadersWidth = 51;
			this.ItemGrid.RowTemplate.Height = 24;
			this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ItemGrid.Size = new System.Drawing.Size(811, 326);
			this.ItemGrid.TabIndex = 100;
			// 
			// Search
			// 
			this.Search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.Location = new System.Drawing.Point(701, 37);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(123, 27);
			this.Search.TabIndex = 100;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.KeysCombo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.Delete);
			this.groupBox1.Controls.Add(this.Cancel);
			this.groupBox1.Controls.Add(this.Save);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.HiddenId_Textbox);
			this.groupBox1.Controls.Add(this.Description_Label);
			this.groupBox1.Controls.Add(this.Price_Textbox);
			this.groupBox1.Controls.Add(this.Add);
			this.groupBox1.Controls.Add(this.Price_Label);
			this.groupBox1.Controls.Add(this.Description_Textbox);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(14, 432);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(810, 160);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Details";
			// 
			// KeysCombo
			// 
			this.KeysCombo.FormattingEnabled = true;
			this.KeysCombo.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4"});
			this.KeysCombo.Location = new System.Drawing.Point(536, 31);
			this.KeysCombo.Name = "KeysCombo";
			this.KeysCombo.Size = new System.Drawing.Size(121, 24);
			this.KeysCombo.TabIndex = 103;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(449, 35);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 15);
			this.label8.TabIndex = 101;
			this.label8.Text = "Shortcut Key";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(507, 108);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 33);
			this.label4.TabIndex = 16;
			this.label4.Text = "|";
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.Color.OrangeRed;
			this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.ForeColor = System.Drawing.Color.White;
			this.Delete.Location = new System.Drawing.Point(533, 110);
			this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(84, 35);
			this.Delete.TabIndex = 5;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.LightGray;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel.Location = new System.Drawing.Point(717, 110);
			this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(84, 35);
			this.Cancel.TabIndex = 7;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = false;
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.ForestGreen;
			this.Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.ForeColor = System.Drawing.Color.White;
			this.Save.Location = new System.Drawing.Point(625, 110);
			this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(84, 35);
			this.Save.TabIndex = 6;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Hidden Id";
			this.label2.Visible = false;
			// 
			// HiddenId_Textbox
			// 
			this.HiddenId_Textbox.Location = new System.Drawing.Point(99, 89);
			this.HiddenId_Textbox.Name = "HiddenId_Textbox";
			this.HiddenId_Textbox.Size = new System.Drawing.Size(100, 23);
			this.HiddenId_Textbox.TabIndex = 100;
			this.HiddenId_Textbox.Visible = false;
			// 
			// Description_Label
			// 
			this.Description_Label.AutoSize = true;
			this.Description_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description_Label.Location = new System.Drawing.Point(12, 35);
			this.Description_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Description_Label.Name = "Description_Label";
			this.Description_Label.Size = new System.Drawing.Size(70, 15);
			this.Description_Label.TabIndex = 2;
			this.Description_Label.Text = "Description";
			// 
			// Price_Textbox
			// 
			this.Price_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_Textbox.Location = new System.Drawing.Point(99, 61);
			this.Price_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Price_Textbox.Name = "Price_Textbox";
			this.Price_Textbox.Size = new System.Drawing.Size(100, 21);
			this.Price_Textbox.TabIndex = 3;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.SteelBlue;
			this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.ForeColor = System.Drawing.Color.White;
			this.Add.Location = new System.Drawing.Point(416, 110);
			this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(84, 35);
			this.Add.TabIndex = 4;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = false;
			// 
			// Price_Label
			// 
			this.Price_Label.AutoSize = true;
			this.Price_Label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_Label.Location = new System.Drawing.Point(12, 64);
			this.Price_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Price_Label.Name = "Price_Label";
			this.Price_Label.Size = new System.Drawing.Size(35, 15);
			this.Price_Label.TabIndex = 3;
			this.Price_Label.Text = "Price";
			// 
			// Description_Textbox
			// 
			this.Description_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description_Textbox.Location = new System.Drawing.Point(99, 32);
			this.Description_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Description_Textbox.Name = "Description_Textbox";
			this.Description_Textbox.Size = new System.Drawing.Size(312, 21);
			this.Description_Textbox.TabIndex = 2;
			// 
			// SearchTextbox
			// 
			this.SearchTextbox.Location = new System.Drawing.Point(102, 39);
			this.SearchTextbox.Name = "SearchTextbox";
			this.SearchTextbox.Size = new System.Drawing.Size(210, 20);
			this.SearchTextbox.TabIndex = 1;
			// 
			// ItemPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ItemGrid);
			this.Controls.Add(this.SearchTextbox);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.groupBox1);
			this.Name = "ItemPanel";
			this.Size = new System.Drawing.Size(836, 642);
			this.Load += new System.EventHandler(this.ItemPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView ItemGrid;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox KeysCombo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox HiddenId_Textbox;
		private System.Windows.Forms.Label Description_Label;
		private System.Windows.Forms.TextBox Price_Textbox;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Label Price_Label;
		private System.Windows.Forms.TextBox Description_Textbox;
		private System.Windows.Forms.TextBox SearchTextbox;
	}
}
