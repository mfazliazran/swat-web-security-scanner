using System.Windows.Forms;

namespace AgWebScanner
{
    partial class FmScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmScanner));
            this.FileScanner = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbFilesExportToPdf = new System.Windows.Forms.RadioButton();
            this.rbFilesExportToText = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.rtbBaseUrl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVirtualFolder = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbListExistingChecks = new System.Windows.Forms.CheckedListBox();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.QuickStart = new System.Windows.Forms.TabPage();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsQuickScanStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbQuickExportToText = new System.Windows.Forms.RadioButton();
            this.btnQuickExport = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.rtb_QuickScanUrl = new System.Windows.Forms.RichTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnQuickStop = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.btnQuickStart = new System.Windows.Forms.Button();
            this.DirScanner = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.rbExportDirsToPdf = new System.Windows.Forms.RadioButton();
            this.rbExportDirsToText = new System.Windows.Forms.RadioButton();
            this.label34 = new System.Windows.Forms.Label();
            this.btnExportDirs = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chblExistingDirScans = new System.Windows.Forms.CheckedListBox();
            this.statusDirScan = new System.Windows.Forms.StatusStrip();
            this.tsDirScanStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnStopDirScan = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnStartDirScan = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.rtbDirScanTarget = new System.Windows.Forms.RichTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.gvDirScanResults = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label50 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveResponseTypes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.chbDirScanAdd = new System.Windows.Forms.CheckBox();
            this.rtbAddFileName = new System.Windows.Forms.TextBox();
            this.rtbAddFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetFileForAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChecksForDelete = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbDirScanEdit = new System.Windows.Forms.CheckBox();
            this.rtbEditFilePath = new System.Windows.Forms.TextBox();
            this.cbAvailableChecks = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetFileForEdit = new System.Windows.Forms.Button();
            this.tpResponseTypes = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tbErrorPageTitle = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbErrorPageBodyText = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chb403_Forbidden = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chb401Unauthorized = new System.Windows.Forms.CheckBox();
            this.chb200Ok = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chb304NotModified = new System.Windows.Forms.CheckBox();
            this.chb202Accepted = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chbMoved301 = new System.Windows.Forms.CheckBox();
            this.chb302Found = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tpWebMethod = new System.Windows.Forms.TabPage();
            this.label40 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbTrace = new System.Windows.Forms.RadioButton();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.tbCookies = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tbRawPost = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbPostUsernameKeys = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbPostUsernameValue = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbPostPasswordValue = new System.Windows.Forms.TextBox();
            this.cbPostPasswordKeys = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbWebLogin = new System.Windows.Forms.TextBox();
            this.tbWebPassword = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tbIbmFile = new System.Windows.Forms.TextBox();
            this.chbIbmEnabled = new System.Windows.Forms.CheckBox();
            this.btnGetIbmFile = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.pageUnEnumerator = new System.Windows.Forms.TabPage();
            this.pageVpnScan = new System.Windows.Forms.TabPage();
            this.pageHTTPScan = new System.Windows.Forms.TabPage();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ofdFilePath = new System.Windows.Forms.OpenFileDialog();
            this.bgDirectoryWorker = new System.ComponentModel.BackgroundWorker();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.bgQuickWorker = new System.ComponentModel.BackgroundWorker();
            this.label43 = new System.Windows.Forms.Label();
            this.FileScanner.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tcTabs.SuspendLayout();
            this.QuickStart.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.DirScanner.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusDirScan.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirScanResults)).BeginInit();
            this.Settings.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpResponseTypes.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tpWebMethod.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileScanner
            // 
            this.FileScanner.BackColor = System.Drawing.Color.Gainsboro;
            this.FileScanner.Controls.Add(this.label11);
            this.FileScanner.Controls.Add(this.groupBox6);
            this.FileScanner.Controls.Add(this.groupBox4);
            this.FileScanner.Controls.Add(this.groupBox5);
            this.FileScanner.Controls.Add(this.groupBox3);
            this.FileScanner.Controls.Add(this.pictureBox1);
            this.FileScanner.Controls.Add(this.chbListExistingChecks);
            this.FileScanner.Controls.Add(this.gvResults);
            this.FileScanner.Controls.Add(this.statusStrip1);
            this.FileScanner.Location = new System.Drawing.Point(4, 26);
            this.FileScanner.Name = "FileScanner";
            this.FileScanner.Padding = new System.Windows.Forms.Padding(3);
            this.FileScanner.Size = new System.Drawing.Size(1010, 545);
            this.FileScanner.TabIndex = 0;
            this.FileScanner.Text = "File Scanner";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "FILE SCANNER";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(864, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 112);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(711, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 112);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan Action";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::AgWebScanner.Properties.Resources.Stop16;
            this.btnStop.Location = new System.Drawing.Point(15, 61);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(28, 26);
            this.btnStop.TabIndex = 25;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStopClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Start Scan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Stop Scan";
            // 
            // btnStart
            // 
            this.btnStart.Image = global::AgWebScanner.Properties.Resources.Play16;
            this.btnStart.Location = new System.Drawing.Point(15, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(28, 26);
            this.btnStart.TabIndex = 23;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbFilesExportToPdf);
            this.groupBox5.Controls.Add(this.rbFilesExportToText);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1164, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 142);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Export";
            // 
            // rbFilesExportToPdf
            // 
            this.rbFilesExportToPdf.AutoSize = true;
            this.rbFilesExportToPdf.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilesExportToPdf.Location = new System.Drawing.Point(59, 66);
            this.rbFilesExportToPdf.Name = "rbFilesExportToPdf";
            this.rbFilesExportToPdf.Size = new System.Drawing.Size(43, 19);
            this.rbFilesExportToPdf.TabIndex = 47;
            this.rbFilesExportToPdf.Text = "PDF";
            this.rbFilesExportToPdf.UseVisualStyleBackColor = true;
            // 
            // rbFilesExportToText
            // 
            this.rbFilesExportToText.AutoSize = true;
            this.rbFilesExportToText.Checked = true;
            this.rbFilesExportToText.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilesExportToText.Location = new System.Drawing.Point(6, 66);
            this.rbFilesExportToText.Name = "rbFilesExportToText";
            this.rbFilesExportToText.Size = new System.Drawing.Size(47, 19);
            this.rbFilesExportToText.TabIndex = 46;
            this.rbFilesExportToText.TabStop = true;
            this.rbFilesExportToText.Text = "Text";
            this.rbFilesExportToText.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Export Results";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(5, 28);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(28, 26);
            this.btnExport.TabIndex = 37;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.rtbBaseUrl);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbVirtualFolder);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(117, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 112);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scan Target";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Gainsboro;
            this.label49.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(15, 24);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(72, 63);
            this.label49.TabIndex = 41;
            this.label49.Text = "ADD\r\nSCAN\r\nTARGET";
            // 
            // rtbBaseUrl
            // 
            this.rtbBaseUrl.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBaseUrl.ForeColor = System.Drawing.Color.Black;
            this.rtbBaseUrl.Location = new System.Drawing.Point(89, 34);
            this.rtbBaseUrl.Name = "rtbBaseUrl";
            this.rtbBaseUrl.Size = new System.Drawing.Size(483, 20);
            this.rtbBaseUrl.TabIndex = 27;
            this.rtbBaseUrl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "URL [http(s)://www.target.com or http(s)://www.target.com/directoryxyz/]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Virtual folder [page_yxz]";
            // 
            // tbVirtualFolder
            // 
            this.tbVirtualFolder.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVirtualFolder.Location = new System.Drawing.Point(89, 77);
            this.tbVirtualFolder.Multiline = true;
            this.tbVirtualFolder.Name = "tbVirtualFolder";
            this.tbVirtualFolder.Size = new System.Drawing.Size(483, 20);
            this.tbVirtualFolder.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::AgWebScanner.Properties.Resources._56terg5;
            this.pictureBox1.Location = new System.Drawing.Point(8, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // chbListExistingChecks
            // 
            this.chbListExistingChecks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chbListExistingChecks.CheckOnClick = true;
            this.chbListExistingChecks.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbListExistingChecks.FormattingEnabled = true;
            this.chbListExistingChecks.Location = new System.Drawing.Point(8, 126);
            this.chbListExistingChecks.Name = "chbListExistingChecks";
            this.chbListExistingChecks.Size = new System.Drawing.Size(251, 378);
            this.chbListExistingChecks.TabIndex = 41;
            // 
            // gvResults
            // 
            this.gvResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(267, 126);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(735, 412);
            this.gvResults.TabIndex = 28;
            this.gvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            this.gvResults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvResults_CellFormatting);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1321, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // tsStatusLabel
            // 
            this.tsStatusLabel.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsStatusLabel.Name = "tsStatusLabel";
            this.tsStatusLabel.Size = new System.Drawing.Size(55, 17);
            this.tsStatusLabel.Text = "Ready";
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.QuickStart);
            this.tcTabs.Controls.Add(this.FileScanner);
            this.tcTabs.Controls.Add(this.DirScanner);
            this.tcTabs.Controls.Add(this.pageUnEnumerator);
            this.tcTabs.Controls.Add(this.pageVpnScan);
            this.tcTabs.Controls.Add(this.pageHTTPScan);
            this.tcTabs.Controls.Add(this.Settings);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1018, 575);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcTabs.TabIndex = 0;
            // 
            // QuickStart
            // 
            this.QuickStart.BackColor = System.Drawing.Color.Gainsboro;
            this.QuickStart.Controls.Add(this.label42);
            this.QuickStart.Controls.Add(this.label41);
            this.QuickStart.Controls.Add(this.statusStrip2);
            this.QuickStart.Controls.Add(this.pictureBox4);
            this.QuickStart.Controls.Add(this.label57);
            this.QuickStart.Controls.Add(this.groupBox20);
            this.QuickStart.Controls.Add(this.groupBox19);
            this.QuickStart.Controls.Add(this.groupBox7);
            this.QuickStart.Location = new System.Drawing.Point(4, 26);
            this.QuickStart.Name = "QuickStart";
            this.QuickStart.Size = new System.Drawing.Size(1010, 545);
            this.QuickStart.TabIndex = 3;
            this.QuickStart.Text = "Quick Start";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label42.Location = new System.Drawing.Point(79, 86);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(104, 21);
            this.label42.TabIndex = 60;
            this.label42.Text = "Welcome to";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Gainsboro;
            this.label41.Font = new System.Drawing.Font("Century Gothic", 23.77358F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label41.Location = new System.Drawing.Point(76, 107);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(589, 42);
            this.label41.TabIndex = 59;
            this.label41.Text = "S.W.A.T. (SWISS WEB ATTACK TOOL)";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuickScanStatus});
            this.statusStrip2.Location = new System.Drawing.Point(0, 521);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1010, 24);
            this.statusStrip2.TabIndex = 58;
            this.statusStrip2.Text = "statusQuickScan";
            // 
            // tsQuickScanStatus
            // 
            this.tsQuickScanStatus.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsQuickScanStatus.Name = "tsQuickScanStatus";
            this.tsQuickScanStatus.Size = new System.Drawing.Size(55, 19);
            this.tsQuickScanStatus.Text = "Ready";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = global::AgWebScanner.Properties.Resources._56terg5;
            this.pictureBox4.Location = new System.Drawing.Point(83, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 135);
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label57.Location = new System.Drawing.Point(228, 212);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(93, 17);
            this.label57.TabIndex = 56;
            this.label57.Text = "QUICK SCAN ";
            this.label57.Click += new System.EventHandler(this.label57_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label55);
            this.groupBox20.Controls.Add(this.radioButton1);
            this.groupBox20.Controls.Add(this.rbQuickExportToText);
            this.groupBox20.Controls.Add(this.btnQuickExport);
            this.groupBox20.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox20.Location = new System.Drawing.Point(228, 340);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(309, 65);
            this.groupBox20.TabIndex = 50;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Export";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(53, 27);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(94, 17);
            this.label55.TabIndex = 46;
            this.label55.Text = "Export Results";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(222, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 19);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.Text = "PDF";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbQuickExportToText
            // 
            this.rbQuickExportToText.AutoSize = true;
            this.rbQuickExportToText.Checked = true;
            this.rbQuickExportToText.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuickExportToText.Location = new System.Drawing.Point(169, 26);
            this.rbQuickExportToText.Name = "rbQuickExportToText";
            this.rbQuickExportToText.Size = new System.Drawing.Size(47, 19);
            this.rbQuickExportToText.TabIndex = 44;
            this.rbQuickExportToText.TabStop = true;
            this.rbQuickExportToText.Text = "Text";
            this.rbQuickExportToText.UseVisualStyleBackColor = true;
            // 
            // btnQuickExport
            // 
            this.btnQuickExport.Image = ((System.Drawing.Image)(resources.GetObject("btnQuickExport.Image")));
            this.btnQuickExport.Location = new System.Drawing.Point(20, 23);
            this.btnQuickExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickExport.Name = "btnQuickExport";
            this.btnQuickExport.Size = new System.Drawing.Size(28, 26);
            this.btnQuickExport.TabIndex = 37;
            this.btnQuickExport.UseVisualStyleBackColor = true;
            this.btnQuickExport.Click += new System.EventHandler(this.btnQuickExport_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label53);
            this.groupBox19.Controls.Add(this.rtb_QuickScanUrl);
            this.groupBox19.Controls.Add(this.label54);
            this.groupBox19.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox19.Location = new System.Drawing.Point(228, 232);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(638, 102);
            this.groupBox19.TabIndex = 46;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Scan Target";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Gainsboro;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(11, 26);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(72, 63);
            this.label53.TabIndex = 28;
            this.label53.Text = "ADD\r\nSCAN\r\nTARGET";
            // 
            // rtb_QuickScanUrl
            // 
            this.rtb_QuickScanUrl.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_QuickScanUrl.ForeColor = System.Drawing.Color.Black;
            this.rtb_QuickScanUrl.Location = new System.Drawing.Point(84, 52);
            this.rtb_QuickScanUrl.Name = "rtb_QuickScanUrl";
            this.rtb_QuickScanUrl.Size = new System.Drawing.Size(541, 31);
            this.rtb_QuickScanUrl.TabIndex = 27;
            this.rtb_QuickScanUrl.Text = "";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(81, 27);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(170, 15);
            this.label54.TabIndex = 24;
            this.label54.Text = "URL [http(s)://www.target.com]";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnQuickStop);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.label52);
            this.groupBox7.Controls.Add(this.btnQuickStart);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(543, 340);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(323, 65);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Scan Action";
            // 
            // btnQuickStop
            // 
            this.btnQuickStop.Image = global::AgWebScanner.Properties.Resources.Stop16;
            this.btnQuickStop.Location = new System.Drawing.Point(163, 23);
            this.btnQuickStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickStop.Name = "btnQuickStop";
            this.btnQuickStop.Size = new System.Drawing.Size(28, 26);
            this.btnQuickStop.TabIndex = 25;
            this.btnQuickStop.UseVisualStyleBackColor = true;
            this.btnQuickStop.Click += new System.EventHandler(this.btnQuickStop_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(73, 28);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(72, 17);
            this.label51.TabIndex = 41;
            this.label51.Text = "Start Scan";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(197, 28);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(72, 17);
            this.label52.TabIndex = 42;
            this.label52.Text = "Stop Scan";
            // 
            // btnQuickStart
            // 
            this.btnQuickStart.Image = global::AgWebScanner.Properties.Resources.Play16;
            this.btnQuickStart.Location = new System.Drawing.Point(40, 23);
            this.btnQuickStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuickStart.Name = "btnQuickStart";
            this.btnQuickStart.Size = new System.Drawing.Size(28, 26);
            this.btnQuickStart.TabIndex = 23;
            this.btnQuickStart.UseVisualStyleBackColor = true;
            this.btnQuickStart.Click += new System.EventHandler(this.btnQuickStart_Click);
            // 
            // DirScanner
            // 
            this.DirScanner.BackColor = System.Drawing.Color.Gainsboro;
            this.DirScanner.Controls.Add(this.groupBox15);
            this.DirScanner.Controls.Add(this.label35);
            this.DirScanner.Controls.Add(this.groupBox14);
            this.DirScanner.Controls.Add(this.pictureBox2);
            this.DirScanner.Controls.Add(this.chblExistingDirScans);
            this.DirScanner.Controls.Add(this.statusDirScan);
            this.DirScanner.Controls.Add(this.groupBox12);
            this.DirScanner.Controls.Add(this.groupBox13);
            this.DirScanner.Controls.Add(this.gvDirScanResults);
            this.DirScanner.Location = new System.Drawing.Point(4, 26);
            this.DirScanner.Name = "DirScanner";
            this.DirScanner.Padding = new System.Windows.Forms.Padding(3);
            this.DirScanner.Size = new System.Drawing.Size(1010, 545);
            this.DirScanner.TabIndex = 2;
            this.DirScanner.Text = "Directory scanner";
            // 
            // groupBox15
            // 
            this.groupBox15.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox15.Controls.Add(this.button4);
            this.groupBox15.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(1212, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(110, 140);
            this.groupBox15.TabIndex = 53;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Help";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 52;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Gainsboro;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(8, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(94, 17);
            this.label35.TabIndex = 51;
            this.label35.Text = "DIR SCANNER";
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Controls.Add(this.rbExportDirsToPdf);
            this.groupBox14.Controls.Add(this.rbExportDirsToText);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Controls.Add(this.btnExportDirs);
            this.groupBox14.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(858, 8);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(144, 112);
            this.groupBox14.TabIndex = 49;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Export";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(45, 33);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(94, 17);
            this.label36.TabIndex = 46;
            this.label36.Text = "Export Results";
            // 
            // rbExportDirsToPdf
            // 
            this.rbExportDirsToPdf.AutoSize = true;
            this.rbExportDirsToPdf.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExportDirsToPdf.Location = new System.Drawing.Point(84, 66);
            this.rbExportDirsToPdf.Name = "rbExportDirsToPdf";
            this.rbExportDirsToPdf.Size = new System.Drawing.Size(43, 19);
            this.rbExportDirsToPdf.TabIndex = 45;
            this.rbExportDirsToPdf.Text = "PDF";
            this.rbExportDirsToPdf.UseVisualStyleBackColor = true;
            // 
            // rbExportDirsToText
            // 
            this.rbExportDirsToText.AutoSize = true;
            this.rbExportDirsToText.Checked = true;
            this.rbExportDirsToText.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExportDirsToText.Location = new System.Drawing.Point(20, 66);
            this.rbExportDirsToText.Name = "rbExportDirsToText";
            this.rbExportDirsToText.Size = new System.Drawing.Size(47, 19);
            this.rbExportDirsToText.TabIndex = 44;
            this.rbExportDirsToText.TabStop = true;
            this.rbExportDirsToText.Text = "Text";
            this.rbExportDirsToText.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(270, 33);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 17);
            this.label34.TabIndex = 43;
            this.label34.Text = "Export Results";
            // 
            // btnExportDirs
            // 
            this.btnExportDirs.Image = ((System.Drawing.Image)(resources.GetObject("btnExportDirs.Image")));
            this.btnExportDirs.Location = new System.Drawing.Point(12, 29);
            this.btnExportDirs.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportDirs.Name = "btnExportDirs";
            this.btnExportDirs.Size = new System.Drawing.Size(28, 26);
            this.btnExportDirs.TabIndex = 37;
            this.btnExportDirs.UseVisualStyleBackColor = true;
            this.btnExportDirs.Click += new System.EventHandler(this.btnExportDirs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::AgWebScanner.Properties.Resources._56terg5;
            this.pictureBox2.Location = new System.Drawing.Point(8, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // chblExistingDirScans
            // 
            this.chblExistingDirScans.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chblExistingDirScans.CheckOnClick = true;
            this.chblExistingDirScans.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chblExistingDirScans.FormattingEnabled = true;
            this.chblExistingDirScans.Location = new System.Drawing.Point(8, 126);
            this.chblExistingDirScans.Name = "chblExistingDirScans";
            this.chblExistingDirScans.Size = new System.Drawing.Size(251, 361);
            this.chblExistingDirScans.TabIndex = 48;
            // 
            // statusDirScan
            // 
            this.statusDirScan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusDirScan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDirScanStatusLabel});
            this.statusDirScan.Location = new System.Drawing.Point(3, 518);
            this.statusDirScan.Name = "statusDirScan";
            this.statusDirScan.Size = new System.Drawing.Size(1004, 24);
            this.statusDirScan.TabIndex = 47;
            this.statusDirScan.Text = "statusStrip2";
            // 
            // tsDirScanStatusLabel
            // 
            this.tsDirScanStatusLabel.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsDirScanStatusLabel.Name = "tsDirScanStatusLabel";
            this.tsDirScanStatusLabel.Size = new System.Drawing.Size(55, 19);
            this.tsDirScanStatusLabel.Text = "Ready";
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox12.Controls.Add(this.btnStopDirScan);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.btnStartDirScan);
            this.groupBox12.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(711, 8);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(141, 112);
            this.groupBox12.TabIndex = 46;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Scan Action";
            // 
            // btnStopDirScan
            // 
            this.btnStopDirScan.Image = global::AgWebScanner.Properties.Resources.Stop16;
            this.btnStopDirScan.Location = new System.Drawing.Point(15, 63);
            this.btnStopDirScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopDirScan.Name = "btnStopDirScan";
            this.btnStopDirScan.Size = new System.Drawing.Size(28, 26);
            this.btnStopDirScan.TabIndex = 25;
            this.btnStopDirScan.UseVisualStyleBackColor = true;
            this.btnStopDirScan.Click += new System.EventHandler(this.btnStopDirScan_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(48, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 17);
            this.label31.TabIndex = 41;
            this.label31.Text = "Start Scan";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(49, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 17);
            this.label32.TabIndex = 42;
            this.label32.Text = "Stop Scan";
            // 
            // btnStartDirScan
            // 
            this.btnStartDirScan.Image = global::AgWebScanner.Properties.Resources.Play16;
            this.btnStartDirScan.Location = new System.Drawing.Point(15, 27);
            this.btnStartDirScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartDirScan.Name = "btnStartDirScan";
            this.btnStartDirScan.Size = new System.Drawing.Size(28, 26);
            this.btnStartDirScan.TabIndex = 23;
            this.btnStartDirScan.UseVisualStyleBackColor = true;
            this.btnStartDirScan.Click += new System.EventHandler(this.btnStartDirScan_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox13.Controls.Add(this.label48);
            this.groupBox13.Controls.Add(this.rtbDirScanTarget);
            this.groupBox13.Controls.Add(this.label33);
            this.groupBox13.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(117, 8);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(588, 112);
            this.groupBox13.TabIndex = 45;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Scan Target";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Gainsboro;
            this.label48.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(15, 24);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 63);
            this.label48.TabIndex = 28;
            this.label48.Text = "ADD\r\nSCAN\r\nTARGET";
            // 
            // rtbDirScanTarget
            // 
            this.rtbDirScanTarget.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDirScanTarget.ForeColor = System.Drawing.Color.Black;
            this.rtbDirScanTarget.Location = new System.Drawing.Point(89, 53);
            this.rtbDirScanTarget.Name = "rtbDirScanTarget";
            this.rtbDirScanTarget.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbDirScanTarget.Size = new System.Drawing.Size(459, 20);
            this.rtbDirScanTarget.TabIndex = 27;
            this.rtbDirScanTarget.Text = "";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(86, 33);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(170, 15);
            this.label33.TabIndex = 24;
            this.label33.Text = "URL [http(s)://www.target.com]";
            // 
            // gvDirScanResults
            // 
            this.gvDirScanResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvDirScanResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDirScanResults.Location = new System.Drawing.Point(267, 126);
            this.gvDirScanResults.Name = "gvDirScanResults";
            this.gvDirScanResults.Size = new System.Drawing.Size(735, 392);
            this.gvDirScanResults.TabIndex = 44;
            this.gvDirScanResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDirScanResults_CellClick);
            this.gvDirScanResults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvDirScanResults_DataBindingComplete);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings.Controls.Add(this.splitContainer1);
            this.Settings.Location = new System.Drawing.Point(4, 26);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1010, 545);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "General Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.label50);
            this.splitContainer1.Panel1.Controls.Add(this.label39);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox17);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(1004, 539);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Century Gothic", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.Location = new System.Drawing.Point(12, 11);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(139, 36);
            this.label50.TabIndex = 55;
            this.label50.Text = "SETTINGS";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(14, 53);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(183, 42);
            this.label39.TabIndex = 2;
            this.label39.Text = "DIRECTORY SCANNER\r\nFILE SCANNER ";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label43);
            this.groupBox17.Controls.Add(this.label13);
            this.groupBox17.Controls.Add(this.btnSaveResponseTypes);
            this.groupBox17.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox17.Location = new System.Drawing.Point(203, 11);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(786, 84);
            this.groupBox17.TabIndex = 32;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Save";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(722, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 51);
            this.label13.TabIndex = 20;
            this.label13.Text = "Click\r\nhere to \r\nSave";
            // 
            // btnSaveResponseTypes
            // 
            this.btnSaveResponseTypes.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveResponseTypes.Image")));
            this.btnSaveResponseTypes.Location = new System.Drawing.Point(656, 25);
            this.btnSaveResponseTypes.Name = "btnSaveResponseTypes";
            this.btnSaveResponseTypes.Size = new System.Drawing.Size(53, 53);
            this.btnSaveResponseTypes.TabIndex = 4;
            this.btnSaveResponseTypes.UseVisualStyleBackColor = true;
            this.btnSaveResponseTypes.Click += new System.EventHandler(this.btnSaveCheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Unregister app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tpResponseTypes);
            this.tabControl1.Controls.Add(this.tpWebMethod);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(8, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 354);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(973, 326);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Checks";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.chbDirScanAdd);
            this.groupBox1.Controls.Add(this.rtbAddFileName);
            this.groupBox1.Controls.Add(this.rtbAddFilePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSetFileForAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 244);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new check";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Gainsboro;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(15, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(73, 63);
            this.label37.TabIndex = 26;
            this.label37.Text = "ADD\r\nNEW\r\nCHECK  ";
            // 
            // chbDirScanAdd
            // 
            this.chbDirScanAdd.AutoSize = true;
            this.chbDirScanAdd.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbDirScanAdd.Location = new System.Drawing.Point(93, 130);
            this.chbDirScanAdd.Name = "chbDirScanAdd";
            this.chbDirScanAdd.Size = new System.Drawing.Size(325, 21);
            this.chbDirScanAdd.TabIndex = 20;
            this.chbDirScanAdd.Text = "Click here if slelected check is a directory scan";
            this.chbDirScanAdd.UseVisualStyleBackColor = true;
            // 
            // rtbAddFileName
            // 
            this.rtbAddFileName.Location = new System.Drawing.Point(266, 22);
            this.rtbAddFileName.Name = "rtbAddFileName";
            this.rtbAddFileName.Size = new System.Drawing.Size(152, 20);
            this.rtbAddFileName.TabIndex = 18;
            // 
            // rtbAddFilePath
            // 
            this.rtbAddFilePath.Location = new System.Drawing.Point(266, 48);
            this.rtbAddFilePath.Name = "rtbAddFilePath";
            this.rtbAddFilePath.Size = new System.Drawing.Size(152, 20);
            this.rtbAddFilePath.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose Input File";
            // 
            // btnSetFileForAdd
            // 
            this.btnSetFileForAdd.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetFileForAdd.Image = global::AgWebScanner.Properties.Resources.fileb1;
            this.btnSetFileForAdd.Location = new System.Drawing.Point(207, 48);
            this.btnSetFileForAdd.Name = "btnSetFileForAdd";
            this.btnSetFileForAdd.Size = new System.Drawing.Size(53, 20);
            this.btnSetFileForAdd.TabIndex = 3;
            this.btnSetFileForAdd.UseVisualStyleBackColor = true;
            this.btnSetFileForAdd.Click += new System.EventHandler(this.BtnSetFileForAddClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter name for new check";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.cbChecksForDelete);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.btnDelete);
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(452, 136);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(448, 114);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Delete existing check";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(85, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(152, 17);
            this.label23.TabIndex = 29;
            this.label23.Text = "Choose existing check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 63);
            this.label1.TabIndex = 28;
            this.label1.Text = "DELETE\r\nCHECK\r\n ";
            // 
            // cbChecksForDelete
            // 
            this.cbChecksForDelete.FormattingEnabled = true;
            this.cbChecksForDelete.Location = new System.Drawing.Point(266, 23);
            this.cbChecksForDelete.Name = "cbChecksForDelete";
            this.cbChecksForDelete.Size = new System.Drawing.Size(151, 23);
            this.cbChecksForDelete.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(83, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Delete Selected Check";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(361, 52);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 35);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chbDirScanEdit);
            this.groupBox2.Controls.Add(this.rtbEditFilePath);
            this.groupBox2.Controls.Add(this.cbAvailableChecks);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSetFileForEdit);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(452, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit existing check";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Gainsboro;
            this.label38.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(15, 22);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 63);
            this.label38.TabIndex = 27;
            this.label38.Text = "EDIT\r\nCHECK \r\n ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Choose Input File";
            // 
            // chbDirScanEdit
            // 
            this.chbDirScanEdit.AutoSize = true;
            this.chbDirScanEdit.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbDirScanEdit.Location = new System.Drawing.Point(86, 79);
            this.chbDirScanEdit.Name = "chbDirScanEdit";
            this.chbDirScanEdit.Size = new System.Drawing.Size(325, 21);
            this.chbDirScanEdit.TabIndex = 21;
            this.chbDirScanEdit.Text = "Click here if slelected check is a directory scan";
            this.chbDirScanEdit.UseVisualStyleBackColor = true;
            // 
            // rtbEditFilePath
            // 
            this.rtbEditFilePath.Location = new System.Drawing.Point(267, 19);
            this.rtbEditFilePath.Name = "rtbEditFilePath";
            this.rtbEditFilePath.Size = new System.Drawing.Size(151, 20);
            this.rtbEditFilePath.TabIndex = 14;
            // 
            // cbAvailableChecks
            // 
            this.cbAvailableChecks.FormattingEnabled = true;
            this.cbAvailableChecks.Location = new System.Drawing.Point(267, 45);
            this.cbAvailableChecks.Name = "cbAvailableChecks";
            this.cbAvailableChecks.Size = new System.Drawing.Size(151, 23);
            this.cbAvailableChecks.TabIndex = 13;
            this.cbAvailableChecks.SelectionChangeCommitted += new System.EventHandler(this.CbAvailableChecksSelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(83, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Choose existing check";
            // 
            // btnSetFileForEdit
            // 
            this.btnSetFileForEdit.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetFileForEdit.Image = global::AgWebScanner.Properties.Resources.fileb1;
            this.btnSetFileForEdit.Location = new System.Drawing.Point(208, 45);
            this.btnSetFileForEdit.Name = "btnSetFileForEdit";
            this.btnSetFileForEdit.Size = new System.Drawing.Size(53, 21);
            this.btnSetFileForEdit.TabIndex = 7;
            this.btnSetFileForEdit.UseVisualStyleBackColor = true;
            this.btnSetFileForEdit.Click += new System.EventHandler(this.BtnSetFileForEditClick);
            // 
            // tpResponseTypes
            // 
            this.tpResponseTypes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpResponseTypes.Controls.Add(this.groupBox18);
            this.tpResponseTypes.Controls.Add(this.groupBox16);
            this.tpResponseTypes.Location = new System.Drawing.Point(4, 24);
            this.tpResponseTypes.Name = "tpResponseTypes";
            this.tpResponseTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpResponseTypes.Size = new System.Drawing.Size(973, 326);
            this.tpResponseTypes.TabIndex = 0;
            this.tpResponseTypes.Text = "Response Settings";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.tbErrorPageTitle);
            this.groupBox18.Controls.Add(this.label25);
            this.groupBox18.Controls.Add(this.tbErrorPageBodyText);
            this.groupBox18.Controls.Add(this.label24);
            this.groupBox18.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox18.ForeColor = System.Drawing.Color.Black;
            this.groupBox18.Location = new System.Drawing.Point(23, 208);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(877, 87);
            this.groupBox18.TabIndex = 32;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Web Server Custom Error Message";
            // 
            // tbErrorPageTitle
            // 
            this.tbErrorPageTitle.Location = new System.Drawing.Point(201, 29);
            this.tbErrorPageTitle.Name = "tbErrorPageTitle";
            this.tbErrorPageTitle.Size = new System.Drawing.Size(621, 20);
            this.tbErrorPageTitle.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(19, 58);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(152, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Expression within body";
            // 
            // tbErrorPageBodyText
            // 
            this.tbErrorPageBodyText.Location = new System.Drawing.Point(201, 58);
            this.tbErrorPageBodyText.Name = "tbErrorPageBodyText";
            this.tbErrorPageBodyText.Size = new System.Drawing.Size(621, 20);
            this.tbErrorPageBodyText.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(19, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(155, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "Pagetitle of error page";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.checkBox4);
            this.groupBox16.Controls.Add(this.chb403_Forbidden);
            this.groupBox16.Controls.Add(this.label15);
            this.groupBox16.Controls.Add(this.label16);
            this.groupBox16.Controls.Add(this.chb401Unauthorized);
            this.groupBox16.Controls.Add(this.chb200Ok);
            this.groupBox16.Controls.Add(this.label17);
            this.groupBox16.Controls.Add(this.checkBox3);
            this.groupBox16.Controls.Add(this.chb304NotModified);
            this.groupBox16.Controls.Add(this.chb202Accepted);
            this.groupBox16.Controls.Add(this.label14);
            this.groupBox16.Controls.Add(this.checkBox2);
            this.groupBox16.Controls.Add(this.chbMoved301);
            this.groupBox16.Controls.Add(this.chb302Found);
            this.groupBox16.Controls.Add(this.checkBox1);
            this.groupBox16.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox16.ForeColor = System.Drawing.Color.Black;
            this.groupBox16.Location = new System.Drawing.Point(23, 19);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(877, 145);
            this.groupBox16.TabIndex = 31;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Define response type for selected check (Default: 200 OK for an existing file)";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(429, 107);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(223, 21);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "509 Bandwidth Limit Exceeded";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chb403_Forbidden
            // 
            this.chb403_Forbidden.AutoSize = true;
            this.chb403_Forbidden.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb403_Forbidden.ForeColor = System.Drawing.Color.Black;
            this.chb403_Forbidden.Location = new System.Drawing.Point(139, 64);
            this.chb403_Forbidden.Name = "chb403_Forbidden";
            this.chb403_Forbidden.Size = new System.Drawing.Size(121, 21);
            this.chb403_Forbidden.TabIndex = 13;
            this.chb403_Forbidden.Text = "403 Forbidden ";
            this.chb403_Forbidden.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(14, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "2xx Success";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(136, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "4xx Error";
            // 
            // chb401Unauthorized
            // 
            this.chb401Unauthorized.AutoSize = true;
            this.chb401Unauthorized.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb401Unauthorized.ForeColor = System.Drawing.Color.Black;
            this.chb401Unauthorized.Location = new System.Drawing.Point(139, 85);
            this.chb401Unauthorized.Name = "chb401Unauthorized";
            this.chb401Unauthorized.Size = new System.Drawing.Size(137, 21);
            this.chb401Unauthorized.TabIndex = 12;
            this.chb401Unauthorized.Text = "401 Unauthorized";
            this.chb401Unauthorized.UseVisualStyleBackColor = true;
            // 
            // chb200Ok
            // 
            this.chb200Ok.AutoSize = true;
            this.chb200Ok.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb200Ok.ForeColor = System.Drawing.Color.Black;
            this.chb200Ok.Location = new System.Drawing.Point(17, 64);
            this.chb200Ok.Name = "chb200Ok";
            this.chb200Ok.Size = new System.Drawing.Size(71, 21);
            this.chb200Ok.TabIndex = 7;
            this.chb200Ok.Text = "200 OK";
            this.chb200Ok.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(279, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "3xx Redirection";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(610, 64);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(167, 21);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "501 Not Implemented";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chb304NotModified
            // 
            this.chb304NotModified.AutoSize = true;
            this.chb304NotModified.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb304NotModified.ForeColor = System.Drawing.Color.Black;
            this.chb304NotModified.Location = new System.Drawing.Point(282, 85);
            this.chb304NotModified.Name = "chb304NotModified";
            this.chb304NotModified.Size = new System.Drawing.Size(132, 21);
            this.chb304NotModified.TabIndex = 11;
            this.chb304NotModified.Text = "304 NotModified";
            this.chb304NotModified.UseVisualStyleBackColor = true;
            // 
            // chb202Accepted
            // 
            this.chb202Accepted.AutoSize = true;
            this.chb202Accepted.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb202Accepted.ForeColor = System.Drawing.Color.Black;
            this.chb202Accepted.Location = new System.Drawing.Point(17, 85);
            this.chb202Accepted.Name = "chb202Accepted";
            this.chb202Accepted.Size = new System.Drawing.Size(116, 21);
            this.chb202Accepted.TabIndex = 8;
            this.chb202Accepted.Text = "202 Accepted";
            this.chb202Accepted.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(426, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "5xx Server Error";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(429, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 21);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "510 Not Extended";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chbMoved301
            // 
            this.chbMoved301.AutoSize = true;
            this.chbMoved301.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMoved301.ForeColor = System.Drawing.Color.Black;
            this.chbMoved301.Location = new System.Drawing.Point(282, 64);
            this.chbMoved301.Name = "chbMoved301";
            this.chbMoved301.Size = new System.Drawing.Size(97, 21);
            this.chbMoved301.TabIndex = 10;
            this.chbMoved301.Text = "301 Moved";
            this.chbMoved301.UseVisualStyleBackColor = true;
            // 
            // chb302Found
            // 
            this.chb302Found.AutoSize = true;
            this.chb302Found.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb302Found.ForeColor = System.Drawing.Color.Black;
            this.chb302Found.Location = new System.Drawing.Point(282, 107);
            this.chb302Found.Name = "chb302Found";
            this.chb302Found.Size = new System.Drawing.Size(92, 21);
            this.chb302Found.TabIndex = 9;
            this.chb302Found.Text = "302 Found";
            this.chb302Found.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(429, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "500 Internal Server Error";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tpWebMethod
            // 
            this.tpWebMethod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpWebMethod.Controls.Add(this.label40);
            this.tpWebMethod.Controls.Add(this.label19);
            this.tpWebMethod.Controls.Add(this.rbGet);
            this.tpWebMethod.Controls.Add(this.rbTrace);
            this.tpWebMethod.Controls.Add(this.tbPort);
            this.tpWebMethod.Controls.Add(this.rbPost);
            this.tpWebMethod.Controls.Add(this.rbHead);
            this.tpWebMethod.Location = new System.Drawing.Point(4, 24);
            this.tpWebMethod.Name = "tpWebMethod";
            this.tpWebMethod.Padding = new System.Windows.Forms.Padding(3);
            this.tpWebMethod.Size = new System.Drawing.Size(973, 326);
            this.tpWebMethod.TabIndex = 1;
            this.tpWebMethod.Text = "Web Server Settings";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(14, 30);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(92, 17);
            this.label40.TabIndex = 22;
            this.label40.Text = "Web Method";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(14, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Port number";
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Checked = true;
            this.rbGet.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGet.Location = new System.Drawing.Point(138, 26);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(49, 21);
            this.rbGet.TabIndex = 0;
            this.rbGet.TabStop = true;
            this.rbGet.Tag = "GET";
            this.rbGet.Text = "GET";
            this.rbGet.UseVisualStyleBackColor = true;
            // 
            // rbTrace
            // 
            this.rbTrace.AutoSize = true;
            this.rbTrace.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTrace.Location = new System.Drawing.Point(334, 26);
            this.rbTrace.Name = "rbTrace";
            this.rbTrace.Size = new System.Drawing.Size(66, 21);
            this.rbTrace.TabIndex = 3;
            this.rbTrace.Tag = "TRACE";
            this.rbTrace.Text = "TRACE";
            this.rbTrace.UseVisualStyleBackColor = true;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(138, 82);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(212, 21);
            this.tbPort.TabIndex = 20;
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPost.Location = new System.Drawing.Point(205, 26);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(56, 21);
            this.rbPost.TabIndex = 1;
            this.rbPost.Tag = "POST";
            this.rbPost.Text = "POST";
            this.rbPost.UseVisualStyleBackColor = true;
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHead.Location = new System.Drawing.Point(267, 26);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(61, 21);
            this.rbHead.TabIndex = 2;
            this.rbHead.Tag = "HEAD";
            this.rbHead.Text = "HEAD";
            this.rbHead.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage5.Controls.Add(this.groupBox21);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(973, 326);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Authentication Settings";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.tbCookies);
            this.groupBox21.Controls.Add(this.label18);
            this.groupBox21.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox21.Location = new System.Drawing.Point(25, 14);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(875, 56);
            this.groupBox21.TabIndex = 31;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Cookie";
            // 
            // tbCookies
            // 
            this.tbCookies.Location = new System.Drawing.Point(251, 28);
            this.tbCookies.Name = "tbCookies";
            this.tbCookies.Size = new System.Drawing.Size(605, 20);
            this.tbCookies.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(15, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(230, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "Cookie (cookieX=123;cookieY=zzz)";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tbRawPost);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.cbPostUsernameKeys);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.tbPostUsernameValue);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.tbPostPasswordValue);
            this.groupBox10.Controls.Add(this.cbPostPasswordKeys);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(25, 76);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(875, 120);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Form Based Auth (Post settings)";
            // 
            // tbRawPost
            // 
            this.tbRawPost.Location = new System.Drawing.Point(145, 17);
            this.tbRawPost.Name = "tbRawPost";
            this.tbRawPost.Size = new System.Drawing.Size(711, 20);
            this.tbRawPost.TabIndex = 30;
            this.tbRawPost.TextChanged += new System.EventHandler(this.tbRawPost_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(293, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 17);
            this.label27.TabIndex = 27;
            this.label27.Text = "Your Username";
            // 
            // cbPostUsernameKeys
            // 
            this.cbPostUsernameKeys.FormattingEnabled = true;
            this.cbPostUsernameKeys.Location = new System.Drawing.Point(145, 57);
            this.cbPostUsernameKeys.Name = "cbPostUsernameKeys";
            this.cbPostUsernameKeys.Size = new System.Drawing.Size(137, 23);
            this.cbPostUsernameKeys.TabIndex = 32;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(13, 91);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(122, 17);
            this.label30.TabIndex = 35;
            this.label30.Text = "Value is Password";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(295, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(101, 17);
            this.label26.TabIndex = 29;
            this.label26.Text = "Your Password";
            // 
            // tbPostUsernameValue
            // 
            this.tbPostUsernameValue.Location = new System.Drawing.Point(403, 62);
            this.tbPostUsernameValue.Name = "tbPostUsernameValue";
            this.tbPostUsernameValue.Size = new System.Drawing.Size(453, 20);
            this.tbPostUsernameValue.TabIndex = 26;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(13, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 17);
            this.label28.TabIndex = 31;
            this.label28.Text = "Raw POST Request";
            // 
            // tbPostPasswordValue
            // 
            this.tbPostPasswordValue.Location = new System.Drawing.Point(403, 88);
            this.tbPostPasswordValue.Name = "tbPostPasswordValue";
            this.tbPostPasswordValue.Size = new System.Drawing.Size(453, 20);
            this.tbPostPasswordValue.TabIndex = 28;
            // 
            // cbPostPasswordKeys
            // 
            this.cbPostPasswordKeys.FormattingEnabled = true;
            this.cbPostPasswordKeys.Location = new System.Drawing.Point(145, 87);
            this.cbPostPasswordKeys.Name = "cbPostPasswordKeys";
            this.cbPostPasswordKeys.Size = new System.Drawing.Size(137, 23);
            this.cbPostPasswordKeys.TabIndex = 33;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(15, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(124, 17);
            this.label29.TabIndex = 34;
            this.label29.Text = "Value is Username";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbWebLogin);
            this.groupBox9.Controls.Add(this.tbWebPassword);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(25, 202);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(875, 88);
            this.groupBox9.TabIndex = 29;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Basic authentication";
            // 
            // tbWebLogin
            // 
            this.tbWebLogin.Location = new System.Drawing.Point(145, 27);
            this.tbWebLogin.Name = "tbWebLogin";
            this.tbWebLogin.Size = new System.Drawing.Size(415, 20);
            this.tbWebLogin.TabIndex = 22;
            // 
            // tbWebPassword
            // 
            this.tbWebPassword.Location = new System.Drawing.Point(145, 53);
            this.tbWebPassword.Name = "tbWebPassword";
            this.tbWebPassword.Size = new System.Drawing.Size(415, 20);
            this.tbWebPassword.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(13, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "Login";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(13, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 17);
            this.label21.TabIndex = 25;
            this.label21.Text = "Password";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage8.Controls.Add(this.groupBox11);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(973, 326);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Special Checks Settings";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tbIbmFile);
            this.groupBox11.Controls.Add(this.chbIbmEnabled);
            this.groupBox11.Controls.Add(this.btnGetIbmFile);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(33, 26);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(829, 95);
            this.groupBox11.TabIndex = 29;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "IBM Special checks";
            // 
            // tbIbmFile
            // 
            this.tbIbmFile.Location = new System.Drawing.Point(426, 49);
            this.tbIbmFile.Name = "tbIbmFile";
            this.tbIbmFile.Size = new System.Drawing.Size(285, 20);
            this.tbIbmFile.TabIndex = 27;
            // 
            // chbIbmEnabled
            // 
            this.chbIbmEnabled.AutoSize = true;
            this.chbIbmEnabled.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbIbmEnabled.Location = new System.Drawing.Point(14, 25);
            this.chbIbmEnabled.Name = "chbIbmEnabled";
            this.chbIbmEnabled.Size = new System.Drawing.Size(391, 21);
            this.chbIbmEnabled.TabIndex = 24;
            this.chbIbmEnabled.Text = "Click here if selected check is an  IBM Domino/Notes test";
            this.chbIbmEnabled.UseVisualStyleBackColor = true;
            // 
            // btnGetIbmFile
            // 
            this.btnGetIbmFile.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetIbmFile.Image = global::AgWebScanner.Properties.Resources.fileb1;
            this.btnGetIbmFile.Location = new System.Drawing.Point(367, 47);
            this.btnGetIbmFile.Name = "btnGetIbmFile";
            this.btnGetIbmFile.Size = new System.Drawing.Size(53, 21);
            this.btnGetIbmFile.TabIndex = 26;
            this.btnGetIbmFile.UseVisualStyleBackColor = true;
            this.btnGetIbmFile.Click += new System.EventHandler(this.btnGetIbmFile_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(12, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(346, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "Choose File (?EditDocument, ?OpenDocument etc.)";
            // 
            // pageUnEnumerator
            // 
            this.pageUnEnumerator.BackColor = System.Drawing.Color.Gainsboro;
            this.pageUnEnumerator.Location = new System.Drawing.Point(4, 26);
            this.pageUnEnumerator.Name = "pageUnEnumerator";
            this.pageUnEnumerator.Padding = new System.Windows.Forms.Padding(3);
            this.pageUnEnumerator.Size = new System.Drawing.Size(1010, 545);
            this.pageUnEnumerator.TabIndex = 4;
            this.pageUnEnumerator.Text = "Username enumerator";
            this.pageUnEnumerator.UseVisualStyleBackColor = true;
            // 
            // pageVpnScan
            // 
            this.pageVpnScan.BackColor = System.Drawing.Color.Gainsboro;
            this.pageVpnScan.Location = new System.Drawing.Point(4, 26);
            this.pageVpnScan.Name = "pageVpnScan";
            this.pageVpnScan.Padding = new System.Windows.Forms.Padding(3);
            this.pageVpnScan.Size = new System.Drawing.Size(1010, 545);
            this.pageVpnScan.TabIndex = 5;
            this.pageVpnScan.Text = "Vpn Scan";
            this.pageVpnScan.UseVisualStyleBackColor = true;
            // 
            // pageHTTPScan
            // 
            this.pageHTTPScan.Location = new System.Drawing.Point(4, 26);
            this.pageHTTPScan.Name = "pageHTTPScan";
            this.pageHTTPScan.Size = new System.Drawing.Size(1010, 545);
            this.pageHTTPScan.TabIndex = 6;
            this.pageHTTPScan.Text = "HTTP Scan";
            this.pageHTTPScan.UseVisualStyleBackColor = true;
            // 
            // ofdFilePath
            // 
            this.ofdFilePath.Filter = "Text Files (*.txt)|*.txt";
            this.ofdFilePath.InitialDirectory = "C:\\";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(25, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(612, 45);
            this.label43.TabIndex = 21;
            this.label43.Text = resources.GetString("label43.Text");
            // 
            // FmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1018, 575);
            this.Controls.Add(this.tcTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swiss Web Attack Tool (SWAT)";
            this.FileScanner.ResumeLayout(false);
            this.FileScanner.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcTabs.ResumeLayout(false);
            this.QuickStart.ResumeLayout(false);
            this.QuickStart.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.DirScanner.ResumeLayout(false);
            this.DirScanner.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusDirScan.ResumeLayout(false);
            this.statusDirScan.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirScanResults)).EndInit();
            this.Settings.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpResponseTypes.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tpWebMethod.ResumeLayout(false);
            this.tpWebMethod.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage FileScanner;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage Settings;
        private DataGridView gvResults;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private SplitContainer splitContainer1;
        private Button btnSaveResponseTypes;
        private GroupBox groupBox2;
        private Button btnSetFileForEdit;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnSetFileForAdd;
        private ComboBox cbAvailableChecks;
        private Label label8;
        private OpenFileDialog ofdFilePath;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsStatusLabel;
	  private Button btnExport;
        private CheckBox chb403_Forbidden;
        private CheckBox chb401Unauthorized;
        private CheckBox chb304NotModified;
        private CheckBox chbMoved301;
        private CheckBox chb302Found;
        private CheckBox chb202Accepted;
        private CheckBox chb200Ok;
        private TextBox rtbAddFileName;
        private TextBox rtbAddFilePath;
        private Label label3;
        private TextBox rtbEditFilePath;
        private CheckedListBox chbListExistingChecks;
        private GroupBox groupBox4;
        private Label label9;
        private Label label6;
        private GroupBox groupBox5;
        private Label label10;
        private GroupBox groupBox6;
        private Button button3;
        private Button button2;
        private Label label17;
        private Label label16;
	  private Label label15;
        private Label label13;
	  private Button btnDelete;
        private RadioButton rbTrace;
        private RadioButton rbHead;
        private RadioButton rbPost;
	  private RadioButton rbGet;
	  private TextBox tbPort;
        private Label label21;
        private TextBox tbWebPassword;
        private Label label20;
        private TextBox tbWebLogin;
        private Label label22;
        private TextBox tbIbmFile;
        private Button btnGetIbmFile;
        private CheckBox chbIbmEnabled;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label14;
        private GroupBox groupBox8;
        private ComboBox cbChecksForDelete;
	  private Label label12;
        private Label label18;
	  private TextBox tbCookies;
        private TextBox tbErrorPageBodyText;
        private TextBox tbErrorPageTitle;
        private Label label25;
	  private Label label24;
        private Label label30;
        private Label label29;
        private ComboBox cbPostPasswordKeys;
        private ComboBox cbPostUsernameKeys;
        private Label label28;
        private TextBox tbRawPost;
        private Label label26;
        private TextBox tbPostPasswordValue;
        private Label label27;
        private TextBox tbPostUsernameValue;
        private TabPage DirScanner;
        private StatusStrip statusDirScan;
        private ToolStripStatusLabel tsDirScanStatusLabel;
        private GroupBox groupBox12;
        private Button btnStopDirScan;
        private Label label31;
        private Label label32;
        private Button btnStartDirScan;
        private GroupBox groupBox13;
        private RichTextBox rtbDirScanTarget;
        private Label label33;
        private DataGridView gvDirScanResults;
        private System.ComponentModel.BackgroundWorker bgDirectoryWorker;
        private SaveFileDialog sfDialog;
        private CheckBox chbDirScanAdd;
        private CheckBox chbDirScanEdit;
        private CheckedListBox chblExistingDirScans;
        private GroupBox groupBox14;
        private RadioButton rbExportDirsToPdf;
        private RadioButton rbExportDirsToText;
        private Label label34;
        private Button btnExportDirs;
        private RadioButton rbFilesExportToPdf;
        private RadioButton rbFilesExportToText;
        private GroupBox groupBox3;
        private RichTextBox rtbBaseUrl;
        private Label label2;
        private Label label7;
        private TextBox tbVirtualFolder;
        private Label label35;
        private PictureBox pictureBox2;
        private Label label36;
        private Button button4;
        private GroupBox groupBox15;
        private Label label37;
        private Label label38;
        private Label label5;
        private Label label39;
	  private Label label1;
	  private GroupBox groupBox17;
        private Label label49;
	  private Label label48;
      private Label label11;
      private Label label50;
        private TabPage QuickStart;
        private PictureBox pictureBox4;
        private Label label57;
        private GroupBox groupBox20;
        private Label label55;
        private RadioButton radioButton1;
        private RadioButton rbQuickExportToText;
        private Button btnQuickExport;
        private GroupBox groupBox19;
        private Label label53;
        private RichTextBox rtb_QuickScanUrl;
        private Label label54;
        private GroupBox groupBox7;
        private Button btnQuickStop;
        private Label label51;
        private Label label52;
        private Button btnQuickStart;
        private System.ComponentModel.BackgroundWorker bgQuickWorker;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel tsQuickScanStatus;
	  private TabControl tabControl1;
	  private TabPage tpResponseTypes;
	  private TabPage tpWebMethod;
	  private TabPage tabPage5;
	  private Label label19;
	  private TabPage tabPage8;
	  private Label label23;
	  private GroupBox groupBox18;
	  private GroupBox groupBox16;
	  private Label label40;
	  private GroupBox groupBox10;
	  private GroupBox groupBox9;
	  private GroupBox groupBox11;
	  private TabPage pageUnEnumerator;
	  private TabPage pageVpnScan;
	  private TabPage tabPage3;
      private PictureBox pictureBox1;
      private GroupBox groupBox21;
      private Label label42;
      private Label label41;
      private TabPage pageHTTPScan;
      private Button button1;
      private Label label43;
    }
}

