namespace ShowMyScreen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShowCursor = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbBigCursor = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbScreens = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(224, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(107, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(50, 16);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(106, 20);
            this.tbUser.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 372);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Начать";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(349, 372);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 5;
            this.btStop.Text = "Остановить";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(372, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(48, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "9191";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Порт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Веб-страница:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(78, 52);
            this.tbURL.Name = "tbURL";
            this.tbURL.ReadOnly = true;
            this.tbURL.Size = new System.Drawing.Size(342, 20);
            this.tbURL.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(136, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "КонтинентСвободы.рф";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Right click the icon then select Exit to close the application.";
            this.notifyIcon1.BalloonTipTitle = "ShowMyScreen";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ShowMyScreen";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 54);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cbShowCursor
            // 
            this.cbShowCursor.AutoSize = true;
            this.cbShowCursor.Location = new System.Drawing.Point(189, 89);
            this.cbShowCursor.Name = "cbShowCursor";
            this.cbShowCursor.Size = new System.Drawing.Size(127, 17);
            this.cbShowCursor.TabIndex = 11;
            this.cbShowCursor.Text = "Показывать курсор";
            this.cbShowCursor.UseVisualStyleBackColor = true;
            this.cbShowCursor.CheckedChanged += new System.EventHandler(this.cbShowCursor_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cbBigCursor
            // 
            this.cbBigCursor.AutoSize = true;
            this.cbBigCursor.Enabled = false;
            this.cbBigCursor.Location = new System.Drawing.Point(315, 89);
            this.cbBigCursor.Name = "cbBigCursor";
            this.cbBigCursor.Size = new System.Drawing.Size(109, 17);
            this.cbBigCursor.TabIndex = 12;
            this.cbBigCursor.Text = "Большой курсор";
            this.cbBigCursor.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Экран:";
            // 
            // cbScreens
            // 
            this.cbScreens.FormattingEnabled = true;
            this.cbScreens.Location = new System.Drawing.Point(62, 87);
            this.cbScreens.Name = "cbScreens";
            this.cbScreens.Size = new System.Drawing.Size(121, 21);
            this.cbScreens.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(15, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbScreens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.cbBigCursor);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbShowCursor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покажи свой экран v1.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbShowCursor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbBigCursor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbScreens;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

