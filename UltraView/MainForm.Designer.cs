namespace UltraView
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
            this.tabTypeConnect = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMyIP = new System.Windows.Forms.TextBox();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShareScreen2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.txtHeight2 = new System.Windows.Forms.TextBox();
            this.txtWidth2 = new System.Windows.Forms.TextBox();
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTypeConnect.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTypeConnect
            // 
            this.tabTypeConnect.Controls.Add(this.tabPage1);
            this.tabTypeConnect.Controls.Add(this.tabPage2);
            this.tabTypeConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTypeConnect.Location = new System.Drawing.Point(0, 0);
            this.tabTypeConnect.Name = "tabTypeConnect";
            this.tabTypeConnect.SelectedIndex = 0;
            this.tabTypeConnect.Size = new System.Drawing.Size(581, 353);
            this.tabTypeConnect.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnOpenConnect);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMyIP);
            this.tabPage1.Controls.Add(this.txtMyPort);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Open Connect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waiting other device connect and share screen to your device.";
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.Location = new System.Drawing.Point(197, 217);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(120, 40);
            this.btnOpenConnect.TabIndex = 6;
            this.btnOpenConnect.Text = "Open Connect";
            this.btnOpenConnect.UseVisualStyleBackColor = true;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Connect";
            // 
            // txtMyIP
            // 
            this.txtMyIP.Location = new System.Drawing.Point(179, 109);
            this.txtMyIP.Name = "txtMyIP";
            this.txtMyIP.ReadOnly = true;
            this.txtMyIP.Size = new System.Drawing.Size(183, 22);
            this.txtMyIP.TabIndex = 1;
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(179, 153);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(183, 22);
            this.txtMyPort.TabIndex = 4;
            this.txtMyPort.Text = "1999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "My IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnShareScreen2);
            this.tabPage2.Controls.Add(this.btnConnect2);
            this.tabPage2.Controls.Add(this.txtHeight2);
            this.tabPage2.Controls.Add(this.txtWidth2);
            this.tabPage2.Controls.Add(this.txtPort2);
            this.tabPage2.Controls.Add(this.txtIP2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connect To Other Device";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(344, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "If you can\'t see full screen please type your screen....";
            // 
            // btnShareScreen2
            // 
            this.btnShareScreen2.Location = new System.Drawing.Point(261, 252);
            this.btnShareScreen2.Name = "btnShareScreen2";
            this.btnShareScreen2.Size = new System.Drawing.Size(200, 30);
            this.btnShareScreen2.TabIndex = 10;
            this.btnShareScreen2.Text = "Share your screen";
            this.btnShareScreen2.UseVisualStyleBackColor = true;
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(120, 252);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(100, 30);
            this.btnConnect2.TabIndex = 9;
            this.btnConnect2.Text = "Connect";
            this.btnConnect2.UseVisualStyleBackColor = true;
            // 
            // txtHeight2
            // 
            this.txtHeight2.Location = new System.Drawing.Point(348, 176);
            this.txtHeight2.Name = "txtHeight2";
            this.txtHeight2.Size = new System.Drawing.Size(61, 22);
            this.txtHeight2.TabIndex = 8;
            // 
            // txtWidth2
            // 
            this.txtWidth2.Location = new System.Drawing.Point(221, 176);
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.Size = new System.Drawing.Size(61, 22);
            this.txtWidth2.TabIndex = 7;
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(221, 93);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(197, 22);
            this.txtPort2.TabIndex = 6;
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(221, 58);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(197, 22);
            this.txtIP2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Connect To Other";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 353);
            this.Controls.Add(this.tabTypeConnect);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabTypeConnect.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTypeConnect;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMyIP;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShareScreen2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.TextBox txtHeight2;
        private System.Windows.Forms.TextBox txtWidth2;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}