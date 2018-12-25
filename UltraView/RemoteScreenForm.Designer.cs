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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbMouseMove = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbxMouse = new System.Windows.Forms.CheckBox();
            this.cbxKeyBoard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picShowScreen
            // 
            this.picShowScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picShowScreen.Location = new System.Drawing.Point(0, 0);
            this.picShowScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picShowScreen.Name = "picShowScreen";
            this.picShowScreen.Size = new System.Drawing.Size(778, 514);
            this.picShowScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowScreen.TabIndex = 0;
            this.picShowScreen.TabStop = false;
            this.picShowScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseClick);
            this.picShowScreen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseDoubleClick);
            this.picShowScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseDown);
            this.picShowScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseMove);
            this.picShowScreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowScreen_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbIP,
            this.lbSize,
            this.lbMouseMove,
            this.toolStripStatusLabel1,
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(778, 30);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbIP
            // 
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(27, 25);
            this.lbIP.Text = "IP";
            // 
            // lbSize
            // 
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(43, 25);
            this.lbSize.Text = "Size";
            // 
            // lbMouseMove
            // 
            this.lbMouseMove.Name = "lbMouseMove";
            this.lbMouseMove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMouseMove.Size = new System.Drawing.Size(52, 25);
            this.lbMouseMove.Text = "Point";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(27, 25);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(64, 25);
            this.lbStatus.Text = "Status:";
            // 
            // cbxMouse
            // 
            this.cbxMouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMouse.AutoSize = true;
            this.cbxMouse.Location = new System.Drawing.Point(458, 520);
            this.cbxMouse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMouse.Name = "cbxMouse";
            this.cbxMouse.Size = new System.Drawing.Size(137, 24);
            this.cbxMouse.TabIndex = 6;
            this.cbxMouse.Text = "Mouse remote";
            this.cbxMouse.UseVisualStyleBackColor = true;
            this.cbxMouse.CheckedChanged += new System.EventHandler(this.cbxMouse_CheckedChanged);
            // 
            // cbxKeyBoard
            // 
            this.cbxKeyBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKeyBoard.AutoSize = true;
            this.cbxKeyBoard.Location = new System.Drawing.Point(601, 520);
            this.cbxKeyBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxKeyBoard.Name = "cbxKeyBoard";
            this.cbxKeyBoard.Size = new System.Drawing.Size(156, 24);
            this.cbxKeyBoard.TabIndex = 7;
            this.cbxKeyBoard.Text = "Keyboard remote";
            this.cbxKeyBoard.UseVisualStyleBackColor = true;
            this.cbxKeyBoard.CheckedChanged += new System.EventHandler(this.cbxKeyBoard_CheckedChanged);
            // 
            // RemoteScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.cbxKeyBoard);
            this.Controls.Add(this.cbxMouse);
            this.Controls.Add(this.picShowScreen);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RemoteScreenForm";
            this.Text = "RemoteScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteScreenForm_FormClosed);
            this.SizeChanged += new System.EventHandler(this.RemoteScreenForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoteScreenForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RemoteScreenForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picShowScreen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShowScreen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbIP;
        private System.Windows.Forms.ToolStripStatusLabel lbSize;
        private System.Windows.Forms.ToolStripStatusLabel lbMouseMove;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.CheckBox cbxMouse;
        private System.Windows.Forms.CheckBox cbxKeyBoard;
    }
}

