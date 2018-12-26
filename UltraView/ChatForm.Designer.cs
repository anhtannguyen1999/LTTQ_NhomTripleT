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
            this.tbxShowMessage.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxShowMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxShowMessage.Location = new System.Drawing.Point(12, 12);
            this.tbxShowMessage.Name = "tbxShowMessage";
            this.tbxShowMessage.ReadOnly = true;
            this.tbxShowMessage.Size = new System.Drawing.Size(307, 348);
            this.tbxShowMessage.TabIndex = 0;
            this.tbxShowMessage.Text = "";
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxMessage.Location = new System.Drawing.Point(12, 366);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(307, 69);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSend.Location = new System.Drawing.Point(244, 441);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(331, 489);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tbxShowMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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