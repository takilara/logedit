using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace logedit
{
	/// <summary>
	/// Summary description for about.
	/// </summary>
	public class about : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public about()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(about));
			this.vlabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.bLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// vlabel
			// 
			this.vlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vlabel.Location = new System.Drawing.Point(24, 16);
			this.vlabel.Name = "vlabel";
			this.vlabel.Size = new System.Drawing.Size(224, 23);
			this.vlabel.TabIndex = 0;
			this.vlabel.Text = "LogEdit";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "Copyright © 2004 Espen Austad";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "Webpage";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 6;
			this.label8.Text = "Contact";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(88, 104);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(136, 16);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "logedit@deathlogs.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(88, 80);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(152, 16);
			this.linkLabel2.TabIndex = 9;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "http://deathlogs.com/logedit";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "LogEdit.chm";
			// 
			// bLabel
			// 
			this.bLabel.Location = new System.Drawing.Point(72, 40);
			this.bLabel.Name = "bLabel";
			this.bLabel.Size = new System.Drawing.Size(112, 23);
			this.bLabel.TabIndex = 10;
			this.bLabel.Text = "Build";
			// 
			// about
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(256, 165);
			this.Controls.Add(this.bLabel);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.vlabel);
			this.helpProvider1.SetHelpKeyword(this, "WelcometoLogEdit.htm");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "about";
			this.helpProvider1.SetShowHelp(this, true);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About LogEdit";
			this.Load += new System.EventHandler(this.about_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label vlabel;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Label bLabel;

		public Form1 frm;
		private void about_Load(object sender, System.EventArgs e)
		{
			//vlabel.Text="LogEdit "+frm.version;
			vlabel.Text="LogEdit "+frm.ver.ToString(2);
			bLabel.Text="Build: "+frm.ver.Build.ToString();
		}

		private void label5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			e.Link.LinkData="http://deathlogs.com/logedit";
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			e.Link.LinkData="mailto:logedit@deathlogs.com";
			System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
		}
	}
}
