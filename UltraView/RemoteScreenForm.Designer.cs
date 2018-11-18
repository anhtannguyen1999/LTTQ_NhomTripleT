namespace UltraView
{
    partial class RemoteScreenForm
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
            this.picShowScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picShowScreen
            // 
            this.picShowScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShowScreen.Location = new System.Drawing.Point(0, 0);
            this.picShowScreen.Name = "picShowScreen";
            this.picShowScreen.Size = new System.Drawing.Size(782, 753);
            this.picShowScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowScreen.TabIndex = 0;
            this.picShowScreen.TabStop = false;
            // 
            // RemoteScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.picShowScreen);
            this.Name = "RemoteScreenForm";
            this.Text = "RemoteScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteScreenForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShowScreen;
    }
}

