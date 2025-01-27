namespace CopyLane.Server
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelTabAdmin = new Panel();
            ButtonTabAdmin = new Button();
            PanelTabSettings = new Panel();
            ButtonTabSettings = new Button();
            PanelTabHome = new Panel();
            ButtonTabHome = new Button();
            PanelBody = new Panel();
            tableLayoutPanel1.SuspendLayout();
            PanelTabAdmin.SuspendLayout();
            PanelTabSettings.SuspendLayout();
            PanelTabHome.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Silver;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PanelTabAdmin, 2, 0);
            tableLayoutPanel1.Controls.Add(PanelTabSettings, 1, 0);
            tableLayoutPanel1.Controls.Add(PanelTabHome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1350, 79);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelTabAdmin
            // 
            PanelTabAdmin.BackColor = Color.Silver;
            PanelTabAdmin.Controls.Add(ButtonTabAdmin);
            PanelTabAdmin.Dock = DockStyle.Fill;
            PanelTabAdmin.Location = new Point(389, 5);
            PanelTabAdmin.Margin = new Padding(5, 5, 5, 1);
            PanelTabAdmin.Name = "PanelTabAdmin";
            PanelTabAdmin.Padding = new Padding(0, 0, 0, 5);
            PanelTabAdmin.Size = new Size(182, 73);
            PanelTabAdmin.TabIndex = 2;
            // 
            // ButtonTabAdmin
            // 
            ButtonTabAdmin.BackColor = Color.Silver;
            ButtonTabAdmin.Cursor = Cursors.Hand;
            ButtonTabAdmin.Dock = DockStyle.Fill;
            ButtonTabAdmin.FlatAppearance.BorderSize = 0;
            ButtonTabAdmin.FlatStyle = FlatStyle.Flat;
            ButtonTabAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTabAdmin.ForeColor = Color.DimGray;
            ButtonTabAdmin.Image = Properties.Resources.close;
            ButtonTabAdmin.Location = new Point(0, 0);
            ButtonTabAdmin.Name = "ButtonTabAdmin";
            ButtonTabAdmin.Size = new Size(182, 68);
            ButtonTabAdmin.TabIndex = 3;
            ButtonTabAdmin.Text = "Admin";
            ButtonTabAdmin.TextAlign = ContentAlignment.BottomCenter;
            ButtonTabAdmin.UseVisualStyleBackColor = false;
            ButtonTabAdmin.Click += BtnTabClick;
            // 
            // PanelTabSettings
            // 
            PanelTabSettings.BackColor = Color.Silver;
            PanelTabSettings.Controls.Add(ButtonTabSettings);
            PanelTabSettings.Dock = DockStyle.Fill;
            PanelTabSettings.Location = new Point(197, 5);
            PanelTabSettings.Margin = new Padding(5, 5, 5, 1);
            PanelTabSettings.Name = "PanelTabSettings";
            PanelTabSettings.Padding = new Padding(0, 0, 0, 5);
            PanelTabSettings.Size = new Size(182, 73);
            PanelTabSettings.TabIndex = 1;
            // 
            // ButtonTabSettings
            // 
            ButtonTabSettings.BackColor = Color.Silver;
            ButtonTabSettings.Cursor = Cursors.Hand;
            ButtonTabSettings.Dock = DockStyle.Fill;
            ButtonTabSettings.FlatAppearance.BorderSize = 0;
            ButtonTabSettings.FlatStyle = FlatStyle.Flat;
            ButtonTabSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTabSettings.ForeColor = Color.DimGray;
            ButtonTabSettings.Image = Properties.Resources.close;
            ButtonTabSettings.Location = new Point(0, 0);
            ButtonTabSettings.Name = "ButtonTabSettings";
            ButtonTabSettings.Size = new Size(182, 68);
            ButtonTabSettings.TabIndex = 3;
            ButtonTabSettings.Text = "Settings";
            ButtonTabSettings.TextAlign = ContentAlignment.BottomCenter;
            ButtonTabSettings.UseVisualStyleBackColor = false;
            ButtonTabSettings.Click += BtnTabClick;
            // 
            // PanelTabHome
            // 
            PanelTabHome.BackColor = Color.MediumSeaGreen;
            PanelTabHome.Controls.Add(ButtonTabHome);
            PanelTabHome.Dock = DockStyle.Fill;
            PanelTabHome.Location = new Point(5, 5);
            PanelTabHome.Margin = new Padding(5, 5, 5, 1);
            PanelTabHome.Name = "PanelTabHome";
            PanelTabHome.Padding = new Padding(0, 0, 0, 5);
            PanelTabHome.Size = new Size(182, 73);
            PanelTabHome.TabIndex = 0;
            // 
            // ButtonTabHome
            // 
            ButtonTabHome.BackColor = Color.Silver;
            ButtonTabHome.Cursor = Cursors.Hand;
            ButtonTabHome.Dock = DockStyle.Fill;
            ButtonTabHome.FlatAppearance.BorderSize = 0;
            ButtonTabHome.FlatStyle = FlatStyle.Flat;
            ButtonTabHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonTabHome.ForeColor = Color.DimGray;
            ButtonTabHome.Image = Properties.Resources.close;
            ButtonTabHome.Location = new Point(0, 0);
            ButtonTabHome.Name = "ButtonTabHome";
            ButtonTabHome.Size = new Size(182, 68);
            ButtonTabHome.TabIndex = 3;
            ButtonTabHome.Text = "Home";
            ButtonTabHome.TextAlign = ContentAlignment.BottomCenter;
            ButtonTabHome.UseVisualStyleBackColor = false;
            ButtonTabHome.Click += BtnTabClick;
            // 
            // PanelBody
            // 
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(0, 79);
            PanelBody.Name = "PanelBody";
            PanelBody.Size = new Size(1350, 650);
            PanelBody.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(PanelBody);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "CopyLane Server";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            PanelTabAdmin.ResumeLayout(false);
            PanelTabSettings.ResumeLayout(false);
            PanelTabHome.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelTabHome;
        private Button ButtonTabHome;
        private Panel PanelTabAdmin;
        private Button ButtonTabAdmin;
        private Panel PanelTabSettings;
        private Button ButtonTabSettings;
        private Panel PanelBody;
    }
}
