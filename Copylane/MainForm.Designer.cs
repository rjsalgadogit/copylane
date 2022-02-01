
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
			this.ItemGrid = new System.Windows.Forms.DataGridView();
			this.Main_Tab = new System.Windows.Forms.TabControl();
			this.Invoice_TabPage = new System.Windows.Forms.TabPage();
			this.Item_TabPage = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.Search = new System.Windows.Forms.Button();
			this.Search_Textbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Description_Label = new System.Windows.Forms.Label();
			this.Price_Textbox = new System.Windows.Forms.TextBox();
			this.Add = new System.Windows.Forms.Button();
			this.Price_Label = new System.Windows.Forms.Label();
			this.Description_Textbox = new System.Windows.Forms.TextBox();
			this.HiddenId_Textbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Save = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Delete = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
			this.Main_Tab.SuspendLayout();
			this.Item_TabPage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ItemGrid
			// 
			this.ItemGrid.AllowUserToAddRows = false;
			this.ItemGrid.AllowUserToDeleteRows = false;
			this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemGrid.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemGrid.Location = new System.Drawing.Point(7, 53);
			this.ItemGrid.Margin = new System.Windows.Forms.Padding(4);
			this.ItemGrid.MultiSelect = false;
			this.ItemGrid.Name = "ItemGrid";
			this.ItemGrid.ReadOnly = true;
			this.ItemGrid.RowHeadersWidth = 51;
			this.ItemGrid.RowTemplate.Height = 24;
			this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ItemGrid.Size = new System.Drawing.Size(811, 326);
			this.ItemGrid.TabIndex = 1;
			this.ItemGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemGrid_CellMouseDoubleClick);
			// 
			// Main_Tab
			// 
			this.Main_Tab.Controls.Add(this.Invoice_TabPage);
			this.Main_Tab.Controls.Add(this.Item_TabPage);
			this.Main_Tab.Location = new System.Drawing.Point(15, 14);
			this.Main_Tab.Margin = new System.Windows.Forms.Padding(4);
			this.Main_Tab.Name = "Main_Tab";
			this.Main_Tab.SelectedIndex = 0;
			this.Main_Tab.Size = new System.Drawing.Size(835, 745);
			this.Main_Tab.TabIndex = 7;
			// 
			// Invoice_TabPage
			// 
			this.Invoice_TabPage.Location = new System.Drawing.Point(4, 25);
			this.Invoice_TabPage.Margin = new System.Windows.Forms.Padding(4);
			this.Invoice_TabPage.Name = "Invoice_TabPage";
			this.Invoice_TabPage.Padding = new System.Windows.Forms.Padding(4);
			this.Invoice_TabPage.Size = new System.Drawing.Size(1142, 716);
			this.Invoice_TabPage.TabIndex = 0;
			this.Invoice_TabPage.Text = "Invoice";
			this.Invoice_TabPage.UseVisualStyleBackColor = true;
			// 
			// Item_TabPage
			// 
			this.Item_TabPage.Controls.Add(this.label3);
			this.Item_TabPage.Controls.Add(this.label1);
			this.Item_TabPage.Controls.Add(this.Search);
			this.Item_TabPage.Controls.Add(this.Search_Textbox);
			this.Item_TabPage.Controls.Add(this.groupBox1);
			this.Item_TabPage.Controls.Add(this.ItemGrid);
			this.Item_TabPage.Location = new System.Drawing.Point(4, 25);
			this.Item_TabPage.Margin = new System.Windows.Forms.Padding(4);
			this.Item_TabPage.Name = "Item_TabPage";
			this.Item_TabPage.Padding = new System.Windows.Forms.Padding(4);
			this.Item_TabPage.Size = new System.Drawing.Size(827, 716);
			this.Item_TabPage.TabIndex = 1;
			this.Item_TabPage.Text = "Items";
			this.Item_TabPage.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Search Item";
			// 
			// Search
			// 
			this.Search.Font = new System.Drawing.Font("Arial", 10.2F);
			this.Search.Location = new System.Drawing.Point(695, 18);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(123, 27);
			this.Search.TabIndex = 9;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Visible = false;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// Search_Textbox
			// 
			this.Search_Textbox.Location = new System.Drawing.Point(96, 20);
			this.Search_Textbox.Name = "Search_Textbox";
			this.Search_Textbox.Size = new System.Drawing.Size(210, 23);
			this.Search_Textbox.TabIndex = 7;
			this.Search_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Textbox_KeyDown);
			// 
			// groupBox1
			// 
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
			this.groupBox1.Location = new System.Drawing.Point(8, 425);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(810, 143);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Details";
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
			this.Price_Textbox.Location = new System.Drawing.Point(98, 61);
			this.Price_Textbox.Margin = new System.Windows.Forms.Padding(4);
			this.Price_Textbox.Name = "Price_Textbox";
			this.Price_Textbox.Size = new System.Drawing.Size(100, 21);
			this.Price_Textbox.TabIndex = 5;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.SteelBlue;
			this.Add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.ForeColor = System.Drawing.Color.White;
			this.Add.Location = new System.Drawing.Point(410, 98);
			this.Add.Margin = new System.Windows.Forms.Padding(4);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(84, 35);
			this.Add.TabIndex = 0;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.Add_Click);
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
			this.Description_Textbox.Location = new System.Drawing.Point(98, 32);
			this.Description_Textbox.Margin = new System.Windows.Forms.Padding(4);
			this.Description_Textbox.Name = "Description_Textbox";
			this.Description_Textbox.Size = new System.Drawing.Size(312, 21);
			this.Description_Textbox.TabIndex = 4;
			// 
			// HiddenId_Textbox
			// 
			this.HiddenId_Textbox.Location = new System.Drawing.Point(695, 31);
			this.HiddenId_Textbox.Name = "HiddenId_Textbox";
			this.HiddenId_Textbox.Size = new System.Drawing.Size(100, 23);
			this.HiddenId_Textbox.TabIndex = 11;
			this.HiddenId_Textbox.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(609, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Hidden Id";
			this.label2.Visible = false;
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.ForestGreen;
			this.Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.ForeColor = System.Drawing.Color.White;
			this.Save.Location = new System.Drawing.Point(619, 98);
			this.Save.Margin = new System.Windows.Forms.Padding(4);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(84, 35);
			this.Save.TabIndex = 13;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.LightGray;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel.Location = new System.Drawing.Point(711, 98);
			this.Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(84, 35);
			this.Cancel.TabIndex = 14;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.OrangeRed;
			this.label3.Location = new System.Drawing.Point(478, 389);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(340, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "* Double click on the table row to update (edit) or delete item.";
			// 
			// Delete
			// 
			this.Delete.BackColor = System.Drawing.Color.OrangeRed;
			this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.ForeColor = System.Drawing.Color.White;
			this.Delete.Location = new System.Drawing.Point(527, 98);
			this.Delete.Margin = new System.Windows.Forms.Padding(4);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(84, 35);
			this.Delete.TabIndex = 15;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(501, 96);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 33);
			this.label4.TabIndex = 16;
			this.label4.Text = "|";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 772);
			this.Controls.Add(this.Main_Tab);
			this.Font = new System.Drawing.Font("Arial", 10.2F);
			this.Location = new System.Drawing.Point(328, -907);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
			this.Main_Tab.ResumeLayout(false);
			this.Item_TabPage.ResumeLayout(false);
			this.Item_TabPage.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView ItemGrid;
		private System.Windows.Forms.TabControl Main_Tab;
		private System.Windows.Forms.TabPage Invoice_TabPage;
		private System.Windows.Forms.TabPage Item_TabPage;
		private System.Windows.Forms.TextBox Search_Textbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label Description_Label;
		private System.Windows.Forms.TextBox Price_Textbox;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Label Price_Label;
		private System.Windows.Forms.TextBox Description_Textbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox HiddenId_Textbox;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Delete;
	}
}

