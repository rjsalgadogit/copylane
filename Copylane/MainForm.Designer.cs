
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
			this.F4 = new System.Windows.Forms.Button();
			this.F3 = new System.Windows.Forms.Button();
			this.F2 = new System.Windows.Forms.Button();
			this.F1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Search = new System.Windows.Forms.Button();
			this.SearchTextbox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.DragPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ItemButton = new System.Windows.Forms.Button();
			this.POSButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ChargePanel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.ChargeAmount = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.ChargePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ItemGrid
			// 
			this.ItemGrid.AllowUserToAddRows = false;
			this.ItemGrid.AllowUserToDeleteRows = false;
			this.ItemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemGrid.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemGrid.Location = new System.Drawing.Point(12, 47);
			this.ItemGrid.Margin = new System.Windows.Forms.Padding(4);
			this.ItemGrid.MultiSelect = false;
			this.ItemGrid.Name = "ItemGrid";
			this.ItemGrid.ReadOnly = true;
			this.ItemGrid.RowHeadersWidth = 51;
			this.ItemGrid.RowTemplate.Height = 24;
			this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ItemGrid.Size = new System.Drawing.Size(811, 326);
			this.ItemGrid.TabIndex = 100;
			this.ItemGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemGrid_CellMouseDoubleClick);
			// 
			// F4
			// 
			this.F4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F4.Location = new System.Drawing.Point(271, 12);
			this.F4.Name = "F4";
			this.F4.Size = new System.Drawing.Size(79, 67);
			this.F4.TabIndex = 3;
			this.F4.Text = "F4";
			this.F4.UseVisualStyleBackColor = true;
			this.F4.Click += new System.EventHandler(this.F4_Click);
			// 
			// F3
			// 
			this.F3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F3.Location = new System.Drawing.Point(186, 12);
			this.F3.Name = "F3";
			this.F3.Size = new System.Drawing.Size(79, 67);
			this.F3.TabIndex = 2;
			this.F3.Text = "F3";
			this.F3.UseVisualStyleBackColor = true;
			this.F3.Click += new System.EventHandler(this.F3_Click);
			// 
			// F2
			// 
			this.F2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F2.Location = new System.Drawing.Point(101, 12);
			this.F2.Name = "F2";
			this.F2.Size = new System.Drawing.Size(79, 67);
			this.F2.TabIndex = 1;
			this.F2.Text = "F2";
			this.F2.UseVisualStyleBackColor = true;
			this.F2.Click += new System.EventHandler(this.F2_Click);
			// 
			// F1
			// 
			this.F1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.F1.Location = new System.Drawing.Point(16, 12);
			this.F1.Name = "F1";
			this.F1.Size = new System.Drawing.Size(79, 67);
			this.F1.TabIndex = 0;
			this.F1.Text = "F1";
			this.F1.UseVisualStyleBackColor = true;
			this.F1.Click += new System.EventHandler(this.F1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.OrangeRed;
			this.label3.Location = new System.Drawing.Point(483, 383);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(400, 17);
			this.label3.TabIndex = 13;
			this.label3.Text = "* Double click on the table row to update (edit) or delete item.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 19);
			this.label1.TabIndex = 10;
			this.label1.Text = "Search Item";
			// 
			// Search
			// 
			this.Search.Font = new System.Drawing.Font("Arial", 10.2F);
			this.Search.Location = new System.Drawing.Point(700, 12);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(123, 27);
			this.Search.TabIndex = 100;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Visible = false;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// SearchTextbox
			// 
			this.SearchTextbox.Location = new System.Drawing.Point(101, 14);
			this.SearchTextbox.Name = "SearchTextbox";
			this.SearchTextbox.Size = new System.Drawing.Size(210, 27);
			this.SearchTextbox.TabIndex = 1;
			this.SearchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyDown);
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
			this.groupBox1.Location = new System.Drawing.Point(13, 419);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(810, 143);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Details";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new System.Drawing.Point(501, 96);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 42);
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
			this.Delete.Location = new System.Drawing.Point(527, 98);
			this.Delete.Margin = new System.Windows.Forms.Padding(4);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(84, 35);
			this.Delete.TabIndex = 5;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
			this.Cancel.TabIndex = 7;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
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
			this.Save.TabIndex = 6;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(609, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Hidden Id";
			this.label2.Visible = false;
			// 
			// HiddenId_Textbox
			// 
			this.HiddenId_Textbox.Location = new System.Drawing.Point(695, 31);
			this.HiddenId_Textbox.Name = "HiddenId_Textbox";
			this.HiddenId_Textbox.Size = new System.Drawing.Size(100, 27);
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
			this.Description_Label.Size = new System.Drawing.Size(82, 17);
			this.Description_Label.TabIndex = 2;
			this.Description_Label.Text = "Description";
			// 
			// Price_Textbox
			// 
			this.Price_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Price_Textbox.Location = new System.Drawing.Point(98, 61);
			this.Price_Textbox.Margin = new System.Windows.Forms.Padding(4);
			this.Price_Textbox.Name = "Price_Textbox";
			this.Price_Textbox.Size = new System.Drawing.Size(100, 25);
			this.Price_Textbox.TabIndex = 3;
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
			this.Add.TabIndex = 4;
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
			this.Price_Label.Size = new System.Drawing.Size(42, 17);
			this.Price_Label.TabIndex = 3;
			this.Price_Label.Text = "Price";
			// 
			// Description_Textbox
			// 
			this.Description_Textbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description_Textbox.Location = new System.Drawing.Point(98, 32);
			this.Description_Textbox.Margin = new System.Windows.Forms.Padding(4);
			this.Description_Textbox.Name = "Description_Textbox";
			this.Description_Textbox.Size = new System.Drawing.Size(312, 25);
			this.Description_Textbox.TabIndex = 2;
			// 
			// DragPanel
			// 
			this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.DragPanel.Location = new System.Drawing.Point(0, 0);
			this.DragPanel.Name = "DragPanel";
			this.DragPanel.Size = new System.Drawing.Size(1100, 26);
			this.DragPanel.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel2.Controls.Add(this.ItemButton);
			this.panel2.Controls.Add(this.POSButton);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 26);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(299, 746);
			this.panel2.TabIndex = 9;
			// 
			// ItemButton
			// 
			this.ItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ItemButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ItemButton.FlatAppearance.BorderSize = 0;
			this.ItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ItemButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ItemButton.ForeColor = System.Drawing.Color.White;
			this.ItemButton.Location = new System.Drawing.Point(0, 233);
			this.ItemButton.Name = "ItemButton";
			this.ItemButton.Size = new System.Drawing.Size(299, 46);
			this.ItemButton.TabIndex = 2;
			this.ItemButton.Text = "Items";
			this.ItemButton.UseVisualStyleBackColor = true;
			// 
			// POSButton
			// 
			this.POSButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.POSButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.POSButton.FlatAppearance.BorderSize = 0;
			this.POSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.POSButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.POSButton.ForeColor = System.Drawing.Color.White;
			this.POSButton.Location = new System.Drawing.Point(0, 187);
			this.POSButton.Name = "POSButton";
			this.POSButton.Size = new System.Drawing.Size(299, 46);
			this.POSButton.TabIndex = 1;
			this.POSButton.Text = "Point of Sale";
			this.POSButton.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(299, 187);
			this.panel3.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.F4);
			this.panel4.Controls.Add(this.F1);
			this.panel4.Controls.Add(this.F3);
			this.panel4.Controls.Add(this.F2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(299, 26);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(801, 746);
			this.panel4.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.ItemGrid);
			this.panel5.Controls.Add(this.Search);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Controls.Add(this.SearchTextbox);
			this.panel5.Location = new System.Drawing.Point(16, 634);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(342, 100);
			this.panel5.TabIndex = 11;
			this.panel5.Visible = false;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.listView1);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.ChargePanel);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(367, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(434, 746);
			this.panel6.TabIndex = 4;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label7);
			this.panel8.Controls.Add(this.label6);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel8.Location = new System.Drawing.Point(0, 595);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(434, 56);
			this.panel8.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(308, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 29);
			this.label7.TabIndex = 1;
			this.label7.Text = "P 1,200.15";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(24, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 24);
			this.label6.TabIndex = 0;
			this.label6.Text = "Change";
			// 
			// ChargePanel
			// 
			this.ChargePanel.BackColor = System.Drawing.Color.ForestGreen;
			this.ChargePanel.Controls.Add(this.label5);
			this.ChargePanel.Controls.Add(this.ChargeAmount);
			this.ChargePanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChargePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ChargePanel.Location = new System.Drawing.Point(0, 651);
			this.ChargePanel.Name = "ChargePanel";
			this.ChargePanel.Size = new System.Drawing.Size(434, 95);
			this.ChargePanel.TabIndex = 0;
			this.ChargePanel.Click += new System.EventHandler(this.ChargePanel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(22, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(164, 39);
			this.label5.TabIndex = 2;
			this.label5.Text = "CHARGE";
			// 
			// ChargeAmount
			// 
			this.ChargeAmount.AutoSize = true;
			this.ChargeAmount.BackColor = System.Drawing.Color.Transparent;
			this.ChargeAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChargeAmount.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChargeAmount.ForeColor = System.Drawing.Color.White;
			this.ChargeAmount.Location = new System.Drawing.Point(224, 25);
			this.ChargeAmount.Name = "ChargeAmount";
			this.ChargeAmount.Size = new System.Drawing.Size(249, 55);
			this.ChargeAmount.TabIndex = 1;
			this.ChargeAmount.Text = "P 1,200.15";
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(434, 595);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 772);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.DragPanel);
			this.Font = new System.Drawing.Font("Arial", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(328, -907);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ChargePanel.ResumeLayout(false);
			this.ChargePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView ItemGrid;
		private System.Windows.Forms.TextBox SearchTextbox;
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
		private System.Windows.Forms.Button F4;
		private System.Windows.Forms.Button F3;
		private System.Windows.Forms.Button F2;
		private System.Windows.Forms.Button F1;
		private System.Windows.Forms.Panel DragPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel ChargePanel;
		private System.Windows.Forms.Label ChargeAmount;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ItemButton;
		private System.Windows.Forms.Button POSButton;
		private System.Windows.Forms.ListView listView1;
	}
}

