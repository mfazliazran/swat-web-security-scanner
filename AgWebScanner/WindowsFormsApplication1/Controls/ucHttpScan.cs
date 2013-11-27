using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgWebScanner.Core.HttpScan;

namespace AgWebScanner.Controls
{
    public partial class ucHttpScan : UserControl
    {
        private HttpScanner _HttpScanner;
        public int scantype;
        private RadioButton[] rbs;

        public ucHttpScan()
        {
            InitializeComponent();

            //HttpScanner _HttpScanner;

            rbs = new RadioButton[] { radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8
                    , radioButton9, radioButton10, radioButton11, radioButton12, radioButton13, radioButton14, radioButton15
                    , radioButton16, radioButton17, radioButton18};
            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].Tag = i+3;
                rbs[i].CheckedChanged += new EventHandler(radionButtons_CheckedChanged);
            }

            this.InitializeMembers();

            scantype = 15+3;
        }

        private void InitializeMembers()
        {
            _HttpScanner = new HttpScanner();

            this.btnStop.Enabled = false;
            
            //this.bgWorker.DoWork += this.bgWorker_DoWork;
            //this.bgWorker.RunWorkerCompleted += this.bgWorker_RunWorkerCompleted;
            //this.bgWorker.ProgressChanged += this.bgWorker_ProgressChanged;
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;

            console.DetectUrls = false;
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SParams parm = new SParams();
            parm.base_url = tbUrl.Text;
            parm.test_mode = scantype;

            parm.get_uri = textBox1.Text;
            parm.post_uri = textBox3.Text;
            parm.post_data = textBox4.Text;
            parm.options_uri = textBox6.Text;
            parm.delete_uri = textBox5.Text;
            parm.head_uri = textBox2.Text;
            parm.put_uri = textBox7.Text;
            parm.put_path = textBox8.Text;
            parm.wrongmethod_met = textBox9.Text;
            parm.wrongversion_ver = textBox10.Text;
            parm.trace_uri = textBox11.Text;
            parm.connect_uri = textBox12.Text;
            parm.propfind_uri = textBox13.Text;

            for (int i = 0; i < rbs.Length; i++)
                parm.test_names[i] = rbs[i].Text;

            this._HttpScanner.Scan(bgWorker,parm);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this._HttpScanner != null)
            {
                this.statusLabel.Text = "Ready";
                this.statusLabel.ForeColor = Color.Black;
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = false;

                MessageBox.Show("Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrEmpty( this.tbUrl.Text ) )
			{
				MessageBox.Show( "You need to enter scan target", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
            else
            {
                this.statusLabel.Text = "Scanning...";
                this.statusLabel.ForeColor = Color.Red;
                this.btnStart.Enabled = false;
                this.btnStop.Enabled = true;
                this.console.Clear();
                this.bgWorker.RunWorkerAsync();
            }
        }

        private void radionButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                this.scantype = (int)rb.Tag;
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Command data = (Command)e.UserState;

            string gg;// = data.AddToConsoleStr.Take(1);
            System.Drawing.Color col;

            while (data.AddToConsoleStr.Count() > 0)
            {
                gg = data.AddToConsoleStr.ElementAt(0);
                col = data.AddToConsoleColor.ElementAt(0);

                console.SelectionColor = col;
                console.AppendText(gg);
                console.ScrollToCaret();
                data.AddToConsoleStr.RemoveAt(0);
                data.AddToConsoleColor.RemoveAt(0);
            }

           // if(data.AddToConsole==true)
            {
                //console.AppendText(gg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true ;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox8.Text = openFileDialog1.FileName;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HTTP Scanner \nContact: Oliver (at) muenchow.ch\nCredits: Krzysztof Kucza");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.bgWorker.CancelAsync();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.RestoreDirectory = true;

            if(radioButton1.Checked==true)
            {
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            }
            else if (radioButton2.Checked == true)
            {
                saveFileDialog1.Filter = "Html files (*.html)|*.txt|All files (*.*)|*.*";
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string report = "";

                if (radioButton1.Checked == true)  // TXT
                {
                    report += "------------------------------------------------------------------------------------\n";
                    report += "Test name             Request               Response              Status            \n";
                    report += "------------------------------------------------------------------------------------\n";
                    report += console.Text;
                    report = report.Replace("\n", "\r\n");
                }
                else if (radioButton2.Checked == true) // HTML
                {
                    report += "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01//EN\"><html><head><title>HTTP Scanner html report</title>";
                    report += "<style type=\"text/css\">	  .table {	clear:both;	border: 1px solid #000000; ";
                    report += "margin-top: 5px; margin-bottom: 5px;	background: #cccccc; border-spacing: 1px; ";
                    report += "	font-size: 12px;	font-family:\"Verdana\";	} ";
                    report += " .first_tr {	background: #99ccff;	font-weight: bold;	height:25px;	font-size: 13px; } ";
                    report += " td.first_td {	border: 1px solid #6699ff;	padding-left: 5px;	padding-right: 5px; } ";
                    report += " td.left {	text-align: left;	padding-left: 5px;	padding-right: 5px; } ";
                    report += " td.center {	text-align: center;	padding-left: 5px;	padding-right: 5px; } ";
                    report += " .tr_1 { background: #ffffff; } .tr_2 {	background: #eeeeee; } ";
                    report += " .main2 {	border: 1px solid #333333;	background: #ddeeff; font-size: 1.25em;	text-align: left;	padding-left: 20px; margin-top: 30px; } ";
                    report += " .code_block { display: block; font-family: \"dejavu sans mono\", \"monaco\", \"lucida console\", \"courier new\", monospace; ";
                    report += "    font-size: x-small;	background: #eef;	border-top: 2px solid #999;	border-bottom: 2px solid #999; ";
                    report += "	line-height: 1.5em;	padding: 3px 1em;	overflow: auto;	white-space: nowrap; } ";
                    report += " .code_short { 	max-height: 24em; padding-left: 30px;	}	 .code_full { 	max-height: 64em;	} ";
                    report += " .some_font { 	text-align: left;	padding-left: 5px;	padding-right: 5px;	font-family:\"Verdana\";	font-size: 13px;	} ";
                    report += "</style></head><body>";

                    /// TABLE OF CONTENTS

                    report += "<a name=\"top\"></a><h1>HTML Scanner html report.</h1>";
                    report += "<h3><a href=\"#1\">1. Results</a></h3>";
                    report += "<h3><a href=\"#2\">2. Details</a></h3>";
                    report += "<br><br>";

                    /// 1.RESULTS
                    
                    report += "<a name=\"1\"></a><div class=\"main2\">1. Results</div><a href=\"#top\">top</a>";

                    report += "<table class=\"table\"><tr class=\"first_tr\" ><td class=\"first_td\">Test</td><td class=\"first_td\">Request</td><td class=\"first_td\">Response</td><td class=\"first_td\">Details</td></tr> ";

                    for (int i = 3; i <= 18; i++)
                    {
                        if (i == 18) // 'select all' test
                            continue;
                        if (HttpScanner.results[i].name == null) // test not taken
                            continue;
                        report += "<tr class=\"tr_" + (i % 2 + 1).ToString() + "\"><td class=\"left\">" + HttpScanner.results[i].name + "</td><td class=\"left\">" + HttpScanner.results[i].request + "</td><td class=\"left\">";
                        if ((HttpScanner.results[i].response!=null)&&(HttpScanner.results[i].response.Length >= 1) && (HttpScanner.results[i].response[0] != '2'))
                            report += "<img src=\"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA4AAAAOCAIAAACQKrqGAAAABnRSTlMA/wD/AP83WBt9AAAAYUlEQVR4nIXQORKAMAxDUTlnD+f+FJDB66BxZb9GNkBmkgRqc65L0uVXnXsBAGyJZ3wkpH2W3y3r6AINurhMvU4OMFJxXy6eVtu3/8nUt/5k7Fu1Jlf1S1sXdPOBOeufnNx45gCE4RT68gAAAABJRU5ErkJggg==\" />";
                        report+= HttpScanner.results[i].response + "</td><td class=\"center\"><a href=\"#out" + i.ToString() + "\">click</a></td></tr>";
                    }
                    
                    report += "</table>";

                    report += "<a name=\"2\"></a><div class=\"main2\">2. Details</div><a href=\"#top\">top</a>";

                    for (int i = 3; i <= 18; i++)
                    {
                        if (i == 18) // 'select all' test
                            continue;
                        if (HttpScanner.results[i].name == null) // test not taken
                            continue;
                        report += "<a name=\"out"+i.ToString()+"\"><a href=\"#1\">back</a><p class=\"some_font\"><b>"+HttpScanner.results[i].name+"</b> Request:</p><div class=\"code_block code_short\"> ";
                        report += System.Web.HttpUtility.HtmlEncode(HttpScanner.results[i].full_request).Replace("\r\n","<br>");
                        report += "</div><br>";
                        report += "<p class=\"some_font\"><b>"+HttpScanner.results[i].name+"</b> Response:</p><div class=\"code_block code_short\"> ";
                        report += System.Web.HttpUtility.HtmlEncode(HttpScanner.results[i].full_response).Replace("\r\n", "<br>");
                        report += "</div><br>";
                        report += "<hr>";
                    }

                    report += "<h2>End of report</h2></body>";
                }
               // System.IO.File.
               // using (var stream = System.IO.File.CreateText((saveFileDialog1.FileName)))
               // {
               //     stream.Write(output);
               // }

                System.IO.File.WriteAllText(saveFileDialog1.FileName+".html", report, Encoding.ASCII);

                MessageBox.Show("Report saved.");
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool allows you to test various HTTP verbs (like POST, DELELTE etc.)\n Compared to other tools this one lets you also actually do an upload\n in a command like PUT is accepted by the server and the\n according rights are given on the web servers file system.");
        }
    }
}
