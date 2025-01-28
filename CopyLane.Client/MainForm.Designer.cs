namespace CopyLane.Client
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
            TextBoxRFID = new TextBox();
            richTextBox1 = new RichTextBox();
            BtnSendMessage = new Button();
            SuspendLayout();
            // 
            // TextBoxRFID
            // 
            TextBoxRFID.BorderStyle = BorderStyle.None;
            TextBoxRFID.Location = new Point(1167, 615);
            TextBoxRFID.Name = "TextBoxRFID";
            TextBoxRFID.Size = new Size(171, 16);
            TextBoxRFID.TabIndex = 0;
            TextBoxRFID.KeyUp += TextBoxRFID_KeyUp;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(553, 249);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // BtnSendMessage
            // 
            BtnSendMessage.Location = new Point(455, 267);
            BtnSendMessage.Name = "BtnSendMessage";
            BtnSendMessage.Size = new Size(110, 23);
            BtnSendMessage.TabIndex = 2;
            BtnSendMessage.Text = "Send Message";
            BtnSendMessage.UseVisualStyleBackColor = true;
            BtnSendMessage.Click += BtnSendMessage_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 650);
            Controls.Add(BtnSendMessage);
            Controls.Add(richTextBox1);
            Controls.Add(TextBoxRFID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxRFID;
        private RichTextBox richTextBox1;
        private Button BtnSendMessage;
    }
}
