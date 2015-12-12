using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace logedit
{
	/// <summary>
	/// Summary description for colorform.
	/// </summary>
	public class colorform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button white;
		private System.Windows.Forms.Button cyanbold;
		private System.Windows.Forms.Button cyan;
		private System.Windows.Forms.Button magentabold;
		private System.Windows.Forms.Button magenta;
		private System.Windows.Forms.Button bluebold;
		private System.Windows.Forms.Button blue;
		private System.Windows.Forms.Button yellowbold;
		private System.Windows.Forms.Button yellow;
		private System.Windows.Forms.Button greenbold;
		private System.Windows.Forms.Button green;
		private System.Windows.Forms.Button redbold;
		private System.Windows.Forms.Button red;
		private System.Windows.Forms.Button blackbold;
		private System.Windows.Forms.Button black;
		private System.Windows.Forms.Button whitebold;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public colorform()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(colorform));
			this.whitebold = new System.Windows.Forms.Button();
			this.white = new System.Windows.Forms.Button();
			this.cyanbold = new System.Windows.Forms.Button();
			this.cyan = new System.Windows.Forms.Button();
			this.magentabold = new System.Windows.Forms.Button();
			this.magenta = new System.Windows.Forms.Button();
			this.bluebold = new System.Windows.Forms.Button();
			this.blue = new System.Windows.Forms.Button();
			this.yellowbold = new System.Windows.Forms.Button();
			this.yellow = new System.Windows.Forms.Button();
			this.greenbold = new System.Windows.Forms.Button();
			this.green = new System.Windows.Forms.Button();
			this.redbold = new System.Windows.Forms.Button();
			this.red = new System.Windows.Forms.Button();
			this.blackbold = new System.Windows.Forms.Button();
			this.black = new System.Windows.Forms.Button();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// whitebold
			// 
			this.whitebold.Location = new System.Drawing.Point(176, 32);
			this.whitebold.Name = "whitebold";
			this.whitebold.Size = new System.Drawing.Size(24, 23);
			this.whitebold.TabIndex = 31;
			this.toolTip1.SetToolTip(this.whitebold, "Click to change the color of the selected text in the document.");
			this.whitebold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.whitebold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// white
			// 
			this.white.Location = new System.Drawing.Point(176, 8);
			this.white.Name = "white";
			this.white.Size = new System.Drawing.Size(24, 23);
			this.white.TabIndex = 30;
			this.toolTip1.SetToolTip(this.white, "Click to change the color of the selected text in the document.");
			this.white.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.white.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// cyanbold
			// 
			this.cyanbold.Location = new System.Drawing.Point(152, 32);
			this.cyanbold.Name = "cyanbold";
			this.cyanbold.Size = new System.Drawing.Size(24, 23);
			this.cyanbold.TabIndex = 29;
			this.toolTip1.SetToolTip(this.cyanbold, "Click to change the color of the selected text in the document.");
			this.cyanbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.cyanbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// cyan
			// 
			this.cyan.Location = new System.Drawing.Point(152, 8);
			this.cyan.Name = "cyan";
			this.cyan.Size = new System.Drawing.Size(24, 23);
			this.cyan.TabIndex = 28;
			this.toolTip1.SetToolTip(this.cyan, "Click to change the color of the selected text in the document.");
			this.cyan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.cyan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// magentabold
			// 
			this.magentabold.Location = new System.Drawing.Point(128, 32);
			this.magentabold.Name = "magentabold";
			this.magentabold.Size = new System.Drawing.Size(24, 23);
			this.magentabold.TabIndex = 27;
			this.toolTip1.SetToolTip(this.magentabold, "Click to change the color of the selected text in the document.");
			this.magentabold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.magentabold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// magenta
			// 
			this.magenta.Location = new System.Drawing.Point(128, 8);
			this.magenta.Name = "magenta";
			this.magenta.Size = new System.Drawing.Size(24, 23);
			this.magenta.TabIndex = 26;
			this.toolTip1.SetToolTip(this.magenta, "Click to change the color of the selected text in the document.");
			this.magenta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.magenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// bluebold
			// 
			this.bluebold.Location = new System.Drawing.Point(104, 32);
			this.bluebold.Name = "bluebold";
			this.bluebold.Size = new System.Drawing.Size(24, 23);
			this.bluebold.TabIndex = 25;
			this.toolTip1.SetToolTip(this.bluebold, "Click to change the color of the selected text in the document.");
			this.bluebold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.bluebold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// blue
			// 
			this.blue.Location = new System.Drawing.Point(104, 8);
			this.blue.Name = "blue";
			this.blue.Size = new System.Drawing.Size(24, 23);
			this.blue.TabIndex = 24;
			this.toolTip1.SetToolTip(this.blue, "Click to change the color of the selected text in the document.");
			this.blue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// yellowbold
			// 
			this.yellowbold.Location = new System.Drawing.Point(80, 32);
			this.yellowbold.Name = "yellowbold";
			this.yellowbold.Size = new System.Drawing.Size(24, 23);
			this.yellowbold.TabIndex = 23;
			this.toolTip1.SetToolTip(this.yellowbold, "Click to change the color of the selected text in the document.");
			this.yellowbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.yellowbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// yellow
			// 
			this.yellow.Location = new System.Drawing.Point(80, 8);
			this.yellow.Name = "yellow";
			this.yellow.Size = new System.Drawing.Size(24, 23);
			this.yellow.TabIndex = 22;
			this.toolTip1.SetToolTip(this.yellow, "Click to change the color of the selected text in the document.");
			this.yellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// greenbold
			// 
			this.greenbold.Location = new System.Drawing.Point(56, 32);
			this.greenbold.Name = "greenbold";
			this.greenbold.Size = new System.Drawing.Size(24, 23);
			this.greenbold.TabIndex = 21;
			this.toolTip1.SetToolTip(this.greenbold, "Click to change the color of the selected text in the document.");
			this.greenbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.greenbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// green
			// 
			this.green.Location = new System.Drawing.Point(56, 8);
			this.green.Name = "green";
			this.green.Size = new System.Drawing.Size(24, 23);
			this.green.TabIndex = 20;
			this.toolTip1.SetToolTip(this.green, "Click to change the color of the selected text in the document.");
			this.green.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// redbold
			// 
			this.redbold.Location = new System.Drawing.Point(32, 32);
			this.redbold.Name = "redbold";
			this.redbold.Size = new System.Drawing.Size(24, 23);
			this.redbold.TabIndex = 19;
			this.toolTip1.SetToolTip(this.redbold, "Click to change the color of the selected text in the document.");
			this.redbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.redbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// red
			// 
			this.red.Location = new System.Drawing.Point(32, 8);
			this.red.Name = "red";
			this.red.Size = new System.Drawing.Size(24, 23);
			this.red.TabIndex = 18;
			this.toolTip1.SetToolTip(this.red, "Click to change the color of the selected text in the document.");
			this.red.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// blackbold
			// 
			this.blackbold.Location = new System.Drawing.Point(8, 32);
			this.blackbold.Name = "blackbold";
			this.blackbold.Size = new System.Drawing.Size(24, 23);
			this.blackbold.TabIndex = 17;
			this.toolTip1.SetToolTip(this.blackbold, "Click to change the color of the selected text in the document.");
			this.blackbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.blackbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// black
			// 
			this.black.Location = new System.Drawing.Point(8, 8);
			this.black.Name = "black";
			this.black.Size = new System.Drawing.Size(24, 23);
			this.black.TabIndex = 16;
			this.toolTip1.SetToolTip(this.black, "Click to change the color of the selected text in the document.");
			this.black.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "LogEdit.chm";
			// 
			// colorform
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 61);
			this.Controls.Add(this.whitebold);
			this.Controls.Add(this.white);
			this.Controls.Add(this.cyanbold);
			this.Controls.Add(this.cyan);
			this.Controls.Add(this.magentabold);
			this.Controls.Add(this.magenta);
			this.Controls.Add(this.bluebold);
			this.Controls.Add(this.blue);
			this.Controls.Add(this.yellowbold);
			this.Controls.Add(this.yellow);
			this.Controls.Add(this.greenbold);
			this.Controls.Add(this.green);
			this.Controls.Add(this.redbold);
			this.Controls.Add(this.red);
			this.Controls.Add(this.blackbold);
			this.Controls.Add(this.black);
			this.helpProvider1.SetHelpKeyword(this, "Overview_colors.htm");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "colorform";
			this.helpProvider1.SetShowHelp(this, true);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Colors";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.colorform_Closing);
			this.Load += new System.EventHandler(this.colorform_Load);
			this.ResumeLayout(false);

		}
		#endregion
		public Form1 frm;
		private void colorform_Load(object sender, System.EventArgs e)
		{
			black.BackColor=Color.FromArgb(100,100,100);
			blackbold.BackColor=Color.FromArgb(100,100,100);
			red.BackColor=Color.FromArgb(128,0,0);
			redbold.BackColor=Color.FromArgb(255,0,0);
			green.BackColor=Color.FromArgb(0,128,0);
			greenbold.BackColor=Color.FromArgb(0,255,0);
			yellow.BackColor=Color.FromArgb(136,136,0);
			yellowbold.BackColor=Color.FromArgb(255,255,0);
			blue.BackColor=Color.FromArgb(0,0,128);
			bluebold.BackColor=Color.FromArgb(0,0,255);
			magenta.BackColor=Color.FromArgb(136,0,136);
			magentabold.BackColor=Color.FromArgb(255,0,255);
			cyan.BackColor=Color.FromArgb(0,136,136);
			cyanbold.BackColor=Color.FromArgb(0,255,255);
			white.BackColor=Color.FromArgb(192,192,192);
			whitebold.BackColor=Color.FromArgb(255,255,255);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			
				
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			frm.richTextBox2.SelectionColor=Color.FromArgb(10,10,10);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			frm.richTextBox2.SelectionColor=Color.FromArgb(100,100,100);
		}

		


		private void black_Click(object sender, System.EventArgs e)
		{
			//System.Windows.Forms.Button mBtn = (System.Windows.Forms.Button) sender;
			//frm.richTextBox2.SelectionColor= mBtn.BackColor;
			//frm.richTextBox2.HideSelection=true;
			
		}

		

		

		private void colorform_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide();
			//frm.colorme
			frm.colormenu.Checked=false;
			e.Cancel=true;
			
		}
		int sellen = 0;
		private void black_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.Button mBtn = (System.Windows.Forms.Button) sender;
			frm.richTextBox2.SelectionColor= mBtn.BackColor;
			sellen = frm.richTextBox2.SelectionLength;
			frm.richTextBox2.SelectionLength=0;
			//frm.richTextBox2.
			
			//frm.richTextBox2.HideSelection=true;
			Debug.WriteLine("Mouse down");			
		}

		private void black_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//frm.richTextBox2.HideSelection=false;
			frm.richTextBox2.SelectionLength=sellen;
			frm.richTextBox2.Focus();
			
			Debug.WriteLine("Mouse up");
		}

		

		
	}
}
