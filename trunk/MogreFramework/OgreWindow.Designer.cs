namespace MogreFramework
{
    partial class OgreWindow
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
                CloseInterfaces();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgreWindow));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbChatProximity = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbTextToSend = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.cbAutoScrollConsole = new System.Windows.Forms.CheckBox();
            this.btnCopyAllLinesConsole = new System.Windows.Forms.Button();
            this.btnCopySelectedLinesConsole = new System.Windows.Forms.Button();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.btnConsole = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAutoScrollLog = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbPluginsActive = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCpy3 = new System.Windows.Forms.Button();
            this.tbStatus3 = new System.Windows.Forms.TextBox();
            this.btnCpy2 = new System.Windows.Forms.Button();
            this.tbStatus2 = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnCpy1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(570, 109);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lbChatProximity);
            this.tabPage5.Controls.Add(this.btnSend);
            this.tabPage5.Controls.Add(this.tbTextToSend);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(562, 83);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Chat";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbChatProximity
            // 
            this.lbChatProximity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChatProximity.Enabled = false;
            this.lbChatProximity.FormattingEnabled = true;
            this.lbChatProximity.Location = new System.Drawing.Point(6, 6);
            this.lbChatProximity.Name = "lbChatProximity";
            this.lbChatProximity.Size = new System.Drawing.Size(550, 43);
            this.lbChatProximity.TabIndex = 3;
            this.lbChatProximity.SizeChanged += new System.EventHandler(this.lbChatProximity_SizeChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(481, 54);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbTextToSend
            // 
            this.tbTextToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextToSend.Location = new System.Drawing.Point(6, 52);
            this.tbTextToSend.Multiline = true;
            this.tbTextToSend.Name = "tbTextToSend";
            this.tbTextToSend.Size = new System.Drawing.Size(469, 25);
            this.tbTextToSend.TabIndex = 1;
            this.tbTextToSend.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbTextToSend_PreviewKeyDown);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.cbAutoScrollConsole);
            this.tabPage8.Controls.Add(this.btnCopyAllLinesConsole);
            this.tabPage8.Controls.Add(this.btnCopySelectedLinesConsole);
            this.tabPage8.Controls.Add(this.lbConsole);
            this.tabPage8.Controls.Add(this.btnConsole);
            this.tabPage8.Controls.Add(this.tbConsole);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(562, 83);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Console";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // cbAutoScrollConsole
            // 
            this.cbAutoScrollConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoScrollConsole.AutoSize = true;
            this.cbAutoScrollConsole.Checked = true;
            this.cbAutoScrollConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoScrollConsole.Location = new System.Drawing.Point(452, 53);
            this.cbAutoScrollConsole.Name = "cbAutoScrollConsole";
            this.cbAutoScrollConsole.Size = new System.Drawing.Size(77, 17);
            this.cbAutoScrollConsole.TabIndex = 9;
            this.cbAutoScrollConsole.Text = "Auto Scroll";
            this.cbAutoScrollConsole.UseVisualStyleBackColor = true;
            // 
            // btnCopyAllLinesConsole
            // 
            this.btnCopyAllLinesConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAllLinesConsole.Location = new System.Drawing.Point(452, 5);
            this.btnCopyAllLinesConsole.Name = "btnCopyAllLinesConsole";
            this.btnCopyAllLinesConsole.Size = new System.Drawing.Size(104, 20);
            this.btnCopyAllLinesConsole.TabIndex = 8;
            this.btnCopyAllLinesConsole.Text = "Copy All Lines";
            this.btnCopyAllLinesConsole.UseVisualStyleBackColor = true;
            this.btnCopyAllLinesConsole.Click += new System.EventHandler(this.btnCopyAllLinesConsole_Click);
            // 
            // btnCopySelectedLinesConsole
            // 
            this.btnCopySelectedLinesConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySelectedLinesConsole.Location = new System.Drawing.Point(452, 31);
            this.btnCopySelectedLinesConsole.Name = "btnCopySelectedLinesConsole";
            this.btnCopySelectedLinesConsole.Size = new System.Drawing.Size(104, 20);
            this.btnCopySelectedLinesConsole.TabIndex = 7;
            this.btnCopySelectedLinesConsole.Text = "Copy Selected Lines";
            this.btnCopySelectedLinesConsole.UseVisualStyleBackColor = true;
            this.btnCopySelectedLinesConsole.Click += new System.EventHandler(this.btnCopySelectedLinesConsole_Click);
            // 
            // lbConsole
            // 
            this.lbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(6, 5);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(440, 43);
            this.lbConsole.TabIndex = 6;
            this.lbConsole.SizeChanged += new System.EventHandler(this.lbConsole_SizeChanged);
            // 
            // btnConsole
            // 
            this.btnConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsole.Location = new System.Drawing.Point(371, 53);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(75, 23);
            this.btnConsole.TabIndex = 5;
            this.btnConsole.TabStop = false;
            this.btnConsole.Text = "Enter";
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.Location = new System.Drawing.Point(6, 51);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(359, 25);
            this.tbConsole.TabIndex = 4;
            this.tbConsole.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbConsole_PreviewKeyDown);
            // 
            // renderBox
            // 
            this.renderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.renderBox.Location = new System.Drawing.Point(3, 3);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(564, 128);
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
            this.renderBox.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.renderBox.Click += new System.EventHandler(this.renderBox_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbAutoScrollLog);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // cbAutoScrollLog
            // 
            this.cbAutoScrollLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoScrollLog.AutoSize = true;
            this.cbAutoScrollLog.Checked = true;
            this.cbAutoScrollLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoScrollLog.Location = new System.Drawing.Point(440, 228);
            this.cbAutoScrollLog.Name = "cbAutoScrollLog";
            this.cbAutoScrollLog.Size = new System.Drawing.Size(77, 17);
            this.cbAutoScrollLog.TabIndex = 4;
            this.cbAutoScrollLog.Text = "Auto Scroll";
            this.cbAutoScrollLog.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(440, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy All Lines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(440, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy Selected Lines";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1200;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(428, 210);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 101);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location/Speed";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 171);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 285);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "3D";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.renderBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(570, 247);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox4);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(582, 259);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "Plugins";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbPluginsActive);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 253);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active";
            // 
            // lbPluginsActive
            // 
            this.lbPluginsActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPluginsActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPluginsActive.FormattingEnabled = true;
            this.lbPluginsActive.HorizontalExtent = 1200;
            this.lbPluginsActive.HorizontalScrollbar = true;
            this.lbPluginsActive.Location = new System.Drawing.Point(14, 25);
            this.lbPluginsActive.Name = "lbPluginsActive";
            this.lbPluginsActive.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPluginsActive.Size = new System.Drawing.Size(235, 210);
            this.lbPluginsActive.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCpy3);
            this.tabPage3.Controls.Add(this.tbStatus3);
            this.tabPage3.Controls.Add(this.btnCpy2);
            this.tabPage3.Controls.Add(this.tbStatus2);
            this.tabPage3.Controls.Add(this.tbStatus);
            this.tabPage3.Controls.Add(this.btnCpy1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "status";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCpy3
            // 
            this.btnCpy3.Location = new System.Drawing.Point(542, 66);
            this.btnCpy3.Name = "btnCpy3";
            this.btnCpy3.Size = new System.Drawing.Size(32, 23);
            this.btnCpy3.TabIndex = 12;
            this.btnCpy3.Text = "cpy";
            this.btnCpy3.UseVisualStyleBackColor = true;
            this.btnCpy3.Click += new System.EventHandler(this.btnCpy3_Click);
            // 
            // tbStatus3
            // 
            this.tbStatus3.Location = new System.Drawing.Point(263, 68);
            this.tbStatus3.Name = "tbStatus3";
            this.tbStatus3.Size = new System.Drawing.Size(273, 20);
            this.tbStatus3.TabIndex = 11;
            this.tbStatus3.TabStop = false;
            // 
            // btnCpy2
            // 
            this.btnCpy2.Location = new System.Drawing.Point(542, 40);
            this.btnCpy2.Name = "btnCpy2";
            this.btnCpy2.Size = new System.Drawing.Size(32, 23);
            this.btnCpy2.TabIndex = 10;
            this.btnCpy2.Text = "cpy";
            this.btnCpy2.UseVisualStyleBackColor = true;
            this.btnCpy2.Click += new System.EventHandler(this.btnCpy2_Click);
            // 
            // tbStatus2
            // 
            this.tbStatus2.Location = new System.Drawing.Point(263, 42);
            this.tbStatus2.Name = "tbStatus2";
            this.tbStatus2.Size = new System.Drawing.Size(273, 20);
            this.tbStatus2.TabIndex = 9;
            this.tbStatus2.TabStop = false;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(263, 15);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(273, 20);
            this.tbStatus.TabIndex = 8;
            this.tbStatus.TabStop = false;
            // 
            // btnCpy1
            // 
            this.btnCpy1.Location = new System.Drawing.Point(542, 13);
            this.btnCpy1.Name = "btnCpy1";
            this.btnCpy1.Size = new System.Drawing.Size(32, 23);
            this.btnCpy1.TabIndex = 8;
            this.btnCpy1.Text = "cpy";
            this.btnCpy1.UseVisualStyleBackColor = true;
            this.btnCpy1.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbCapture);
            this.groupBox1.Location = new System.Drawing.Point(6, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture";
            // 
            // pbCapture
            // 
            this.pbCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCapture.Location = new System.Drawing.Point(6, 19);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(239, 126);
            this.pbCapture.TabIndex = 8;
            this.pbCapture.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 259);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "controls";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pictureBox6);
            this.tabPage6.Controls.Add(this.pictureBox5);
            this.tabPage6.Controls.Add(this.pictureBox4);
            this.tabPage6.Controls.Add(this.pictureBox3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(582, 259);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "About";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MogreFramework.Properties.Resources.main_logo;
            this.pictureBox6.Location = new System.Drawing.Point(156, 210);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox5.Image = global::MogreFramework.Properties.Resources.amd_no_gradient;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(163, 167);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(93, 37);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MogreFramework.Properties.Resources._200px_NET_h_rgb_2;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(56, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 49);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MogreFramework.Properties.Resources.MOGRE;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 100);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // OgreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 320);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(638, 358);
            this.Name = "OgreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OgreWindow_FormClosing);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.PictureBox renderBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbAutoScrollLog;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ListBox lbChatProximity;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Button btnCpy1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbPluginsActive;
        private System.Windows.Forms.Button btnCpy2;
        private System.Windows.Forms.TextBox tbStatus2;
        private System.Windows.Forms.Button btnCpy3;
        private System.Windows.Forms.TextBox tbStatus3;
        public System.Windows.Forms.TextBox tbTextToSend;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.CheckBox cbAutoScrollConsole;
        private System.Windows.Forms.Button btnCopyAllLinesConsole;
        private System.Windows.Forms.Button btnCopySelectedLinesConsole;
        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button btnConsole;
        public System.Windows.Forms.TextBox tbConsole;
    }
}