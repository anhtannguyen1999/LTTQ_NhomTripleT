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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.appdata = new UltraView.appdata();
            this.tabTypeConnect = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtHeight2 = new System.Windows.Forms.TextBox();
            this.txtWidth2 = new System.Windows.Forms.TextBox();
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtMyIP = new System.Windows.Forms.TextBox();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShareScreen2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Vietnames = new System.Windows.Forms.ToolStripMenuItem();
            this.English = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.appdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.appdata)).BeginInit();
            this.tabTypeConnect.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appdataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // appdata
            // 
            this.appdata.DataSetName = "appdata";
            this.appdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabTypeConnect
            // 
            this.tabTypeConnect.Controls.Add(this.tabPage1);
            this.tabTypeConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTypeConnect.Location = new System.Drawing.Point(0, 32);
            this.tabTypeConnect.Name = "tabTypeConnect";
            this.tabTypeConnect.SelectedIndex = 0;
            this.tabTypeConnect.Size = new System.Drawing.Size(1047, 418);
            this.tabTypeConnect.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.txtHeight2);
            this.tabPage1.Controls.Add(this.txtWidth2);
            this.tabPage1.Controls.Add(this.txtPort2);
            this.tabPage1.Controls.Add(this.txtIP2);
            this.tabPage1.Controls.Add(this.txtMyIP);
            this.tabPage1.Controls.Add(this.txtMyPort);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnShareScreen2);
            this.tabPage1.Controls.Add(this.btnConnect2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnOpenConnect);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Open Connect";
            // 
            // txtHeight2
            // 
            this.txtHeight2.Location = new System.Drawing.Point(776, 103);
            this.txtHeight2.Name = "txtHeight2";
            this.txtHeight2.Size = new System.Drawing.Size(61, 22);
            this.txtHeight2.TabIndex = 21;
            // 
            // txtWidth2
            // 
            this.txtWidth2.Location = new System.Drawing.Point(632, 108);
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.Size = new System.Drawing.Size(61, 22);
            this.txtWidth2.TabIndex = 19;
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(575, 199);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(238, 22);
            this.txtPort2.TabIndex = 16;
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(575, 164);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(238, 22);
            this.txtIP2.TabIndex = 14;
            // 
            // txtMyIP
            // 
            this.txtMyIP.Location = new System.Drawing.Point(119, 149);
            this.txtMyIP.Name = "txtMyIP";
            this.txtMyIP.ReadOnly = true;
            this.txtMyIP.Size = new System.Drawing.Size(183, 22);
            this.txtMyIP.TabIndex = 1;
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(119, 206);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(183, 22);
            this.txtMyPort.TabIndex = 4;
            this.txtMyPort.Text = "1999";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(712, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(572, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Width";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(481, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "If you can\'t see full screen please type your screen....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Partner IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(570, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Connect To Other";
            // 
            // btnShareScreen2
            // 
            this.btnShareScreen2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShareScreen2.Location = new System.Drawing.Point(592, 327);
            this.btnShareScreen2.Name = "btnShareScreen2";
            this.btnShareScreen2.Size = new System.Drawing.Size(200, 30);
            this.btnShareScreen2.TabIndex = 11;
            this.btnShareScreen2.Text = "SHARE YOUR SCREEN";
            this.btnShareScreen2.UseVisualStyleBackColor = false;
            this.btnShareScreen2.Click += new System.EventHandler(this.btnShareScreen2_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.AutoSize = true;
            this.btnConnect2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConnect2.BackgroundImage = global::UltraView.Properties.Resources.ConnectBT;
            this.btnConnect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect2.Location = new System.Drawing.Point(604, 250);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(178, 52);
            this.btnConnect2.TabIndex = 10;
            this.btnConnect2.Text = "CONNECT";
            this.btnConnect2.UseVisualStyleBackColor = false;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 44);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waiting other device connect and share screen to your device.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenConnect.BackgroundImage = global::UltraView.Properties.Resources.ConnectBT1;
            this.btnOpenConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenConnect.Location = new System.Drawing.Point(119, 250);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(182, 50);
            this.btnOpenConnect.TabIndex = 6;
            this.btnOpenConnect.Text = "OPEN CONNECT";
            this.btnOpenConnect.UseVisualStyleBackColor = false;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Connect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "My IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "My Port:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1047, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionToolStripMenuItem.Image")));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vietnames,
            this.English});
            this.languagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("languagesToolStripMenuItem.Image")));
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.languagesToolStripMenuItem.Text = "Language";
            this.languagesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Vietnames
            // 
            this.Vietnames.Name = "Vietnames";
            this.Vietnames.Size = new System.Drawing.Size(151, 26);
            this.Vietnames.Text = "Tiếng Việt";
            this.Vietnames.CheckedChanged += new System.EventHandler(this.Vietnames_CheckedChanged);
            this.Vietnames.Click += new System.EventHandler(this.Vietnames_Click);
            // 
            // English
            // 
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(151, 26);
            this.English.Text = "English";
            this.English.CheckedChanged += new System.EventHandler(this.English_CheckedChanged);
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::UltraView.Properties.Resources.UpdateBT;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(115, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(52, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1047, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 20);
            this.lbStatus.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabTypeConnect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Untraview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appdata)).EndInit();
            this.tabTypeConnect.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appdataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabTypeConnect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Vietnames;
        private System.Windows.Forms.ToolStripMenuItem English;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.BindingSource appdataBindingSource1;
        private appdata appdata;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtHeight2;
        private System.Windows.Forms.TextBox txtWidth2;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtMyIP;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShareScreen2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}