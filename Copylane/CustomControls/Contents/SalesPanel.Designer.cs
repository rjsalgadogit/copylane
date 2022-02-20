
namespace CopyLane.CustomControls.Contents
{
    partial class SalesPanel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesTodayBtn = new System.Windows.Forms.Button();
            this.SalesDateBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesDateBtn);
            this.panel1.Controls.Add(this.SalesTodayBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 59);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 659);
            this.panel2.TabIndex = 1;
            // 
            // SalesTodayBtn
            // 
            this.SalesTodayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesTodayBtn.ForeColor = System.Drawing.Color.White;
            this.SalesTodayBtn.Location = new System.Drawing.Point(15, 15);
            this.SalesTodayBtn.Name = "SalesTodayBtn";
            this.SalesTodayBtn.Size = new System.Drawing.Size(97, 32);
            this.SalesTodayBtn.TabIndex = 0;
            this.SalesTodayBtn.Text = "Sales Today";
            this.SalesTodayBtn.UseVisualStyleBackColor = true;
            this.SalesTodayBtn.Click += new System.EventHandler(this.SalesTodayBtn_Click);
            // 
            // SalesDateBtn
            // 
            this.SalesDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesDateBtn.ForeColor = System.Drawing.Color.White;
            this.SalesDateBtn.Location = new System.Drawing.Point(118, 15);
            this.SalesDateBtn.Name = "SalesDateBtn";
            this.SalesDateBtn.Size = new System.Drawing.Size(112, 32);
            this.SalesDateBtn.TabIndex = 1;
            this.SalesDateBtn.Text = "Sales By Date";
            this.SalesDateBtn.UseVisualStyleBackColor = true;
            this.SalesDateBtn.Click += new System.EventHandler(this.SalesDateBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1027, 631);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SalesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesPanel";
            this.Size = new System.Drawing.Size(1056, 718);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SalesDateBtn;
        private System.Windows.Forms.Button SalesTodayBtn;
        private System.Windows.Forms.ListView listView1;
    }
}
