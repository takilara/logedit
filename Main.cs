using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
//using EnvDTE;
using Microsoft.Win32;


namespace logedit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	
	
	public class Form1 : System.Windows.Forms.Form
	{
		public mudReader mud = new mudReader();
		public DataSet ds;
		public string rtf = "";
		public string[] myArgs;
		public string urgs="";
		//public string version = "0.83";
		public Version ver;
		public string version = Application.ProductVersion;
		public System.Windows.Forms.RichTextBox richTextBox2;


		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.MenuItem menuItem6;
		public System.Windows.Forms.MenuItem filtermenu;
		private System.Windows.Forms.ColorDialog colorDialog1;
		public System.Windows.Forms.MenuItem colormenu;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		public System.Windows.Forms.MenuItem defcolorsmenu;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		public ProgressStatusBar.ProgressStatusBar statusBar1;
		private ProgressStatusBar.ProgressPanel progressPanel1;
		private System.Windows.Forms.StatusBarPanel linesPanel;
		private System.ComponentModel.IContainer components;

		


		public Form1(string[] theArgs)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			myArgs = theArgs;
			//
		}

		//		public Form1(string[] mineArgs)
		//		{
		//			myArgs=mineArgs;
		//			Form1();
		//		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.filtermenu = new System.Windows.Forms.MenuItem();
			this.colormenu = new System.Windows.Forms.MenuItem();
			this.defcolorsmenu = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.dataSet1 = new System.Data.DataSet();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusBar1 = new ProgressStatusBar.ProgressStatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.linesPanel = new System.Windows.Forms.StatusBarPanel();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.progressPanel1 = new ProgressStatusBar.ProgressPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.linesPanel)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.progressPanel1)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.Black;
			this.richTextBox2.DetectUrls = false;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox2.ForeColor = System.Drawing.Color.White;
			this.helpProvider1.SetHelpKeyword(this.richTextBox2, "WelcometoLogEdit.htm");
			this.helpProvider1.SetHelpNavigator(this.richTextBox2, System.Windows.Forms.HelpNavigator.Topic);
			this.helpProvider1.SetHelpString(this.richTextBox2, "");
			this.richTextBox2.HideSelection = false;
			this.richTextBox2.Location = new System.Drawing.Point(0, 0);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
			this.helpProvider1.SetShowHelp(this.richTextBox2, false);
			this.richTextBox2.ShowSelectionMargin = true;
			this.richTextBox2.Size = new System.Drawing.Size(904, 458);
			this.richTextBox2.TabIndex = 4;
			this.richTextBox2.Text = "";
			this.richTextBox2.WordWrap = false;
			this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.menuItem1,
																											 this.menuItem10,
																											 this.menuItem6,
																											 this.menuItem7});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.menuItem9,
																											 this.menuItem5,
																											 this.menuItem2,
																											 this.menuItem3,
																											 this.menuItem4,
																											 this.menuItem22});
			this.menuItem1.Text = "&File";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuItem9.Text = "New";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItem5.Text = "Open";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItem2.Text = "Save";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "Save As";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 4;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
			this.menuItem4.Text = "Export";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 5;
			this.menuItem22.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.menuItem22.Text = "Exit";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 1;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											  this.menuItem11,
																											  this.menuItem16,
																											  this.menuItem12,
																											  this.menuItem13,
																											  this.menuItem14,
																											  this.menuItem15,
																											  this.menuItem17,
																											  this.menuItem18,
																											  this.menuItem21,
																											  this.menuItem19,
																											  this.menuItem20});
			this.menuItem10.Text = "&Edit";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.menuItem11.Text = "Undo";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
			this.menuItem16.Text = "Redo";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click_1);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "-";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menuItem13.Text = "Cut";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 4;
			this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem14.Text = "Copy";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 5;
			this.menuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem15.Text = "Paste";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 6;
			this.menuItem17.Text = "-";
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 7;
			this.menuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.menuItem18.Text = "Find";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 8;
			this.menuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.menuItem21.Text = "Replace";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 9;
			this.menuItem19.Text = "-";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 10;
			this.menuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.menuItem20.Text = "Select All";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.filtermenu,
																											 this.colormenu,
																											 this.defcolorsmenu});
			this.menuItem6.Text = "&Window";
			// 
			// filtermenu
			// 
			this.filtermenu.Index = 0;
			this.filtermenu.Text = "Filters";
			this.filtermenu.Click += new System.EventHandler(this.filtermenu_Click);
			// 
			// colormenu
			// 
			this.colormenu.Index = 1;
			this.colormenu.Text = "Colors";
			this.colormenu.Click += new System.EventHandler(this.colormenu_Click);
			// 
			// defcolorsmenu
			// 
			this.defcolorsmenu.Index = 2;
			this.defcolorsmenu.Text = "Custom Colors";
			this.defcolorsmenu.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											 this.menuItem23,
																											 this.menuItem8});
			this.menuItem7.Text = "&Help";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 0;
			this.menuItem23.Text = "Help Topics";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click_1);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "About LogEdit";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("nb-NO");
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "LogEdit.chm";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.statusBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 459);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(904, 24);
			this.panel1.TabIndex = 18;
			// 
			// statusBar1
			// 
			this.statusBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusBar1.Location = new System.Drawing.Point(0, 0);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																												  this.statusBarPanel1,
																												  this.statusBarPanel2,
																												  this.linesPanel});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(904, 24);
			this.statusBar1.SizingGrip = false;
			this.statusBar1.TabIndex = 0;
			this.statusBar1.Text = "progressStatusBar1";
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel2.Width = 704;
			// 
			// linesPanel
			// 
			this.linesPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.linesPanel.Text = "Lines: 0";
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.Controls.Add(this.richTextBox2);
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(904, 458);
			this.mainPanel.TabIndex = 19;
			// 
			// progressPanel1
			// 
			this.progressPanel1.ForeColor = System.Drawing.Color.DarkBlue;
			this.progressPanel1.Maximum = 100;
			this.progressPanel1.Minimum = 1;
			this.progressPanel1.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
			this.progressPanel1.Text = "progressPanel1";
			this.progressPanel1.Value = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 483);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.panel1);
			this.helpProvider1.SetHelpKeyword(this, "WelcometoLogEdit.htm");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "LogEdit";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.linesPanel)).EndInit();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.progressPanel1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]	
			
		static void Main(string[] Args) 
		{

			//myArgs = new string[Args.Length];
			//myArgs = Args;
			try
			{
				Application.Run(new Form1(Args));
			}
			catch (Exception error)
			{
				Debug.WriteLine("Application crashed with: "+error.ToString());
				Application.Exit();
			}
		}

		public void SetColWidth(DataGridTableStyle tableStyle, int colNum, int width) 
		{ 
			try 
			{ 
				tableStyle.GridColumnStyles[colNum].Width = width; 
				tableStyle.DataGrid.Refresh(); 
			} 
			catch{} //empty catch .. do nothing 
		} 
 

		public customcolorsform ccf;
		public filterform f;
		public replaceform repf;
		public findform ff;
		public about aboutform;
		public bool abort=false;
		private colorform cf;
		private RegistryKey rk,rkk;
		private string initialpath;
		public void Form1_Load(object sender, System.EventArgs e)
		{
			abort = false;
			filtering=true;
			richTextBox2.ForeColor=Color.FromArgb(192,192,192);
			ver = new Version(version);
			helpProvider1.HelpNamespace="LogEdit.chm";
			statusBar1.Panels[0].Text="";
			statusBar1.Panels[1].Text="";

			this.progressPanel1.Width=200;
			this.progressPanel1.ForeColor=Color.Blue;
			Debug.WriteLine(this.progressPanel1.ForeColor.ToString());
			this.statusBar1.Panels.Insert(2,this.progressPanel1);


			f = new filterform();
			f.Owner = this;
			//f.Parent = this;
			f.TopMost = false; 
			f.frm = this;
			
			cf = new colorform();
			cf.Owner = this;
			cf.TopMost = false;
			cf.frm=this;

			ff = new findform();
			ff.Owner=this;
			ff.frm = this;

			repf = new replaceform();
			repf.Owner = this;
			repf.frm = this;


			ccf = new customcolorsform();
			ccf.Owner	= this;
			cf.TopMost = false;
			ccf.frm		= this;

			//cf.Show();

			rkk = Registry.CurrentUser;
			//rk = Registry.CurrentUser.OpenSubKey("Software\\logedit", true);
			rk = Registry.CurrentUser.CreateSubKey("Software\\logedit");

			//rk = rkk.OpenSubKey("Software\\logedit",true);
			//rk.OpenSubKey("logedit",true);
			//rk.OpenSubKey("Software\\logedit",true);
			//rk.OpenSubKey("Software\\logedit",true);
			int main_x,main_y,main_w,main_h,
				filter_x,filter_y,filter_w,filter_h,
				color_x,color_y,color_w,color_h,
				customcolor_x,customcolor_y,customcolor_w,customcolor_h;
				
			int reset;
			string filter_visible,main_mode,color_visible,customcolor_visible;

			try
			{
				//reset  = (int) rk.GetValue("reset");
				main_x = (int) rk.GetValue("main_x");
				main_y = (int) rk.GetValue("main_y");
				main_w = (int) rk.GetValue("main_w");
				main_h = (int) rk.GetValue("main_h");
				//string main_mode;
				main_mode = (string) rk.GetValue("main_mode");

				filter_x = (int) rk.GetValue("filter_x");
				filter_y = (int) rk.GetValue("filter_y");
				filter_w = (int) rk.GetValue("filter_w");
				filter_h = (int) rk.GetValue("filter_h");
				filter_visible = (string) rk.GetValue("filter_visible");

				color_x = (int) rk.GetValue("color_x");
				color_y = (int) rk.GetValue("color_y");
				color_w = (int) rk.GetValue("color_w");
				color_h = (int) rk.GetValue("color_h");
				color_visible = (string) rk.GetValue("color_visible");

				customcolor_x = (int) rk.GetValue("customcolor_x");
				customcolor_y = (int) rk.GetValue("customcolor_y");
				customcolor_w = (int) rk.GetValue("customcolor_w");
				customcolor_h = (int) rk.GetValue("customcolor_h");
				customcolor_visible = (string) rk.GetValue("customcolor_visible");


				initialpath = (string) rk.GetValue("initialpath");

				this.Left=main_x;
				this.Top=main_y;

				if(main_mode.ToLower()=="maximized")
				{
					this.WindowState=FormWindowState.Maximized;
				}
				else
				{
					this.Width=main_w;
					this.Height=main_h;
				}
				//this.WindowState=(FormWindowState) main_mode;

				f.SetDesktopLocation(filter_x,filter_y);

				//f.Left=filter_x;
				//f.Top=filter_y;
				f.Width=filter_w;
				f.Height=filter_h;
				if(filter_visible.ToLower()=="true")
				{
					f.Show();
					filtermenu.Checked=f.Visible;
				}


				cf.SetDesktopLocation(color_x,color_y);
				cf.Width=color_w;
				cf.Height=color_h;
				if(color_visible.ToLower()=="true")
				{
					cf.Show();
					colormenu.Checked=cf.Visible;
				}

				ccf.SetDesktopLocation(customcolor_x,customcolor_y);
				ccf.Width=customcolor_w;
				ccf.Height=customcolor_h;
				if(customcolor_visible.ToLower()=="true")
				{
					ccf.Show();
					defcolorsmenu.Checked=ccf.Visible;
				}


			}
			catch 
			{
				//rk = Registry.CurrentUser.OpenSubKey("Software\\logedit", true);
				
				initialpath = "C:";
				

			}
			mud.initialpath=initialpath;
			//string[] Args=Args;
			//Argument
			//if(myArgs.Length>0)
			//foreach(string arg in myArgs)
			//{
			//				richTextBox2.Text+=arg+"\r\n";
			//}
			if(myArgs.Length>0)
			{
				openTheFile(myArgs[0]);
			}
			filtering=false;
		}

		
		protected void paste()
		{
			IDataObject data = Clipboard.GetDataObject();
			if(data.GetDataPresent(DataFormats.Rtf))
			{
				//finn posisjon før paste
				// finn lengde på paste?
				//int startPos = richTextBox2.SelectionStart;

				/// TODO: paste to tempBox, replace black with gray, fix font
				/// then paste to richTextBox2

				richTextBox2.Paste(DataFormats.GetFormat(DataFormats.Rtf));
				//int endPos = richTextBox2.SelectionStart;

				//Debug.WriteLine(startPos.ToString());
				//richTextBox2.SelectionStart=startPos;
				//richTextBox2.SelectionLength=endPos-startPos;

				//Font myFont = new Font("Courier New",9);
				//richTextBox2.SelectionFont=myFont;
				//richTextBox2.SelectionStart=endPos;

				mud.setRtf(richTextBox2.Rtf);
			}
			else if(data.GetDataPresent("CF_ANSI"))
			{
				//ANSI
				MemoryStream myStream = new MemoryStream();
				myStream = data.GetData("CF_ANSI") as MemoryStream;
				StreamReader reader = new StreamReader(myStream, System.Text.Encoding.UTF7);
				string tempraw = reader.ReadToEnd();
				reader.Close();
				
				myStream.Close();
				myStream=null;

				mudReader tMud = new mudReader();
				tMud.setAnsi(tempraw.Replace("\r","\n"));
				string trtf = tMud.getRtf();
				tMud=null;
				

				/// TODO: Might be errors here (remove the \r\n thingy?)
				
				RichTextBox tempBox = new RichTextBox();
				tempBox.Rtf=trtf;
				trtf=null;
				
				tempBox.Rtf=tempBox.Rtf.Replace("\n","");
				tempBox.Rtf=tempBox.Rtf.Replace("\r","");
				tempBox.SelectAll();
				tempBox.Copy();
				
				

				richTextBox2.Paste();
				tempBox.ClearUndo();
				tempBox.Dispose();
				tempraw=null;
				

			}
			else
			{
				//TEXT
				//MemoryStream myStream = new MemoryStream();
				//myStream = data.GetData(DataFormats.Text) as MemoryStream;



				string tempraw = data.GetData(DataFormats.Text).ToString();
				mud.working=true;
				mud.setAnsi(tempraw);
				tempraw=null;
				mud.working=false;
				richTextBox2.Paste();
			}
			linesPanel.Text="Lines: "+richTextBox2.Lines.Length;
			data=null;
		}

		

		

		private void button6_Click(object sender, System.EventArgs e)
		{
			// skift dette til rtf

			richTextBox2.Clear();
			richTextBox2.Rtf = mud.getRtf();
		}



		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(modified!="")
			{
				string thefile = mud.filename;
				if(thefile=="")
				{
					thefile="Untitled";
				}
				DialogResult svar = new DialogResult();

				svar = MessageBox.Show("The text in the "+thefile+" file has changed.\r\nDo you want to save the changes?", "LogEdit",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (svar==DialogResult.No)
				{
					openFile();
				}
				if (svar==DialogResult.Yes)
				{
					if(save()==true)
					{
						openFile();
					}
				}
			}
			else
			{
				openFile();
			}
		}




		private bool openFile()
		{
			//LOAD rtf,txt or ansi type file
			//

			
			



			Stream myStream;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = mud.initialpath ;
			openFileDialog1.Filter = 
				"Ansi Color Files (*.ans)|*.ans|"+
				"Text files (*.txt)|*.txt|"+
				"Rich Text files (*.rtf)|*.rtf|"+
				//"HTML files (*.html,*.htm)|*.html;*.htm|"+
				"All files (*.*)|*.*" ;
			openFileDialog1.FilterIndex = 3 ;
			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				//				string path = openFileDialog1.FileName;
				//				return new FileStream(path, System.IO.FileMode.Open,
				//					System.IO.FileAccess.ReadWrite);


				if((myStream = openFileDialog1.OpenFile())!= null)
				{
					string tezt = openFileDialog1.FileName;
					openTheFile(tezt);
					myStream.Close();
				}
				Cursor.Current = Cursors.Default;
				return true;
			}
			else
			{
				return false;
			}
			
		}

		private void openTheFile(string tezt)
		{
			string[] teztA = tezt.Split('.');
			string ext = teztA[teztA.Length-1];


			//figure out the path part..
			string[] tpathA = tezt.Split('\\');
			string tpath ="";
			for(int i=0;i<tpathA.Length-1;i++)
			{
				tpath = tpath+"\\"+tpathA[i];
			}
			mud.initialpath=tpath;

			// Insert code to read the stream here.
			StreamReader reader = new StreamReader(tezt, System.Text.Encoding.UTF7);

			//StreamReader reader = new StreamReader(myStream, System.Text.Encoding.UTF7);
					
					
					
					
			
			string tempraw = reader.ReadToEnd();
			// IF Log is pure text or ansi text
			if(ext.ToLower()=="rtf")
			{
				mud.setRtf(tempraw);
				richTextBox2.Rtf = mud.getRtf();
				richTextBox2.SelectAll();
				Font myFont = new Font("Courier New",9);
				richTextBox2.SelectionFont=myFont;
				richTextBox2.SelectionStart=0;
				richTextBox2.SelectionLength=0;
				

			}
			else if(ext.ToLower()=="html"|ext.ToLower()=="htm")
			{
			}
			else
			{
				mud.setAnsi(tempraw);
				richTextBox2.Rtf = mud.getRtf();
			}
			// else..
			mud.filename=tezt;
			Text="LogEdit ("+mud.filename+")";
			modified ="";
					

			linesPanel.Text="Lines: "+richTextBox2.Lines.Length;
			//myStream.Close();
			reader.Close();
			
		}

		public bool filtering=false;
		private void richTextBox2_TextChanged(object sender, System.EventArgs e)
		{
			if(!filtering)
			{
				Text="LogEdit ("+mud.filename+"*)";
				modified = "*";
				rtf = richTextBox2.Rtf;
				if(!mud.working)
				{
					//mud.setRtf(richTextBox2.Rtf);
					
					linesPanel.Text="Lines: "+richTextBox2.Lines.Length;
					//countFilter();
				}
			}
		}
		
		public int replace(string from,string to,RegexOptions regexOptions)
		{
			RichTextBox tempBox = new RichTextBox();
			tempBox.Rtf=richTextBox2.Rtf;
			

			int count = 0;
			Regex r = new Regex(from,RegexOptions.Multiline|RegexOptions.RightToLeft|regexOptions);
			//			MatchCollection m = r.Matches(richTextBox2.Text);
			MatchCollection m = r.Matches(tempBox.Text);
			int t = m.Count;
			progressPanel1.Maximum=t;
			progressPanel1.Minimum=0;
			progressPanel1.Value=0;
			int oldLen = -1;
			int startTime = Environment.TickCount;
			StringBuilder testing= new StringBuilder();
			for (int i=0;i<m.Count;i++)
				//for (int i=m.Count-1;i>=0;i--)
			{
				tempBox.SelectionStart=m[i].Index;

				//Debug.WriteLine("start: "+m[i].Index.ToString()+", Lenght: "+m[i].Length.ToString());
				//if(m[i].Length!=oldLen)		// denne mister enkelte patterns
				//{
				oldLen=m[i].Length;

				//string tto = new String(to.ToCharArray());

				to = to.Replace(@"\n","\n");

				//string myto = "\n";
				tempBox.SelectionLength=oldLen;
				Debug.WriteLine("OldLenght: "+oldLen.ToString());
				
				//}
				//to = "\n";
				//if(to=="\n")
				//{
				//Debug.WriteLine("To = \n");
				//}

				string ttt = m[i].ToString();
				string tttOut = r.Replace(ttt,to);
				
				//Debug.WriteLine("changing from "+ttt+" to "+tttOut);
				//tempBox.SelectedText=to;
		
				tempBox.SelectedText=tttOut;
				


				
		
				testing.Length=0;
				testing.Append("\'"+from+"\' (Instance "+count+"/"+t+")");
				progressPanel1.Value=count;
					
				statusBar1.Panels[1].Text=testing.ToString();
				statusBar1.Invalidate(true);	
				
				count ++;
			}
			int endTime = Environment.TickCount;
			Debug.WriteLine("Filtering "+count.ToString()+" instances took: "+(endTime-startTime).ToString());
			if(tempBox.Text.Length>0)
			{
				tempBox.SelectAll();
				tempBox.Copy();
				richTextBox2.SelectAll();
				richTextBox2.Paste();


			}
			tempBox.Rtf=null;
			tempBox.Text=null;
			tempBox.ClearUndo();
			tempBox.Dispose();
			//richTextBox2.Rtf=tempBox.Rtf;
			

			
			
			progressPanel1.Value=0;

			return count;
		}

		
		public int progValue=0;


		#region setColorRegex Implementation
		/// <summary>
		/// uses pattern and color to color the text
		/// NOTE! Disregards any previous colors in the text
		/// </summary>
		/// <param name="pattern">Pattern to color</param>
		/// <param name="color">The color to change to</param>
		/// <returns>Number of colored instances</returns>
		public int setColorRegex(string pattern,Color color)
		{
			colorPattern[] cP = new colorPattern[1];
			cP[0] = new colorPattern(pattern,color);
			return setColorRegex(cP,RegexOptions.None);
		}
		/// <summary>
		/// uses pattern and color to color the text
		/// NOTE! Disregards any previous colors in the text
		/// </summary>
		/// <param name="pattern">Pattern to color</param>
		/// <param name="color">The color to change to</param>
		/// <param name="regexOptions">Regexoptions, ie RegexOptions.None</param>
		/// <returns>Number of colored instances</returns>
		public int setColorRegex(string pattern,Color color,RegexOptions regexOptions)
		{
			colorPattern[] cP = new colorPattern[1];
			cP[0] = new colorPattern(pattern,color);
			return setColorRegex(cP,regexOptions);
		}
		/// <summary>
		/// uses the content of colorPatterns to color the text
		/// NOTE! Disregards any previous colors in the text 
		/// </summary>
		/// <param name="colorPatterns">List of patterns and colors</param>
		/// <returns>Number of colored instances</returns>
		public int setColorRegex(colorPattern[] colorPatterns)
		{
			return setColorRegex(colorPatterns,RegexOptions.None);
		}
		/// <summary>
		/// uses the content of colorPatterns to color the text
		/// NOTE! Disregards any previous colors in the text
		/// </summary>
		/// <param name="colorPatterns">List of patterns and colors</param>
		/// <param name="regexOptions">Regexoptions, ie RegexOptions.None</param>
		/// <returns>Number of colored instances</returns>
		public int setColorRegex(colorPattern[] colorPatterns,RegexOptions regexOptions)
		{
			int totalstart = Environment.TickCount;
			string theText = richTextBox2.Text;
			theText = theText.Replace("\n","\\par\n");
			// Insert desired colortable
			string colorTableString = "";

			colorTableString =  "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang2057{\\fonttbl{\\f0\\fnil\\fcharset0 Courier New;}}\n";
			colorTableString += "{\\colortbl ;"+
				"\\red100\\green100\\blue100;"+		// black					0;30	\cf1
				"\\red100\\green100\\blue100;"+		// black bold			1;30	\cf2
				"\\red128\\green0\\blue0;"+			// red					0;31	\cf3
				"\\red255\\green0\\blue0;"+			// red bold				1;31	\cf4
				"\\red0\\green128\\blue0;"+			// green					0;32	\cf5
				"\\red0\\green255\\blue0;"+			// green bold			1;32	\cf6
				"\\red136\\green136\\blue0;"+			// yellow				0;33	\cf7
				"\\red255\\green255\\blue0;"+			// yellow bold			1;33	\cf8
				"\\red0\\green0\\blue128;"+			// blue					0;34	\cf9		
				"\\red0\\green0\\blue255;"+			// blue bold			1;34	\cf10
				"\\red136\\green0\\blue136;"+			// magenta				0;35	\cf11
				"\\red255\\green0\\blue255;"+			// magenta bold		1;35	\cf12
				"\\red0\\green136\\blue136;"+			// cyan					0;36	\cf13
				"\\red0\\green255\\blue255;"+			// cyan bold			1;36	\cf14
				"\\red192\\green192\\blue192;"+		// white					0;37	\cf15
				"\\red255\\green255\\blue255;"+		// white bold			1;37	\cf16
				"}\n";
			colorTableString	+= "\\viewkind4\\uc1\\pard\\cf15\\f0\\fs18 ";

			string defaultColor = "\\cf15 ";
			Hashtable colorTableHash = new Hashtable();
			colorTableHash[Color.FromArgb(100	,100	,100	)]=				"\\cf1 ";
			//colorTableHash[Color.FromArgb(100,100,100)]="\\cf2 ";
			colorTableHash[Color.FromArgb(128	,0		,0		)]=				"\\cf3 ";
			colorTableHash[Color.FromArgb(255	,0		,0		)]=				"\\cf4 ";
			colorTableHash[Color.FromArgb(0		,128	,0		)]=				"\\cf5 ";
			colorTableHash[Color.FromArgb(0		,255	,0		)]=				"\\cf6 ";
			colorTableHash[Color.FromArgb(136	,136	,0		)]=				"\\cf7 ";
			colorTableHash[Color.FromArgb(255	,255	,0		)]=				"\\cf8 ";
			colorTableHash[Color.FromArgb(0		,0		,128	)]=				"\\cf9 ";
			colorTableHash[Color.FromArgb(0		,0		,255	)]=				"\\cf10 ";
			colorTableHash[Color.FromArgb(136	,0		,136	)]=				"\\cf11 ";
			colorTableHash[Color.FromArgb(255	,0 	,255	)]=				"\\cf12 ";
			colorTableHash[Color.FromArgb(0		,136	,136	)]=				"\\cf13 ";
			colorTableHash[Color.FromArgb(0		,255	,255	)]=				"\\cf14 ";
			colorTableHash[Color.FromArgb(192	,192	,192	)]=				"\\cf15 ";
			colorTableHash[Color.FromArgb(255	,255	,255	)]=				"\\cf16 ";

			// for each pattern run a regex replace with desired color, match and default color
			int count=0;
			int countt=0;
			foreach(colorPattern cP in colorPatterns)
			{
				statusBar1.Panels[0].Text="Coloring";
				
				Regex r = new Regex(cP.pattern,RegexOptions.Multiline|regexOptions);
				// approach 1, using macthes
				StringBuilder sb = new StringBuilder();
				int lastPos = 0;
				int lenght = 0;
				MatchCollection ma = r.Matches(theText);
				int t=0;
				t=ma.Count;
				progressPanel1.Maximum=t;
				count=0;
				foreach(Match m in ma)
				{
					// find the last color
					Regex lc = new Regex("(\\\\cf\\d+|\\\\par)",RegexOptions.RightToLeft);
					Match lcm = lc.Match(theText,m.Index);
					//Debug.WriteLine("Found color "+lcm.Value+" at "+lcm.Index.ToString());

					//length = m.Index-lastPos;
					//Debug.WriteLine("found "+m.Value+" at "+m.Index.ToString());
					try
					{
						sb.Append(theText.Substring(lastPos,m.Index-lastPos));// fix
					}
					catch (Exception arg)
					{
						Debug.WriteLine("AAAAAAAAAAAARG: "+arg.Message);
					}
					lastPos = m.Index+m.Length;
					sb.Append(colorTableHash[cP.color]);
					sb.Append(m.Value);
					if(lcm.Value==@"\par"||lcm.Index==0)
					{
						//Debug.WriteLine("Added default color");
						sb.Append(defaultColor);
					}
					else
					{
						//Debug.WriteLine("Added previous color");
						sb.Append(lcm.Value+" ");
					}
					StringBuilder testing = new StringBuilder();
					testing.Length=0;
					testing.Append("\'"+cP.pattern+"\' (Instance "+count+"/"+t+")");
					statusBar1.Panels[1].Text=testing.ToString();
					progressPanel1.Value=count;
					statusBar1.Invalidate(true);	


					count++;
					countt++;
				}
				sb.Append(theText.Substring(lastPos));
				theText = sb.ToString();
			}
			//outText="{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang2057{\\fonttbl{\\f0\fnil\\fcharset0 Courier New;}}\r\n";
			//outText+=colorTableString+"\r\n";
			string outText = colorTableString+theText+"}";
			RichTextBox tBox = new RichTextBox();
			tBox.Rtf=outText;
			if(tBox.Text.Length>0)
			{
				tBox.SelectAll();
				tBox.Copy();
				richTextBox2.SelectAll();
				richTextBox2.Paste();
			}
			tBox.ClearUndo();
			tBox.Rtf=null;
			tBox.Text=null;
			tBox.Dispose();
			//richTextBox2.Rtf=outText;
			int totalend = Environment.TickCount;
			Debug.WriteLine("Coloring "+count.ToString()+" instances took "+(totalend-totalstart).ToString()+"ms");
			statusBar1.Panels[0].Text="";
			statusBar1.Panels[1].Text="";
			progressPanel1.Value=0;
			statusBar1.Invalidate(true);
			colorTableHash=null;
			return countt;
		}
		#endregion



		/// <summary>
		/// changes the color of "pattern" to "color", add RegexOptions if neccesary
		/// </summary>
		/// <param name="pattern">The text to color</param>
		/// <param name="color">The color to use</param>
		/// <param name="regexOptions">RegexOptions, ie RegexOptions.IgnoreCase</param>
		/// <returns>Number of instances colored</returns>
		public int setColor(string pattern,Color color,RegexOptions regexOptions)
		{
			colorPattern[] cp = new colorPattern[1];
			cp[0]=new colorPattern(pattern,color);
			int tcount = setColor(cp,"old",0,regexOptions);
			cp=null;
			return tcount;
		}

		public int setColor(colorPattern[] patterns,string method,int charprbox,RegexOptions regexOptions)
		{
			int totalstart = Environment.TickCount;
			string pattern=patterns[0].pattern;
			Color myColor=patterns[0].color;

			


			//timer1.Enabled=true;
			RichTextBox tempBox = new RichTextBox();
			//Debug.WriteLine(richTextBox2.Lines[0]);
			tempBox.DetectUrls=false;
			tempBox.CausesValidation=false;
			tempBox.Rtf=richTextBox2.Rtf;
			

			string theText = tempBox.Text;
			

			int count = 0;
			try
			{
				//string method="new";
				if(method=="old")
				{
					Regex r = new Regex(pattern,RegexOptions.Multiline|regexOptions);
			
					MatchCollection m = r.Matches(theText);
					int t = m.Count;

					progressPanel1.Minimum=0;
					progressPanel1.Maximum=t;
					
					StringBuilder testing= new StringBuilder();
					int startTime = Environment.TickCount;
					int selLen = pattern.Length;
					int oldLen = 0;
				
					tempBox.SelectionLength=selLen;
				
					foreach(Match ma in m)
					{
						tempBox.Select(ma.Index,ma.Length);

						if(ma.Length!=oldLen)
						{
							oldLen=ma.Length;
							tempBox.SelectionLength=oldLen;
						}
						tempBox.SelectionColor=myColor;				// 1 sek

						// denne blokka tar 1 sek
						if(count%2==0)
						{
							testing.Length=0;
							testing.Append("\'"+pattern+"\' (Instance "+count+"/"+t+")");
							statusBar1.Panels[1].Text=testing.ToString();
							progressPanel1.Value=count;
							statusBar1.Invalidate(true);	
						}
						count ++;
					}

				

					int endTime = Environment.TickCount;
					Debug.WriteLine("Coloring "+count.ToString()+" instances took: "+((endTime-startTime)).ToString()+" ms");

					tempBox.SelectAll();
					tempBox.Copy();
					if(richTextBox2.Text.Length>0)
					{
						richTextBox2.SelectAll();
						richTextBox2.Paste();
					}
					

				}
				else		// method=new
				{
					int tStart = Environment.TickCount;

					// find rtf startpiece
					string startpiece = richTextBox2.Rtf.Substring(0,richTextBox2.Rtf.IndexOf("\\fs18")+5);
					string endpiece = "}";
					string middlepiece = "";
					Debug.WriteLine("RTF startpiece:"+startpiece);

					int modnr = charprbox;
					//decimal nrofboxes = richTextBox2.TextLength/modnr;
					//int nrboxes = Math.Ceiling(nrofboxes);
					int nrboxes = (richTextBox2.Rtf.Length/modnr)+2;
					//int nrboxes = nrofboxes;
					int g = 0;
					int tendpos = startpiece.Length;
					int tstartpos;
					RichTextBox[] rtfs = new RichTextBox[nrboxes];
					bool done = false;
					int boxcount = 0;
					
					while(g<nrboxes)
					{
						rtfs[g] = new RichTextBox();
						// get end position ( after first \\par after g*modnr
						tstartpos = tendpos;
						try
						{
							if(((g*modnr)+tendpos)<richTextBox2.Rtf.Length)
							{
								tendpos = richTextBox2.Rtf.IndexOf("\\par",(g*modnr)+startpiece.Length);
							}
							else
							{
								tendpos = richTextBox2.Rtf.LastIndexOf("}");
								done = true;
								boxcount= g;
							}
							StringBuilder tsb = new StringBuilder();
							//middlepiece = richTextBox2.Rtf.Substring(tstartpos,tendpos-tstartpos);
							tsb.Append(startpiece);
							tsb.Append(richTextBox2.Rtf.Substring(tstartpos,tendpos-tstartpos));
							tsb.Append("}");
							//Debug.WriteLine("Middlepiece: "+middlepiece);
							//rtfs[g].Rtf=startpiece+middlepiece+endpiece;
							rtfs[g].Rtf=tsb.ToString();
					
						}
						catch (Exception e)
						{
							Debug.WriteLine(e);
						}
						if(done==true)
						{
							g = nrboxes-1;
						}
						g++;
					}
					int tEnd = Environment.TickCount;
					Debug.WriteLine("Creating rtf boxes took: "+(tEnd-tStart).ToString()+"ms");

					int startTime = Environment.TickCount;
					
//						Regex r = new Regex(pattern,RegexOptions.Multiline);
//						MatchCollection grm = r.Matches(theText);
						//int t = grm.Count;
						int t = 0;
						progressPanel1.Minimum=0;
						progressPanel1.Maximum=t;

						
							//Debug.WriteLine("Box nr: "+j.ToString());
							foreach(colorPattern cp in patterns)
							{
								count = 0;
								pattern = cp.pattern;
								myColor=cp.color;
								Regex r = new Regex(pattern,RegexOptions.Multiline|regexOptions);
								MatchCollection grm = r.Matches(richTextBox2.Text);
								t = grm.Count;
								progressPanel1.Maximum=t;

								for(int j=0;j<boxcount+1;j++)
								{
									
									//Debug.WriteLine("coloring pattern '"+pattern+"' to color '"+myColor.ToString());
									theText= rtfs[j].Text;
									MatchCollection m = r.Matches(theText);
									StringBuilder testing= new StringBuilder();
						
									int selLen = pattern.Length;
									int oldLen = 0;
				
									rtfs[j].SelectionLength=selLen;
									for(int n=0;n<m.Count;n++)
									//foreach(Match ma in m)
									{
										//rtfs[j].Select(ma.Index,ma.Length);
										rtfs[j].Select(m[n].Index,m[n].Length);

										//if(ma.Length!=oldLen)
										if(m[n].Length!=oldLen)
										{
											//oldLen=ma.Length;
											oldLen=m[n].Length;
											rtfs[j].SelectionLength=oldLen;
										}
										rtfs[j].SelectionColor=myColor;				// 1 sek

										// denne blokka tar 1 sek
										//if(count%10==0)
										//{
											testing.Length=0;
											testing.Append("\'"+pattern+"\' (Instance "+count+"/"+t+")");
											statusBar1.Panels[1].Text=testing.ToString();
											progressPanel1.Value=count;
											statusBar1.Invalidate(true);	
										//}
										count ++;
									}
								}
								//Debug.WriteLine(""); // Next box
							}
						int sEnd;
						int endTime = Environment.TickCount;
						Debug.WriteLine("Coloring (multi)"+count.ToString()+" instances took: "+((endTime-startTime)).ToString()+" ms");


						int sStart = Environment.TickCount;
						Debug.WriteLine("Copy back from rtfs");
						RichTextBox ttb = new RichTextBox();
						// testing copyback
					/// TODO: add the last linethingy
					for(int j=0;j<boxcount+1;j++)
					{
						//RichTextBox tb= new RichTextBox();
						//tb.Rtf= rtfs[j].Rtf;
						
						if(rtfs[j].Text.Length>0)
						{
							rtfs[j].SelectAll();
							rtfs[j].Copy();
							ttb.Paste();
							Debug.WriteLine("not blank line");
						}
						else
						{
							Debug.WriteLine("blank line");
						}
						//tb.ClearUndo();
						//tb.Dispose();
						rtfs[j].ClearUndo();
						rtfs[j].Dispose();
					}
					if(ttb.Text.Length>0)
					{
						ttb.SelectAll();
						ttb.Copy();
						richTextBox2.SelectAll();
						richTextBox2.Paste();
					}
					//richTextBox2.Rtf=ttb.Rtf;
					ttb.ClearUndo();
					ttb.Dispose();
					
					sEnd = Environment.TickCount;
					Debug.WriteLine("Copy back took: "+(sEnd-sStart).ToString()+"ms");


					// testing readback
					/// TODO: Insanely fast, however to get it to work, it needs to replace colorcodes 
					/// in each rtf box with colorcodes in main rtf box, so
					/// 1. check colortable in small rtf box
					/// 1.1 if exists return numbers
					/// 1.2 if not exists: create it, return numbers
					/// 2. replace code with new code
//									sStart = Environment.TickCount;
//									Debug.WriteLine("Readback back from rtfs");
//									StringBuilder ss = new StringBuilder();
//									int startoftext=0;
//									ss.Append(startpiece);
//									int endoftext=0;
//									for(int j=0;j<boxcount+1;j++)
//									{
//										startoftext = rtfs[j].Rtf.IndexOf("\\fs18")+5;
//										endoftext = rtfs[j].Rtf.LastIndexOf("}");
//					
//										ss.Append(rtfs[j].Rtf.Substring(startoftext,endoftext-startoftext));
//									}
//									ss.Append(endpiece);
//									richTextBox2.Rtf=ss.ToString();
//									sEnd = Environment.TickCount;
//									Debug.WriteLine("Read back took: "+(sEnd-sStart).ToString()+"ms");



				}

				
				//richTextBox2.Rtf=tempBox.Rtf;
			

				progressPanel1.Value=0;
				statusBar1.Refresh();



				int totalEnd = Environment.TickCount;
				if(method=="old")
				{
					Debug.WriteLine("Total time to color "+count+" instances of '"+pattern+"' using '"+method+"' took "+(totalEnd-totalstart).ToString()+"ms");
				}
				else
				{
						Debug.WriteLine("Total time to color "+count+" instances of '"+pattern+"' using '"+method+"-"+charprbox+"' took "+(totalEnd-totalstart).ToString()+"ms");
				}
				tempBox.Rtf="";
				tempBox.ClearUndo();
				tempBox.Dispose();
				return count;
			}
			catch (Exception e)
			{
				MessageBox.Show("Error in regex pattern.", "RegEx Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine("Regex error: "+e.Message);
				tempBox.Dispose();
				return 0;
			}
		}

		public int countX(string from,RegexOptions regexOptions)
		{
			int startTime = Environment.TickCount;
			Regex r = new Regex(from,RegexOptions.Multiline|regexOptions);
			//MatchCollection m = r.Matches(richTextBox2.Text);
			string tempText = richTextBox2.Text;
			MatchCollection m = r.Matches(tempText);
			int cnt = m.Count;   // tar 13 sek !!!
			int endTime = Environment.TickCount;
			Debug.WriteLine("Counting '"+from+"' took: "+(endTime-startTime).ToString()+"ms");
			return cnt;
		}



		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			saveAs(mud.filename);

		}


		public bool save()
		{
			String[] fA = mud.filename.Split('.');
			String ext = fA[fA.Length-1];									// extension part
			String filename = String.Join(".",fA,0,fA.Length-1);	// first part of filename
			
			if(ext.ToLower()=="rtf")
			{
				// just save
				try
				{
					richTextBox2.SaveFile(mud.filename,
						RichTextBoxStreamType.RichText
						//RichTextBoxStreamType.Text
						);
					Text="LogEdit ("+mud.filename+")";
					modified = "";
				}
				catch (Exception e) 
				{
					Debug.WriteLine(e.Message);
				}
				
				return true;
			}
			else
			{
				// Do a "SaveAs"
				return saveAs(filename+".rtf");
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			/*
			String[] fA = mud.filename.Split('.');
			String ext = fA[fA.Length-1];									// extension part
			String filename = String.Join(".",fA,0,fA.Length-1);	// first part of filename
			if(ext.ToLower()=="rtf")
			{
				// just save
				richTextBox2.SaveFile(mud.filename,
					RichTextBoxStreamType.RichText

					);
					Text="LogEdit ("+mud.filename+")";
			}
			else
			{
				// Do a "SaveAs"
				saveAs(filename+".rtf");
			}
			*/
			save();
		}

		public string modified = "";
		protected bool saveAs(string filename)
		{
			Stream myStream;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.InitialDirectory = mud.initialpath ;
			saveFileDialog1.Filter = 
				//"Text files (*.txt)|*.txt|"+
				"Rich Text files (*.rtf)|*.rtf";
			//"HTML files (*.html,*.htm)|*.html;*.htm|"+
			//"All files (*.*)|*.*" ;

			String[] fA = filename.Split('.');
			String ext = fA[fA.Length-1];									// extension part
			String filename2 = String.Join(".",fA,0,fA.Length-1);	// first part of filename


			if(filename2!="")
			{
				saveFileDialog1.FileName=filename2+".rtf";
			}
			//saveFileDialog1.FilterIndex = 1 ;
			saveFileDialog1.RestoreDirectory = true ;
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox2.SaveFile(saveFileDialog1.FileName,
					RichTextBoxStreamType.RichText
					//RichTextBoxStreamType.Text
					);

				mud.filename=saveFileDialog1.FileName;
				Text="LogEdit ("+mud.filename+")";
				modified = "";
				return true;
			}
			else
			{
				return false;
			}
		}

		
		public void findFilter(string from)
		{
			Regex r = new Regex(from,RegexOptions.Multiline);

			//MatchCollection m = r.Matches(richTextBox2.Text);
			Match m = r.Match(richTextBox2.Text);
			
			//if(m.Count>0)
			if(m.Success)
			{
				richTextBox2.Focus();
				richTextBox2.Select(m.Index,m.Length);
			}
		}
		

		
	
	


		

	

		

		

		

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel=true;
			exit();
			
		}

		private void filtermenu_Click(object sender, System.EventArgs e)
		{
			f.Visible=!f.Visible;
			filtermenu.Checked=f.Visible;
		}

		private void colormenu_Click(object sender, System.EventArgs e)
		{
			cf.Visible=!cf.Visible;
			colormenu.Checked=cf.Visible;
		}

		private void helpExport_Clicked(object sender, EventArgs e) 
		{
			//box.BackColor = System.Drawing.Color.Green;

		}


		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			//richTextBox3.Text="";

			// launch a save dialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.InitialDirectory = mud.initialpath ;
			saveFileDialog1.Filter = 
				"HTML file (*.html)|*.html|"+
				"ANSI file (*.ans)|*.ans|"+
				"Text file (*.txt)|*.txt";
			saveFileDialog1.Title = "Export";	
			//saveFileDialog1.ShowHelp=true;
			
			
			saveFileDialog1.HelpRequest +=new EventHandler(saveFileDialog1_HelpRequest);

			saveFileDialog1.RestoreDirectory = true ;
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string outFile = saveFileDialog1.FileName;
				string ext = outFile.Substring(outFile.LastIndexOf(".")+1);
				
				string outtext ="";
				bool data = false;
				switch (ext)
				{
					case "html": 
						outtext = rtfToHtml(richTextBox2.Rtf);
						data=true;
						break;
					case "txt":
						outtext = richTextBox2.Text;
						data=true;
						break;
					case "ans":
						outtext = rtfToAnsi(richTextBox2.Rtf);
						data=true;
						break;
					default:
						data=false;
						break;
				}
				
				if(data)
				{
					System.IO.StreamWriter file = new System.IO.StreamWriter(outFile);
					file.WriteLine(outtext);

					file.Close();
				}
				else
				{
					MessageBox.Show("Wrong filetype.", "File Error",
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

			}

		}

		public string rtfToHtml(string instring)
		{
			string crlf = "\r\n";
			//richTextBox3.Text="";
			string html ="";
			// Scan the header, figure out what color is what
			int colortbls =instring.IndexOf("\\colortbl")+11;
			int colortble = instring.IndexOf("}",colortbls+1);
			string colortbl = instring.Substring(colortbls,colortble-colortbls-1);
			string[] colortblA = colortbl.Split(';');

			// stylesheet
			string style = "";
			style +="<STYLE type=\"text/css\">"+crlf;
			style += "span {color: #C0C0C0}"+crlf;
	
			

			int r = richTextBox2.ForeColor.R;
			int g = richTextBox2.ForeColor.G;
			int b = richTextBox2.ForeColor.B;

			string myclr = r.ToString("X").PadLeft(2,'0')+g.ToString("X").PadLeft(2,'0')+b.ToString("X").PadLeft(2,'0');

			//style += "span {color: #"+myclr+"}\r\n";
			//style +="</STYLE>";

			//construct new colorlist

			Hashtable myList;
			myList = new Hashtable();
			for(int i=0;i<colortblA.Length;i++)
			{
				string cl = colortblA[i];
				string[] clA = cl.Split('\\');
				string tcl = cl;
				string tc = "";

				string red = clA[1].Substring(3);
				string green = clA[2].Substring(5);
				string blue = clA[3].Substring(4);
				
				r = int.Parse(red);
				g = int.Parse(green);
				b = int.Parse(blue);
				
				tc = r.ToString("X").PadLeft(2,'0')+g.ToString("X").PadLeft(2,'0')+b.ToString("X").PadLeft(2,'0');
				myList["\\cf"+(i+1).ToString()]=tc;
				style += "span.cf"+(i+1).ToString()+" {color: #"+tc+"}"+crlf;
			}

			//style += "span {color: #"+myList["\\cf1"]+"}\r\n";

			style +="</STYLE>"+crlf;
			// TODO: insert performance monitor
			statusBar1.Panels[0].Text="Parsing line ";
			Cursor.Current=Cursors.WaitCursor;
			//DateTime myTime = new DateTime();
			long starttime = Environment.TickCount;

			
			int stpos = 0;
			try
			{
				stpos = instring.IndexOf("\\fs18")+5;
			

				// Remove header
				string tstring = instring.Substring(stpos);
			
				// Remove footer
				tstring = tstring.Substring(0,tstring.LastIndexOf("}")-1);

				// Remove all LF's
				tstring = tstring.Replace("\r","");

			

				// fjern ting som kødder med html
				tstring = tstring.Replace("<","&#60;");
			
				//fix first color
				if(tstring[0]!='\\')
				{
					
					tstring = "\\cf1"+tstring;
				}
				else
				{
					
					tstring = "\\cf1 "+tstring;
				}
			
				
				string lastColor ="cf1";
			
				
				string[] tsA = tstring.Split('\n');
			
				int nrLines = tsA.Length;

				for(int i=0;i<tsA.Length;i++)
				{
					statusBar1.Panels[1].Text=i.ToString()+"/"+nrLines;  // 1 sec på 4000 linjer
					//string theLine = tsA[i].Substring(0,tsA[i].Length);
					string theLine = tsA[i];

					theLine = theLine.Replace("\n","");
					theLine = theLine.Replace("\r","");

					/// TODO: sett inn font først!!
					//theLine=theLine.Replace("\\par","");
					if(theLine.IndexOf("\\")!=0)
					{
						//theLine="<FONT color=\"green\">"+theLine;
						theLine="<SPAN class=\""+lastColor+"\">"+theLine;
					}

					// insert colors
					for(int j=1;j<colortblA.Length+1;j++)
					{
						//theLine=theLine.Replace("\\cf"+j.ToString()+" ","</FONT><FONT color=\"#"+myList["\\cf"+j.ToString()]+"\">");
						theLine=theLine.Replace("\\cf"+j.ToString()+" ","</SPAN><SPAN class=\"cf"+j.ToString()+"\">");
					}
					for(int j=1;j<colortblA.Length+1;j++)
					{
						int grr = theLine.IndexOf("\\cf"+j.ToString()+"\\par");
						if(grr>-1)
						{
							lastColor = theLine.Substring(grr+1,theLine.LastIndexOf("\\")-1-grr);
						}
						theLine=theLine.Replace("\\cf"+j.ToString()+"\\par","</SPAN>");
					}
					theLine=theLine.Replace("\\par","</SPAN>");
			
				
					int ttp = theLine.IndexOf("\\\'");
					while(ttp>-1)
					{
						string tcode = theLine.Substring(ttp+2,2);
						int tt = Convert.ToInt32(tcode,16);
						char ttc = Convert.ToChar(tt);
						theLine=theLine.Replace("\\\'"+tcode,"&#"+tt.ToString()+";");
						//theLine=theLine.Replace("\\\'"+tcode,ttc.ToString());
						ttp = theLine.IndexOf("\\\'");
					}
				
					//remove first </font>
					if(theLine.Substring(0,7).ToLower()=="</span>")
					{
						theLine=theLine.Substring(7);
					}
					html +=theLine+crlf;
					//richTextBox3.Text+=theLine+"\n";
				}
			}
			catch
			{
				stpos = 0;
				MessageBox.Show("The text in the document does not follow standard, output is most likely corrupted", "LogEdit",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				html = "";
			}
			
			//richTextBox3.Text="<html><body bgcolor=black text=green><pre>"+richTextBox3.Text+"</body></html>";
			string header = "";
			header +="<?xml version=\"1.0\" encoding=\"UTF-8\"?>"+crlf;
			header +="<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">"+crlf;
			header +="<HTML>"+crlf;
			header +="<HEAD>"+crlf;
			header +="<TITLE>LogEdit</TITLE>"+crlf;
			header +=style;
			header +="</HEAD>"+crlf;
			header +="<BODY bgcolor=\"black\" text=\"green\">"+crlf;
			header +="<PRE>"+crlf;
			//header +="<span style=\"font-family:Courier;font-size:10px\">\r\n";

			string footer = "";
			footer +=crlf;
			//footer +="</span>";
			footer +="</PRE>"+crlf;
			footer +="</BODY>"+crlf;
			footer +="</HTML>"+crlf;


			// instead of <pre>, replace all \r\n's with <br>\r\n
			//html = html.Replace("\r\n","<br>\r\n");

			html=header+html+footer;
			statusBar1.Panels[0].Text="";
			statusBar1.Panels[1].Text="";
			Cursor.Current=Cursors.Default;
			long endtime = Environment.TickCount-starttime;
			
			

			return html;
		}

		public string rtfToAnsi(string instring)
		{
			//richTextBox3.Text="";
			string html ="";
			// Scan the header, figure out what color is what
			int colortbls =instring.IndexOf("\\colortbl")+11;
			int colortble = instring.IndexOf("}",colortbls+1);
			string colortbl = instring.Substring(colortbls,colortble-colortbls-1);
			string[] colortblA = colortbl.Split(';');

			//construct new colorlist
			
			Hashtable myList,myAnsiL;
			myAnsiL = new Hashtable();
			myAnsiL["646464"]="1;30";
			myAnsiL["800000"]="0;31";
			myAnsiL["FF0000"]="1;31";
			myAnsiL["008000"]="0;32";
			myAnsiL["00FF00"]="1;32";
			myAnsiL["888800"]="0;33";
			myAnsiL["FFFF00"]="1;33";
			myAnsiL["000080"]="0;34";
			myAnsiL["0000FF"]="1;34";
			myAnsiL["880088"]="0;35";
			myAnsiL["FF00FF"]="1;35";
			myAnsiL["008888"]="0;36";
			myAnsiL["00FFFF"]="1;36";
			myAnsiL["CCCCCC"]="0;37";
			myAnsiL["C0C0C0"]="0;37";
			myAnsiL["FFFFFF"]="1;37";

			myList = new Hashtable();
			for(int i=0;i<colortblA.Length;i++)
			{
				string cl = colortblA[i];
				string[] clA = cl.Split('\\');
				string tcl = cl;
				string tc = "";

				string red = clA[1].Substring(3);
				string green = clA[2].Substring(5);
				string blue = clA[3].Substring(4);
				
				int r = int.Parse(red);
				int g = int.Parse(green);
				int b = int.Parse(blue);
				
				tc = r.ToString("X").PadLeft(2,'0')+g.ToString("X").PadLeft(2,'0')+b.ToString("X").PadLeft(2,'0');
				string tac = "";
				//if(myAnsiL[tc].ToString().Length>0)
				//{
				try 
				{
					tac = myAnsiL[""+tc].ToString();
				}
				catch
				{
					
					tac = "0;37";
				}
				//}
				//else
				//{
				//	tac = "0;37";		// grå hvis ikke finnes
				//}
				myList["\\cf"+(i+1).ToString()]=tac;
				//myList["\\cf"+(i+1).ToString()]=tc;
			}

			// TODO: insert performance monitor
			statusBar1.Panels[0].Text="Parsing line ";
			Cursor.Current=Cursors.WaitCursor;
			//DateTime myTime = new DateTime();
			long starttime = Environment.TickCount;

			
			int stpos = 0;
			try
			{
				stpos = instring.IndexOf("\\fs18")+5;
			
				// Remove header
				string tstring = instring.Substring(stpos);

				// Remove footer
				tstring = tstring.Substring(0,tstring.LastIndexOf("}")-1);

				//string tstring = instring.Substring(instring.IndexOf("fs18")+4);
			
				tstring = tstring.Replace("\r","");


				//tstring = tstring.Replace("<","&#60;");
			
				//fix first color
				if(tstring[0]!='\\')
				{
					
					tstring = "\\cf1"+tstring;
				}
				else
				{
					
					tstring = "\\cf1 "+tstring;
				}
			
				
				string lastColor ="cf1";
				string[] tsA = tstring.Split('\n');
				int nrLines = tsA.Length;
				for(int i=0;i<tsA.Length;i++)
				{
					statusBar1.Panels[1].Text=i.ToString()+"/"+nrLines;  // 1 sec på 4000 linjer
					//string theLine = tsA[i].Substring(0,tsA[i].Length);
					string theLine = tsA[i];
					/// TODO: sett inn font først!!
					//theLine=theLine.Replace("\\par","");
					if(theLine.IndexOf("\\")!=0)
					{
						theLine="\x1B"+"\x5B"+myList["\\"+lastColor]+"\x6D"+theLine;
					}

					// insert colors
					for(int j=1;j<colortblA.Length+1;j++)
					{
						theLine=theLine.Replace("\\cf"+j.ToString()+" ","\x1B"+"\x5B"+myList["\\cf"+j.ToString()]+"\x6D");
					}
					for(int j=1;j<colortblA.Length+1;j++)
					{
						//theLine=theLine.Replace("\\cf"+j.ToString()+"\\par","</font>");

						int grr = theLine.IndexOf("\\cf"+j.ToString()+"\\par");
						if(grr>-1)
						{
							lastColor = theLine.Substring(grr+1,theLine.LastIndexOf("\\")-1-grr);
						}

						theLine=theLine.Replace("\\cf"+j.ToString()+"\\par","\x1B"+"\x5B"+"0"+"\x6D");  
					}
					theLine=theLine.Replace("\\par","\x1B"+"\x5B"+"0"+"\x6D"); // mulig må inn med [0m
			
				
					int ttp = theLine.IndexOf("\\\'");
					while(ttp>-1)
					{
						string tcode = theLine.Substring(ttp+2,2);
						int tt = Convert.ToInt32(tcode,16);
						char ttc = Convert.ToChar(tt);
						//theLine=theLine.Replace("\\\'"+tcode,"&#"+tt.ToString()+";");
						theLine=theLine.Replace("\\\'"+tcode,ttc.ToString());
						ttp = theLine.IndexOf("\\\'");
					}
				
					//remove first </font>
					if(theLine.Substring(0,4).ToLower()=="\x1B"+"\x5B"+"0"+"\x6D")
					{
						theLine=theLine.Substring(4);
					}
					html +=theLine+"\r\n";
					//richTextBox3.Text+=theLine+"\n";
				}
			}
			catch
			{
				stpos = 0;
				MessageBox.Show("The text in the document does not follow standard, output is most likely corrupted", "LogEdit",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				html = "";
			}
			//richTextBox3.Text="<html><body bgcolor=black text=green><pre>"+richTextBox3.Text+"</body></html>";
			//html="<html>\r\n<body bgcolor=black text=green>\r\n<pre>\r\n"+html+"\r\n</body>\r\n</html>";
			statusBar1.Panels[0].Text="";
			statusBar1.Panels[1].Text="";
			Cursor.Current=Cursors.Default;
			long endtime = Environment.TickCount-starttime;
			
			return html;
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			aboutform = new about();
			aboutform.Owner = this;
			aboutform.TopMost = false;
			aboutform.frm=this;
			aboutform.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(modified!="")
			{
				string thefile = mud.filename;
				if(thefile=="")
				{
					thefile="Untitled";
				}
				DialogResult svar = new DialogResult();

				svar = MessageBox.Show("The text in the "+thefile+" file has changed.\r\nDo you want to save the changes?", "LogEdit",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (svar==DialogResult.Yes)
				{
					//SaveAs
					if(save()==true)
					{
						newFile();
					}
				}
				if (svar==DialogResult.No)
				{
					// call newFile
					newFile();
				}
			}
			else
			{
				newFile();
			}
		}


		public void newFile ()
		{
			richTextBox2.Text="";
			mud = new mudReader();
			mud.initialpath=initialpath;
			modified = "";
			Text = "LogEdit";
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			//richTextBox2.ClearUndo
			//richTextBox2.u
			richTextBox2.Undo();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			richTextBox2.Cut();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			richTextBox2.Copy();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			//richTextBox2.SelectedText="";
			
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			IDataObject data = Clipboard.GetDataObject();
			if(data.GetDataPresent("CF_ANSI"))
			{
				
				Debug.WriteLine("Pasting ANSI");
				//e.Handled = true; 
				paste();
			}
			else
			{
				foreach (string key in data.GetFormats())
				{
					Debug.WriteLine("Pasting something else: "+key);
				}
				int startPos = richTextBox2.SelectionStart;

				if(data.GetDataPresent("HTML Format"))
				{
					
					richTextBox2.Paste(DataFormats.GetFormat(DataFormats.Text));
					Debug.WriteLine("BUG in HTML forces me to paste as pure text");
				}
				else
				{
					/// TODO: CHANGE FROM SILVER TO C0C0C0
					richTextBox2.ForeColor=Color.FromArgb(192,192,192);
					richTextBox2.Paste();
					Debug.WriteLine("Pasting RTF or pure text");
				}
				
				int endPos = richTextBox2.SelectionStart;


				Debug.WriteLine("Marking from "+startPos.ToString()+" to "+endPos.ToString());
				//richTextBox2.SelectionStart=startPos;
				//richTextBox2.SelectionLength=endPos-startPos;

				//Font myFont = new Font("Courier New",9);
				//richTextBox2.SelectionFont=myFont;
				//richTextBox2.SelectionStart=endPos;
				//richTextBox2.SelectionLength=0;
				
			}



			
			//e.Handled=true;
			data=null;
		}

		private void menuItem16_Click_1(object sender, System.EventArgs e)
		{
			richTextBox2.Redo();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			richTextBox2.SelectAll();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			//richTextBox2.loc

			//MessageBox ff = new MessageBox;
			if(ff.Visible==true)
			{
				ff.Select();
			}
			else
			{
				ff.Show();
			}
			//richTextBox2.Find("text");
			//richTextBox2.SelectionStart=richTextBox2.Text.IndexOf();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			if(repf.Visible==true)
			{
				repf.Select();
			}
			else
			{
				repf.Show();
			}
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			exit();
			
		}


		private void exit ()
		{
			bool abort = false;
			//	rk = Registry.CurrentUser;
			//	rk.OpenSubKey("software\\logedit",true);
			//	int main_x,main_y,main_w,main_h;

			try
			{
				rk.SetValue("main_x",this.Left);
				rk.SetValue("main_y",this.Top);
				rk.SetValue("main_w",this.Width);
				rk.SetValue("main_h",this.Height);
				rk.SetValue("main_mode",this.WindowState.ToString());

				rk.SetValue("filter_x",f.Left);
				rk.SetValue("filter_y",f.Top);
				rk.SetValue("filter_w",f.Width);
				rk.SetValue("filter_h",f.Height);
				rk.SetValue("filter_visible",f.Visible.ToString());

				rk.SetValue("color_x",cf.Left);
				rk.SetValue("color_y",cf.Top);
				rk.SetValue("color_w",cf.Width);
				rk.SetValue("color_h",cf.Height);
				rk.SetValue("color_visible",cf.Visible.ToString());

				rk.SetValue("customcolor_x",ccf.Left);
				rk.SetValue("customcolor_y",ccf.Top);
				rk.SetValue("customcolor_w",ccf.Width);
				rk.SetValue("customcolor_h",ccf.Height);
				rk.SetValue("customcolor_visible",ccf.Visible.ToString());

				
				rk.SetValue("initialpath",mud.initialpath);
				
				rk.Close();
			}
			catch {}
			
			if(modified!="")
			{
				string thefile = mud.filename;
				if(thefile=="")
				{
					thefile="Untitled";
				}
				DialogResult svar = new DialogResult();

				svar = MessageBox.Show("The text in the "+thefile+" file has changed.\r\nDo you want to save the changes?", "LogEdit",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (svar==DialogResult.Cancel)
				{
					abort=true;
				}
				if (svar==DialogResult.Yes)
				{
					if(save()==false)
					{
						abort = true;
					}
				}
			}
			if(abort==false)
			{
				Application.Exit();
			}
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			defcolorsmenu.Checked=!defcolorsmenu.Checked;
			ccf.Visible=defcolorsmenu.Checked;
		}

		private void saveFileDialog1_HelpRequest(object sender, EventArgs e)
		{
			HelpNavigator navigator = HelpNavigator.Topic;
			helpProvider1.HelpNamespace="LogEdit.chm";
			Help.ShowHelp(this,"LogEdit.chm",navigator,"Overview_Export.htm");
		}

		private void menuItem23_Click_1(object sender, System.EventArgs e)
		{
			HelpNavigator navigator = HelpNavigator.Topic;
			helpProvider1.HelpNamespace="LogEdit.chm";
			Help.ShowHelp(this,"LogEdit.chm",navigator,"WelcometoLogEdit.htm");

		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//regReplace("host.songnetworks.se","NATOIL",RexexOptions.IgnoreCase);
		}


		// FOR MYE KØDD MED DENNA
		public bool regReplace(string InPattern,string OutPattern,RegexOptions options,Color aColor)
		{
			bool coloronly=false;
			if(OutPattern==InPattern)
			{
				coloronly=true;
			}
			string newTest = "";
			//OutPattern = "\\cf1 "+OutPattern;
			Cursor.Current = Cursors.WaitCursor;


			// test another escape
			StringBuilder ip = new StringBuilder();
			Regex esc = new Regex(@"\[().*?^$]|\\(?!x).?(?:[+*]?)(?:[?]?)|.[+*]|.{1}");		// matching all possible chars
			MatchCollection escM = esc.Matches(InPattern);
			Debug.WriteLine("Match count: "+escM.Count.ToString());
			string optional = "(?:\\\\'\\w{2})?(?:\\\\cf\\d+\\s)?";
			foreach(Match escmatch in escM)
			{
				bool escape =	false;
				string theChar = escmatch.Value;
				char myChar;
				if(theChar[0]=='[' && theChar[theChar.Length-1]==']')
				{
					escape = true;

				}
				else if(theChar.Length>1)			// escaped chars
				{
					switch (theChar)
					{
						case	@"\b"	:	
							escape=false;
							break;
						case	@"\."	:	
							escape=true;
							break;
						case @"\[" :
							escape=true;
							break;
						case @"\(" :
							escape=true;
							break;
						case @"\)" :
							escape=true;
							break;
						case @"\\" :
							escape=true;
							break;
						case @"\^" :
							escape=true;
							break;
						case @"\$" :
							escape=true;
							break;
						case @"\|" :
							escape=true;
							break;
						case @"\?" :
							escape=true;
							break;
						case @"\*" :
							escape=true;
							break;
						case @"\+" :
							escape=true;
							break;
						default :
							escape=true;
							break;
					}
				}
				else	// single chars
				{
					
					switch (theChar)
					{
						case @"*"	:
							escape=false;
							break;
						case @"+"	:
							escape=false;
							break;
						case @"["	:
							escape=false;
							break;
						case @"\"	:
							escape=false;
							break;
						case @"^"	:
							escape=false;
							break;
						case @"$"	:
							escape=false;
							break;
						case @"."	:
							escape=false;
							break;
						case @"|"	:
							escape=false;
							break;
						case @"?"	:
							escape=false;
							break;
						case @"("	:
							escape=false;
							break;
						case @")"	:
							escape=false;
							break;
						default :
							escape=true;
							break;
					}
				}
				if(escape)
				{
					ip.Append(theChar);
					//ip.Append("(\\\\cf\\d+\\s)?");
					//ip.Append("(?:\\\\cf\\d+\\s)?(?:\\\\'\\w{2})?");
					ip.Append(optional);
					Debug.WriteLine("Should have optional color: "+escmatch.Value);
				}
				else
				{
					ip.Append(theChar);					
					Debug.WriteLine("Should not have optional color: "+escmatch.Value);
				}
			}
			//Debug.WriteLine("ESCAPED PATTERN: "+ip.ToString());	

			//InPattern=ip.ToString().Substring(0,ip.ToString().LastIndexOf('('));
			if(ip.ToString().Substring(ip.ToString().LastIndexOf('('))=="(?:\\\\cf\\d+\\s)?")
			{
				InPattern=ip.ToString().Substring(0,ip.ToString().LastIndexOf('('));
			}
			else
			{
				InPattern=ip.ToString();
			}
			
			Debug.WriteLine("ESCAPED PATTERN: "+InPattern);	

			
//			CONVERTS THE PATTERN TO HEX
//			StringBuilder ip = new StringBuilder();
//			char lastchar = "";
//			foreach(char ch in InPattern)
//			{
//				int c = (int) ch;
//				if(lastchar=='\\')
//				{
//					ip.Append(ch);
//				}
//				else
//				{
//					switch (ch) 
//					{
//						case '\\':
//							ip.Append(ch);
//							break;
//						case '^':
//							ip.Append(ch);
//							break;
//						case '*':
//							ip.Append(ch);
//							break;
//						case '.':
//							ip.Append(ch);
//							break;
//						default:
//							ip.Append("\\x"+c.ToString("x"));
//							break;
//					}
//				}
//				lastchar=ch;
//			}
//			Debug.WriteLine("Escaped pattern: "+ip.ToString());
//			char lastchar;
//			InPattern=ip.ToString();


			int n=0;
			StringBuilder p = new StringBuilder();
			//Regex reg = new Regex(@"(?<!\\)(\w)(?!$)");
			try
			{
				
//				Regex reg = new Regex(@"(\\\w{3})(?!$)");				// all hex chars except last
				

			
//				p.Append(reg.Replace(InPattern,"${1}(\\\\cf\\d+\\s)?"));
				//p.Insert(0,"(\\\\cf\\d+\\s)?");
//				p.Insert(0,'(');
//				p.Append(')');
			
				//p.Insert(0,"((\\\\cf\\d+\\s)|^).*?");
				//p.Insert(0,"(?<=(\\\\cf\\d+\\s).*?)");

//			while (n<InPattern.Length-1)
//			{
//				p.Append(InPattern[n]);
//				p.Append(@"(\\cf\d+\s)?");
//				lastchar=InPattern[n];
//				n++;
//			}
			p.Append(InPattern);


				Debug.WriteLine("Started looking for: "+p.ToString());
				try 
				{


					n=0;
					int startTime = Environment.TickCount;
			
					newTest = richTextBox2.Rtf;
					RichTextBox myRtf = new RichTextBox();
					
					
					myRtf.Rtf = richTextBox2.Rtf;
					string outColor="";
					if(aColor.IsEmpty==false)
					{
						Debug.WriteLine("Gotten a color");
						// find the bloody color
						// search the rtf file for the specific color
						//if exists, return the specific cf
						//string temps = myRtf.Rtf;
						string temps = newTest;
						string searchColor="\\red"+aColor.R+"\\green"+aColor.G+"\\blue"+aColor.B;

						int startPos = temps.IndexOf("{\\colortbl ");
						int endPos = temps.IndexOf("}",startPos);

						string colorstring = temps.Substring(startPos,endPos-startPos-1);
						colorstring = colorstring.Substring(12);
						Debug.WriteLine("ColorTable: "+colorstring);

						string[] colorA = colorstring.Split(';');
						
						//colorstring = "{\\colortbl ";
						StringBuilder newCtbl = new StringBuilder();
						newCtbl.Append("{\\colortbl ;");
						int m=1;
						bool found=false;
						foreach(string line in colorA)
						{
							Debug.WriteLine("Comparing '"+line+"' to '"+searchColor+"'");
							newCtbl.Append(line+";");
							if(line==searchColor)
							{
								outColor="\\cf"+m.ToString()+" ";
								found=true;
								Debug.WriteLine("Matching color "+outColor);
								//break;
							}
							m++;
						}
						if(found==false)
						{
							outColor="\\cf"+m.ToString()+" ";
							newCtbl.Append(searchColor);
							newCtbl.Append(";");
							


							

							//myRtf.SelectionLength=1;
							//myRtf.SelectionColor=aColor;
							Debug.WriteLine("Making color "+outColor);
						}
						// write out color table
						newCtbl.Append("}");
						newCtbl.Replace("  "," ");
						Debug.WriteLine("New colortable: "+newCtbl.ToString());
						string nRtf = newTest.Substring(0,startPos)+newCtbl.ToString()+newTest.Substring(endPos+1);
						newTest = nRtf;


						OutPattern=outColor+OutPattern;
						Debug.WriteLine("Outpattern:"+OutPattern);
					}
					else
					{
						Debug.WriteLine("GOT NO COLOR");
					}

//					myRtf.Rtf=myRtf.Rtf.Replace("\n","\n\\cf1 ");
					//newTest = newTest.Replace("\n","\n\\cf1 ");
					Regex r = new Regex(p.ToString(),options|RegexOptions.Multiline);
					StringBuilder urk= new StringBuilder();
					MatchCollection ma;
					ma = r.Matches(newTest);
					int lastmatch = 0;
					Regex lastColor = new Regex("\\\\cf\\d+",RegexOptions.RightToLeft|RegexOptions.IgnoreCase);
					Regex colorsR = new Regex("\\\\cf\\d+\\s?",RegexOptions.IgnoreCase);
					foreach(Match mm in ma)
					{
						urk.Append(newTest.Substring(lastmatch,mm.Index-lastmatch));
						Match mu = lastColor.Match(urk.ToString().Substring(0,urk.Length-1));
						//urk.Append(OutPattern);
						if(coloronly==true)
						{
							string oo = mm.Value;
							oo = colorsR.Replace(oo,"");
							urk.Append(outColor+oo);
						}
						else
						{
							urk.Append(OutPattern);
						}
						
						//Debug.WriteLine("Last color: "+mu.Value);
						urk.Append(mu.Value+" ");
						
						lastmatch=mm.Index+mm.Length;
					}
					urk.Append(newTest.Substring(lastmatch));
					newTest = urk.ToString();

					//newTest = r.Replace(newTest,OutPattern);
					
					//Debug.WriteLine("Third: "+newTest.Substring(0,newTest.Length-1));
					try 
					{
						//Debug.WriteLine("Third: "+newTest.Substring(0,500));
					}
					catch {}
					int endTime = Environment.TickCount;
					Debug.WriteLine("Replacement took: "+(endTime-startTime).ToString()+"ms");
					
					myRtf.Rtf=newTest;

					myRtf.SelectAll();
					myRtf.Copy();
					richTextBox2.SelectAll();
					richTextBox2.Paste();
					Cursor.Current = Cursors.Default;
					return true;
				}
				catch (Exception e)
				{
					Debug.WriteLine("Replace all exception: "+e.Message);
					//MessageBox.Show("Error replace.");
					return false;
				// RUN old replace all ? or messagebox
				}
			}
			catch (Exception e)
			{
				//MessageBox.Show("Error in search pattern.");
				Debug.WriteLine("Replace all exception: "+e.Message);
				return false;
			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			progressPanel1.Value=progValue;
			Debug.WriteLine("Timer");
			statusBar1.Refresh();
		}

		

		
	}

	

	
			
	
	public class mudColor
	{
		int priv_r=0;
		int priv_g=0;
		int priv_b=0;
		string priv_ansi;
		string priv_rtf;
		string priv_rtfCode;
		string priv_name;
		Color priv_color;
		
		private bool setColor(int r,int g,int b)
		{
			if(valid(r) && valid(g) && valid(b))
			{
				priv_r=r;
				priv_g=g;
				priv_b=b;

				priv_color=Color.FromArgb(r,g,b);
				priv_rtf="\\red"+r.ToString()+"\\green"+g.ToString()+"\\blue"+b.ToString()+";";

				return true;
			}
			else
			{
				return false;
			}
		}

		public mudColor(string colorname)
		{
			bool valid = false;
			switch (colorname.ToLower())
			{
				case "black":
					valid = setColor(100,100,100);
					//priv_ansi ="30";
					break;
				case "black bold":
					valid = setColor(100,100,100);
					break;
				case "red":
					valid = setColor(128,0,0);
					break;
				case "red bold":
					valid = setColor(255,0,0);
					break;
				case "green":
					valid = setColor(0,128,100);
					break;
				case "green bold":
					valid = setColor(0,255,100);
					break;
				case "yellow":
					valid = setColor(136,136,100);
					break;
				case "yellow bold":
					valid = setColor(255,255,100);
					break;
				case "blue":
					valid = setColor(0,0,128);
					break;
				case "blue bold":
					valid = setColor(0,0,128);
					break;
				case "magenta":
					valid = setColor(136,0,136);
					break;
				case "magenta bold":
					valid = setColor(255,0,255);
					break;
				case "cyan":
					valid = setColor(0,136,136);
					break;
				case "cyan bold":
					valid = setColor(0,255,255);
					break;
				case "white":
					valid = setColor(192,192,192);
					break;
				case "white bold":
					valid = setColor(255,255,255);
					break;
				default:
					valid = false;
					break;


			}

		}

		public mudColor(int r,int g,int b)
		{
			setColor(r,g,b);
		}

		public Color Color
		{
			get 
			{
				return priv_color;
			}
		}

		private bool valid(int nr)
		{
			if(nr>=0 && nr <=255)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool valid(string color)
		{
			bool valid = false;
			switch (color)
			{
				case "black":
					valid = true;
					break;
				case "black bold":
					valid = true;
					break;
				default:
					valid = false;
					break;


			}
			return valid;
		}
	}



	







}

	