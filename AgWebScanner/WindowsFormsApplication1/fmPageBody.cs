using System;
using System.Windows.Forms;

namespace AgWebScanner
{
	public partial class fmPageBody : Form
	{
		public fmPageBody( string body )
		{
			InitializeComponent();
			this.rtbBody.Text = body;
		}

		private void button1_Click( object sender, EventArgs e )
		{
			this.Close();
		}
	}
}
