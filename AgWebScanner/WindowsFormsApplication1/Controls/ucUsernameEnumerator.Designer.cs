namespace AgWebScanner.Controls
{
	partial class ucUsernameEnumerator
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUsernameEnumerator));
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.rbPost = new System.Windows.Forms.RadioButton();
            this.gbTextToSearch = new System.Windows.Forms.GroupBox();
            this.tbTextToSearch = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbMethods = new System.Windows.Forms.GroupBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParams = new System.Windows.Forms.TextBox();
            this.cbKeys = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLoadVariablesFile = new System.Windows.Forms.Button();
            this.tbVariablesFilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbTextToSearch.SuspendLayout();
            this.gbMethods.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Checked = true;
            this.rbGet.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGet.Location = new System.Drawing.Point(17, 19);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(47, 20);
            this.rbGet.TabIndex = 0;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "GET";
            this.rbGet.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(13, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 24);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rbPost
            // 
            this.rbPost.AutoSize = true;
            this.rbPost.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPost.Location = new System.Drawing.Point(17, 42);
            this.rbPost.Name = "rbPost";
            this.rbPost.Size = new System.Drawing.Size(54, 20);
            this.rbPost.TabIndex = 1;
            this.rbPost.Text = "POST";
            this.rbPost.UseVisualStyleBackColor = true;
            // 
            // gbTextToSearch
            // 
            this.gbTextToSearch.Controls.Add(this.tbTextToSearch);
            this.gbTextToSearch.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTextToSearch.Location = new System.Drawing.Point(106, 18);
            this.gbTextToSearch.Name = "gbTextToSearch";
            this.gbTextToSearch.Size = new System.Drawing.Size(302, 71);
            this.gbTextToSearch.TabIndex = 58;
            this.gbTextToSearch.TabStop = false;
            this.gbTextToSearch.Text = "Text To Search";
            // 
            // tbTextToSearch
            // 
            this.tbTextToSearch.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTextToSearch.Location = new System.Drawing.Point(8, 27);
            this.tbTextToSearch.Name = "tbTextToSearch";
            this.tbTextToSearch.Size = new System.Drawing.Size(283, 21);
            this.tbTextToSearch.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(87, 22);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 24);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gbMethods
            // 
            this.gbMethods.Controls.Add(this.rbPost);
            this.gbMethods.Controls.Add(this.rbGet);
            this.gbMethods.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMethods.Location = new System.Drawing.Point(11, 18);
            this.gbMethods.Name = "gbMethods";
            this.gbMethods.Size = new System.Drawing.Size(89, 71);
            this.gbMethods.TabIndex = 57;
            this.gbMethods.TabStop = false;
            this.gbMethods.Text = "Method";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.gbTextToSearch);
            this.groupBox3.Controls.Add(this.gbMethods);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 254);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.tbParams);
            this.groupBox6.Controls.Add(this.cbKeys);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.btnLoadVariablesFile);
            this.groupBox6.Controls.Add(this.tbVariablesFilePath);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(11, 95);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(397, 142);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parameters settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Params String";
            // 
            // tbParams
            // 
            this.tbParams.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbParams.Location = new System.Drawing.Point(134, 24);
            this.tbParams.Name = "tbParams";
            this.tbParams.Size = new System.Drawing.Size(252, 21);
            this.tbParams.TabIndex = 11;
            this.tbParams.TextChanged += new System.EventHandler(this.tbParams_TextChanged);
            // 
            // cbKeys
            // 
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(134, 67);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(252, 21);
            this.cbKeys.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "User Variables File";
            // 
            // btnLoadVariablesFile
            // 
            this.btnLoadVariablesFile.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadVariablesFile.Location = new System.Drawing.Point(347, 105);
            this.btnLoadVariablesFile.Name = "btnLoadVariablesFile";
            this.btnLoadVariablesFile.Size = new System.Drawing.Size(39, 22);
            this.btnLoadVariablesFile.TabIndex = 8;
            this.btnLoadVariablesFile.Text = "...";
            this.btnLoadVariablesFile.UseVisualStyleBackColor = true;
            this.btnLoadVariablesFile.Click += new System.EventHandler(this.btnLoadVariablesFile_Click);
            // 
            // tbVariablesFilePath
            // 
            this.tbVariablesFilePath.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVariablesFilePath.Location = new System.Drawing.Point(134, 105);
            this.tbVariablesFilePath.Name = "tbVariablesFilePath";
            this.tbVariablesFilePath.Size = new System.Drawing.Size(207, 21);
            this.tbVariablesFilePath.TabIndex = 7;
            this.tbVariablesFilePath.Click += new System.EventHandler(this.tbVariablesFilePath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "User Variable Name";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 17);
            this.statusLabel.Text = "Ready";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.tbUrl);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 85);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan Target";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUrl.Location = new System.Drawing.Point(20, 44);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(377, 21);
            this.tbUrl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL [https://www.server.com/auth/login.asp]";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.ssStatus.Location = new System.Drawing.Point(0, 504);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1010, 22);
            this.ssStatus.TabIndex = 66;
            this.ssStatus.Text = "statusStrip";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.btnStop);
            this.groupBox8.Controls.Add(this.btnStart);
            this.groupBox8.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(435, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(240, 60);
            this.groupBox8.TabIndex = 63;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(157, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop Scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Scan";
            // 
            // gvResults
            // 
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(10, 19);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(547, 387);
            this.gvResults.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.gvResults);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(435, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 418);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detailed View";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Export Results";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.btnAbout);
            this.groupBox5.Controls.Add(this.btnHelp);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(842, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 60);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.btnExport);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(681, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(155, 60);
            this.groupBox7.TabIndex = 64;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Export";
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(125, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(26, 26);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(17, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(26, 26);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(16, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(26, 26);
            this.btnExport.TabIndex = 3;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ucUsernameEnumerator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Name = "ucUsernameEnumerator";
            this.Size = new System.Drawing.Size(1010, 526);
            this.gbTextToSearch.ResumeLayout(false);
            this.gbTextToSearch.PerformLayout();
            this.gbMethods.ResumeLayout(false);
            this.gbMethods.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbGet;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.RadioButton rbPost;
		private System.Windows.Forms.GroupBox gbTextToSearch;
		private System.Windows.Forms.TextBox tbTextToSearch;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.GroupBox gbMethods;
		private System.ComponentModel.BackgroundWorker bgWorker;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbParams;
		private System.Windows.Forms.ComboBox cbKeys;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnLoadVariablesFile;
		private System.Windows.Forms.TextBox tbVariablesFilePath;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox tbUrl;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip ssStatus;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.DataGridView gvResults;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox7;
	}
}
