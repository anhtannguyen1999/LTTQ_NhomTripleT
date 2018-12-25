namespace UltraView
{
    partial class ChatForm
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
            this.tbxShowMessage = new System.Windows.Forms.RichTextBox();
            this.tbxMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxShowMessage
            // 
            this.tbxShowMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxShowMessage.Location = new System.Drawing.Point(14, 15);
            this.tbxShowMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxShowMessage.Name = "tbxShowMessage";
            this.tbxShowMessage.ReadOnly = true;
            this.tbxShowMessage.Size = new System.Drawing.Size(345, 434);
            this.tbxShowMessage.TabIndex = 0;
            this.tbxShowMessage.Text = "";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(14, 458);
            this.tbxMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(345, 85);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(274, 551);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 39);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 611);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxShowMessage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxShowMessage;
        private System.Windows.Forms.RichTextBox tbxMessage;
        private System.Windows.Forms.Button btnSend;
    }
}