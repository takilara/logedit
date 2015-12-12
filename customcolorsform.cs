using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;



namespace logedit
{
	/// <summary>
	/// Summary description for customcolorsform.
	/// </summary>
	public class customcolorsform : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		public customcolorsform()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(customcolorsform));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAllonClean = new System.Windows.Forms.Button();
			this.casebox = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.buttonAllDown = new System.Windows.Forms.Button();
			this.buttonAllUp = new System.Windows.Forms.Button();
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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.AddBtn = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.btnAllonClean);
			this.panel1.Controls.Add(this.casebox);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.buttonAllDown);
			this.panel1.Controls.Add(this.buttonAllUp);
			this.panel1.Controls.Add(this.whitebold);
			this.panel1.Controls.Add(this.white);
			this.panel1.Controls.Add(this.cyanbold);
			this.panel1.Controls.Add(this.cyan);
			this.panel1.Controls.Add(this.magentabold);
			this.panel1.Controls.Add(this.magenta);
			this.panel1.Controls.Add(this.bluebold);
			this.panel1.Controls.Add(this.blue);
			this.panel1.Controls.Add(this.yellowbold);
			this.panel1.Controls.Add(this.yellow);
			this.panel1.Controls.Add(this.greenbold);
			this.panel1.Controls.Add(this.green);
			this.panel1.Controls.Add(this.redbold);
			this.panel1.Controls.Add(this.red);
			this.panel1.Controls.Add(this.blackbold);
			this.panel1.Controls.Add(this.black);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.AddBtn);
			this.panel1.Controls.Add(this.buttonDown);
			this.panel1.Controls.Add(this.buttonUp);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 173);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(288, 168);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btnAllonClean
			// 
			this.btnAllonClean.Location = new System.Drawing.Point(104, 136);
			this.btnAllonClean.Name = "btnAllonClean";
			this.btnAllonClean.Size = new System.Drawing.Size(184, 23);
			this.btnAllonClean.TabIndex = 55;
			this.btnAllonClean.Text = "Apply all on Clean";
			this.toolTip1.SetToolTip(this.btnAllonClean, "Apply the colors to clean text. (Much Faster!)");
			this.btnAllonClean.Click += new System.EventHandler(this.button4_Click_2);
			// 
			// casebox
			// 
			this.casebox.Checked = true;
			this.casebox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.casebox.Location = new System.Drawing.Point(8, 112);
			this.casebox.Name = "casebox";
			this.casebox.Size = new System.Drawing.Size(88, 24);
			this.casebox.TabIndex = 54;
			this.casebox.Text = "Match Case";
			this.casebox.CheckedChanged += new System.EventHandler(this.casebox_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(104, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 24);
			this.button1.TabIndex = 53;
			this.button1.Text = "Apply This";
			this.toolTip1.SetToolTip(this.button1, "Apply the colorfilters to the document.");
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(200, 112);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(88, 24);
			this.button5.TabIndex = 51;
			this.button5.Text = "Apply All";
			this.toolTip1.SetToolTip(this.button5, "Apply the colorfilters to the document.");
			this.button5.Click += new System.EventHandler(this.button5_Click_3);
			// 
			// buttonAllDown
			// 
			this.buttonAllDown.Enabled = false;
			this.buttonAllDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllDown.Image")));
			this.buttonAllDown.Location = new System.Drawing.Point(224, 32);
			this.buttonAllDown.Name = "buttonAllDown";
			this.buttonAllDown.Size = new System.Drawing.Size(24, 23);
			this.buttonAllDown.TabIndex = 50;
			this.toolTip1.SetToolTip(this.buttonAllDown, "Click to move the current filter to the bottom. (Ctrl-Alt-End)");
			this.buttonAllDown.Click += new System.EventHandler(this.buttonAllDown_Click);
			// 
			// buttonAllUp
			// 
			this.buttonAllUp.Enabled = false;
			this.buttonAllUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllUp.Image")));
			this.buttonAllUp.Location = new System.Drawing.Point(224, 8);
			this.buttonAllUp.Name = "buttonAllUp";
			this.buttonAllUp.Size = new System.Drawing.Size(24, 23);
			this.buttonAllUp.TabIndex = 49;
			this.toolTip1.SetToolTip(this.buttonAllUp, "Click to move the current filter to the top. (Ctrl-Alt-Home)");
			this.buttonAllUp.Click += new System.EventHandler(this.buttonAllUp_Click);
			// 
			// whitebold
			// 
			this.whitebold.Location = new System.Drawing.Point(176, 32);
			this.whitebold.Name = "whitebold";
			this.whitebold.Size = new System.Drawing.Size(24, 23);
			this.whitebold.TabIndex = 47;
			this.toolTip1.SetToolTip(this.whitebold, "Click to set the color of the colorfilter.");
			this.whitebold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.whitebold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// white
			// 
			this.white.Location = new System.Drawing.Point(176, 8);
			this.white.Name = "white";
			this.white.Size = new System.Drawing.Size(24, 23);
			this.white.TabIndex = 46;
			this.toolTip1.SetToolTip(this.white, "Click to set the color of the colorfilter.");
			this.white.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.white.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// cyanbold
			// 
			this.cyanbold.Location = new System.Drawing.Point(152, 32);
			this.cyanbold.Name = "cyanbold";
			this.cyanbold.Size = new System.Drawing.Size(24, 23);
			this.cyanbold.TabIndex = 45;
			this.toolTip1.SetToolTip(this.cyanbold, "Click to set the color of the colorfilter.");
			this.cyanbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.cyanbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// cyan
			// 
			this.cyan.Location = new System.Drawing.Point(152, 8);
			this.cyan.Name = "cyan";
			this.cyan.Size = new System.Drawing.Size(24, 23);
			this.cyan.TabIndex = 44;
			this.toolTip1.SetToolTip(this.cyan, "Click to set the color of the colorfilter.");
			this.cyan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.cyan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// magentabold
			// 
			this.magentabold.Location = new System.Drawing.Point(128, 32);
			this.magentabold.Name = "magentabold";
			this.magentabold.Size = new System.Drawing.Size(24, 23);
			this.magentabold.TabIndex = 43;
			this.toolTip1.SetToolTip(this.magentabold, "Click to set the color of the colorfilter.");
			this.magentabold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.magentabold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// magenta
			// 
			this.magenta.Location = new System.Drawing.Point(128, 8);
			this.magenta.Name = "magenta";
			this.magenta.Size = new System.Drawing.Size(24, 23);
			this.magenta.TabIndex = 42;
			this.toolTip1.SetToolTip(this.magenta, "Click to set the color of the colorfilter.");
			this.magenta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.magenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// bluebold
			// 
			this.bluebold.Location = new System.Drawing.Point(104, 32);
			this.bluebold.Name = "bluebold";
			this.bluebold.Size = new System.Drawing.Size(24, 23);
			this.bluebold.TabIndex = 41;
			this.toolTip1.SetToolTip(this.bluebold, "Click to set the color of the colorfilter.");
			this.bluebold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.bluebold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// blue
			// 
			this.blue.Location = new System.Drawing.Point(104, 8);
			this.blue.Name = "blue";
			this.blue.Size = new System.Drawing.Size(24, 23);
			this.blue.TabIndex = 40;
			this.toolTip1.SetToolTip(this.blue, "Click to set the color of the colorfilter.");
			this.blue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// yellowbold
			// 
			this.yellowbold.Location = new System.Drawing.Point(80, 32);
			this.yellowbold.Name = "yellowbold";
			this.yellowbold.Size = new System.Drawing.Size(24, 23);
			this.yellowbold.TabIndex = 39;
			this.toolTip1.SetToolTip(this.yellowbold, "Click to set the color of the colorfilter.");
			this.yellowbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.yellowbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// yellow
			// 
			this.yellow.Location = new System.Drawing.Point(80, 8);
			this.yellow.Name = "yellow";
			this.yellow.Size = new System.Drawing.Size(24, 23);
			this.yellow.TabIndex = 38;
			this.toolTip1.SetToolTip(this.yellow, "Click to set the color of the colorfilter.");
			this.yellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// greenbold
			// 
			this.greenbold.Location = new System.Drawing.Point(56, 32);
			this.greenbold.Name = "greenbold";
			this.greenbold.Size = new System.Drawing.Size(24, 23);
			this.greenbold.TabIndex = 37;
			this.toolTip1.SetToolTip(this.greenbold, "Click to set the color of the colorfilter.");
			this.greenbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.greenbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// green
			// 
			this.green.Location = new System.Drawing.Point(56, 8);
			this.green.Name = "green";
			this.green.Size = new System.Drawing.Size(24, 23);
			this.green.TabIndex = 36;
			this.toolTip1.SetToolTip(this.green, "Click to set the color of the colorfilter.");
			this.green.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// redbold
			// 
			this.redbold.Location = new System.Drawing.Point(32, 32);
			this.redbold.Name = "redbold";
			this.redbold.Size = new System.Drawing.Size(24, 23);
			this.redbold.TabIndex = 35;
			this.toolTip1.SetToolTip(this.redbold, "Click to set the color of the colorfilter.");
			this.redbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.redbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// red
			// 
			this.red.Location = new System.Drawing.Point(32, 8);
			this.red.Name = "red";
			this.red.Size = new System.Drawing.Size(24, 23);
			this.red.TabIndex = 34;
			this.toolTip1.SetToolTip(this.red, "Click to set the color of the colorfilter.");
			this.red.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// blackbold
			// 
			this.blackbold.Location = new System.Drawing.Point(8, 32);
			this.blackbold.Name = "blackbold";
			this.blackbold.Size = new System.Drawing.Size(24, 23);
			this.blackbold.TabIndex = 33;
			this.toolTip1.SetToolTip(this.blackbold, "Click to set the color of the colorfilter.");
			this.blackbold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.blackbold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// black
			// 
			this.black.Location = new System.Drawing.Point(8, 8);
			this.black.Name = "black";
			this.black.Size = new System.Drawing.Size(24, 23);
			this.black.TabIndex = 32;
			this.toolTip1.SetToolTip(this.black, "Click to set the color of the colorfilter.");
			this.black.MouseUp += new System.Windows.Forms.MouseEventHandler(this.black_MouseUp);
			this.black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.black_MouseDown);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(200, 88);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Delete";
			this.toolTip1.SetToolTip(this.button3, "Delete the selected colorfilter.");
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(104, 88);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Update";
			this.toolTip1.SetToolTip(this.button2, "Update the selected colorfilter.");
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BackColor = System.Drawing.Color.Black;
			this.richTextBox1.ContextMenu = this.contextMenu1;
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
			this.richTextBox1.Location = new System.Drawing.Point(8, 64);
			this.richTextBox1.Multiline = false;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(280, 24);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																												 this.menuItem2,
																												 this.menuItem1,
																												 this.menuItem3});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem2.Text = "Paste";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem1.Text = "Copy";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click_1);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menuItem3.Text = "Cut";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(8, 88);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(90, 23);
			this.AddBtn.TabIndex = 0;
			this.AddBtn.Text = "Add";
			this.toolTip1.SetToolTip(this.AddBtn, "Add color filter.");
			this.AddBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Enabled = false;
			this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
			this.buttonDown.Location = new System.Drawing.Point(200, 32);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(24, 23);
			this.buttonDown.TabIndex = 3;
			this.toolTip1.SetToolTip(this.buttonDown, "Move the selected filter down. (Ctrl-Alt-Down)");
			this.buttonDown.Click += new System.EventHandler(this.button6_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Enabled = false;
			this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
			this.buttonUp.Location = new System.Drawing.Point(200, 8);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(24, 23);
			this.buttonUp.TabIndex = 2;
			this.toolTip1.SetToolTip(this.buttonUp, "Move the selected filter up. (Ctrl-Alt-Up)");
			this.buttonUp.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(208, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 20);
			this.textBox1.TabIndex = 52;
			this.textBox1.Text = "10000";
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.listView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(288, 173);
			this.panel2.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.Black;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																												this.columnHeader1,
																												this.columnHeader2,
																												this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.ForeColor = System.Drawing.Color.Silver;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(288, 173);
			this.listView1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.listView1, "Your current colorfilters.");
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Active";
			this.columnHeader1.Width = 23;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Text";
			this.columnHeader2.Width = 237;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Color";
			this.columnHeader3.Width = 0;
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "LogEdit.chm";
			// 
			// customcolorsform
			// 
			this.AcceptButton = this.AddBtn;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 341);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.helpProvider1.SetHelpKeyword(this, "Overview_CC.htm");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "customcolorsform";
			this.helpProvider1.SetShowHelp(this, true);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Custom Colors";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customcolorsform_KeyDown);
			this.Resize += new System.EventHandler(this.customcolorsform_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.customcolorsform_Closing);
			this.Load += new System.EventHandler(this.customcolorsform_Load);
			this.Activated += new System.EventHandler(this.customcolorsform_Activated);
			this.Deactivate += new System.EventHandler(this.customcolorsform_Deactivate);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion



		public Form1 frm;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		public System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button whitebold;
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
		private DataSet fs;
		private DataTable dt;

		public int count = 0;
		public Color selectionColor = Color.FromArgb(60,60,60);
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonAllUp;
		private System.Windows.Forms.Button buttonAllDown;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox casebox;
		private bool itemselected = false;
		private System.Windows.Forms.Button btnAllonClean;
		private RegexOptions caseO;
		private void customcolorsform_Load(object sender, System.EventArgs e)
		{
			caseO = RegexOptions.None;
			richTextBox1.ForeColor=Color.FromArgb(204,204,204);
			//columnHeader1.Text="Text";
			listView1.Columns[0].Width=20;
			listView1.Columns[1].Width=this.Width-(listView1.Columns[0].Width+12);
			listView1.Columns[0].ListView.BackColor=Color.Black;
			listView1.ForeColor=Color.FromArgb(204,204,204);
			
			//ListViewItem li = new ListViewItem();

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

			this.richTextBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseWheel);




			itemselected = false;
			// Default filters
			
			//frm = new Form1();
			//listView1.Items.Add(new ListViewItem(new string[]{"TICK IN 5 SECONDS.","TICK","0"}));
			fs = new DataSet();
			dt = new DataTable("myTable");

			

			DataColumn myC;
			DataRow myR;
 
			myC = new DataColumn();
			myC.DataType = System.Type.GetType("System.Int32");
			myC.ColumnName = "id";
			myC.ReadOnly = true;
			myC.Unique = true;
			myC.AutoIncrement = true;
			dt.Columns.Add(myC);

			// Create second column.
			myC = new DataColumn();
			myC.DataType = System.Type.GetType("System.String");
			myC.ColumnName = "Text";
			myC.AutoIncrement = false;
			myC.Caption = "ParentItem";
			myC.ReadOnly = false;
			myC.Unique = false;
			// Add the column to the table.
			dt.Columns.Add(myC);
 
			myC = new DataColumn();
			myC.DataType = System.Type.GetType("System.String");
			myC.ColumnName = "Color";
			myC.AutoIncrement = false;
			myC.Caption = "ParentItem";
			myC.ReadOnly = false;
			myC.Unique = false;
			// Add the column to the table.
			dt.Columns.Add(myC);


			myC = new DataColumn();
			
			myC.DataType = System.Type.GetType("System.Boolean");
			myC.ColumnName = "enabled";
			myC.ReadOnly = false;
			myC.AllowDBNull=false;
			
			myC.Unique = false;
			myC.AutoIncrement = false;
			myC.DefaultValue=true;
			dt.Columns.Add(myC);



			// Make the ID column the primary key column.
			DataColumn[] PrimaryKeyColumns = new DataColumn[1];
			PrimaryKeyColumns[0] = dt.Columns["id"];
			dt.PrimaryKey = PrimaryKeyColumns;

			fs.Tables.Add(dt);

			
			loadFile("customcolors.xml");
			

			// fill fs from file..

			
		}


		private void loadFile(string fileName)
		{
			while(listView1.Items.Count>0)
			{
				ListViewItem lI = new ListViewItem();
				lI = listView1.Items[0];
				lI.SubItems.Clear();
				lI.Remove();
			}
			dt.Clear();
			try
			{
				fs.ReadXml(fileName);
			}
			catch {}
			for(int i=0;i<dt.Rows.Count;i++)
			{
				
				ListViewItem lI = new ListViewItem(new string[]{"",dt.Rows[i]["Text"].ToString(),dt.Rows[i]["Color"].ToString(),"0"});
				lI.Checked= (bool) dt.Rows[i]["enabled"];
				lI.ForeColor=Color.FromArgb(Int32.Parse(dt.Rows[i]["Color"].ToString()));
				listView1.Items.Add(lI);
			}
		}


		private void saveFile(string fileName)
		{
			dt.Clear();
			for(int i=0;i<listView1.Items.Count;i++)
			{
				string Text = listView1.Items[i].SubItems[1].Text;
				string myColor = listView1.Items[i].SubItems[2].Text;
				bool enabled = (bool) listView1.Items[i].Checked;
				DataRow myR;
				myR = dt.NewRow();
				myR["Text"] = Text;
				myR["Color"] = myColor;
				myR["enabled"]=enabled;
				dt.Rows.Add(myR);
			}
			try 
			{
				fs.WriteXml(fileName);
			}
			catch {}
		}



		private void button1_Click(object sender, System.EventArgs e)
		{
			
			try 
			{
				Regex r = new Regex(richTextBox1.Text);
				ListViewItem i1 = new ListViewItem(new string[]{""});
				i1.BackColor=Color.Red;
				i1.Checked=true;
				ListViewItem lI = new ListViewItem(new string[]{"",richTextBox1.Text,richTextBox1.SelectionColor.ToArgb().ToString()});
			
				//lI.Checked=true;
				lI.BackColor=Color.Black;
				if(richTextBox1.SelectionColor!=Color.FromArgb(204,204,204))
				{
					lI.ForeColor=richTextBox1.SelectionColor;
				}
				else
				{
					lI.ForeColor=Color.FromArgb(204,204,204);
				}
				lI.Checked=true;			

				listView1.Items.Add(lI);
				richTextBox1.Text="";
				richTextBox1.ForeColor=Color.FromArgb(204,204,204);
				count++;
				listView1.Focus();
				listView1.EnsureVisible(listView1.Items.Count-1);
				listView1.Items[listView1.Items.Count-1].Selected=true;
				richTextBox1.SelectAll();
				richTextBox1.Focus();
				saveFile("customcolors.xml");
			}
			catch
			{
				MessageBox.Show("That is not a valid regular expression.", "RegEx Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//button2.BackColor=Color.FromArgb(Int32.Parse(listView1.SelectedItems[0].SubItems[2].Text));
			try
			{
				Regex r = new Regex(richTextBox1.Text);
				Color tC = new Color();
				//tC = listView1.Items[listView1.SelectedIndices[0]].ForeColor;
				tC = listView1.SelectedItems[0].ForeColor;
				ListViewItem lI = new ListViewItem(new string[]{"",richTextBox1.Text,tC.ToArgb().ToString()});
				//lI.ForeColor=richTextBox1.SelectionColor;
				lI.ForeColor=tC;
				
				//lI.ForeColor=listView1.Items[listView1.SelectedIndices[0]].ForeColor;
				lI.Checked = listView1.Items[listView1.SelectedIndices[0]].Checked;
				lI.Selected=true;
				//lI.UseItemStyleForSubItems=false;
				//lI.BackColor=Color.White;
				listView1.Items[listView1.SelectedIndices[0]]=lI;
				
				listView1.Focus();
				listView1.EnsureVisible(listView1.SelectedIndices[0]);
				listView1.Items[listView1.SelectedIndices[0]].Selected=true;
				//listView1.Items[listView1.SelectedIndices[0]].ForeColor=tC;

				richTextBox1.SelectAll();
				richTextBox1.Focus();

				//listView1.Items[listView1.SelectedIndices[0]].Checked=kryss;
				//listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text=richTextBox1.Text;
				//listView1.Items[listView1.SelectedIndices[0]].ForeColor=richTextBox1.SelectionColor;
			}
			catch {
				MessageBox.Show("That is not a valid regular expression.", "RegEx Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			saveFile("customcolors.xml");
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				int nexti = listView1.SelectedIndices[0];
				if(nexti<0) {nexti = 0;}
				if(nexti>listView1.Items.Count-2) 
				{
					nexti= listView1.Items.Count-2;
					Debug.WriteLine("something");
				}
				Debug.WriteLine("Item to mark: "+nexti.ToString());
				listView1.Items.Remove(listView1.SelectedItems[0]);
				listView1.Items[nexti].Selected=true;
			}
			catch {}
			saveFile("customcolors.xml");
		}

		private void black_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button mBtn = (System.Windows.Forms.Button) sender;
			richTextBox1.SelectAll();
			richTextBox1.SelectionColor= mBtn.BackColor;
			try
			{
				listView1.Items[listView1.SelectedIndices[0]].ForeColor=mBtn.BackColor;
				listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text=richTextBox1.SelectionColor.ToArgb().ToString();
				listView1.Focus();
			}
			catch {}
		}

		public int thisItemNr=0;
		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			try 
			{
				Debug.WriteLine("Index change: "+listView1.SelectedItems[0]);
				selectedItem.BackColor=Color.Black;
				selectedItem = listView1.SelectedItems[0];
				selectedItem.BackColor=selectionColor;
				thisItemNr = listView1.SelectedIndices[0];

				richTextBox1.Text=listView1.SelectedItems[0].SubItems[1].Text;
			
			
				//richTextBox1.SelectAll();
				//richTextBox1.SelectionColor=Color.FromArgb(Int32.Parse(listView1.SelectedItems[0].SubItems[2].Text));

				if(thisItemNr>0)
				{
					buttonUp.Enabled=true;
					buttonAllUp.Enabled=true;
				}
				if(thisItemNr<listView1.Items.Count-1)
				{
					buttonDown.Enabled=true;
					buttonAllDown.Enabled=true;
				}			
			
				if(listView1.SelectedIndices.Count>0)
				{
					button2.Enabled=true;
					button3.Enabled=true;
					button1.Enabled=true;
				}
				//richTextBox1.SelectAll();
				//richTextBox1.Focus();
			}
			catch 
			{
				richTextBox1.Text="";
				buttonUp.Enabled=false;
				buttonDown.Enabled=false;
				buttonAllUp.Enabled=false;
				buttonAllDown.Enabled=false;
				button2.Enabled=false;
				button3.Enabled=false;
				//listView1.Items[1].Focused=true;
				//listView1.Select();
				//listView1.Items[listView1.Items.Count-1].Selected=true;
			}
			//saveFile("customcolors.xml");
		}

		private void customcolorsform_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			saveFile("customcolors.xml");
			frm.defcolorsmenu.Checked=false;
			this.Hide();
			e.Cancel=true;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			saveFile("customcolors.xml");
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			loadFile("customcolors.xml");
		}

		private void customcolorsform_Resize(object sender, System.EventArgs e)
		{
			listView1.Columns[1].Width=this.Width-(listView1.Columns[0].Width+12);
		}

		int thePos = 0;

		// OLD WAY
		private void button4_Click_1(object sender, System.EventArgs e)
		{
			frm.filtering= true;
			if(frm.filtering==true)
			{
				//button4.Text="Stop application of color";
				//button4.Refresh();

				thePos = frm.richTextBox2.SelectionStart;
			
				

				//frm.richTextBox2.
				Cursor.Current = Cursors.WaitCursor;
			
				int count = 0;
				for(int i=0;i<listView1.CheckedItems.Count;i++)
				{
					//frm.textBox1.Text+="\r\n"+frm.richTextBox2.UndoActionName;
					string pattern = listView1.CheckedItems[i].SubItems[1].Text;
					string myColor = listView1.CheckedItems[i].SubItems[2].Text;
					frm.statusBar1.Panels[0].Text="Coloring:";
					frm.statusBar1.Panels[1].Text="\'"+pattern+"\'";
				
					count += frm.setColor(pattern,Color.FromArgb(Int32.Parse(myColor)),caseO);
				}
				frm.statusBar1.Panels[1].Text="";
				frm.statusBar1.Panels[0].Text="";
				Cursor.Current = Cursors.Default;
				frm.filtering=false;
				
				//frm.richTextBox2.HideSelection=false;
			
				// force lineupdate
				if(frm.richTextBox2.Text.Length>0 && count>0)
				{
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
					frm.richTextBox2.SelectionLength=0;
					frm.richTextBox2.SelectedText=" ";
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
					frm.richTextBox2.SelectionLength=1;
					frm.richTextBox2.SelectedText="";
					frm.richTextBox2.SelectionStart= thePos ; 
					frm.richTextBox2.ScrollToCaret();
				}				
				frm.richTextBox2.Focus();
				
			}
			
		}

		private void richTextBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listView1_Click(object sender, System.EventArgs e)
		{
			//saveFile("customcolors.xml");
			
		}

		private void vScrollBar1_Scroll_1(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
		
		}
		
		public int curScrollVal,oldScrollVal=0;
		private void vScrollBar1_ValueChanged(object sender, System.EventArgs e)
		{
			//curScrollVal = vScrollBar1.Value;
			//Debug.WriteLine("OnChange: from "+oldScrollVal+" to "+curScrollVal);	
			
			int dy = 0;
			
			//dy=oldScrollVal-curScrollVal;
			if(oldScrollVal<curScrollVal)
			{
				dy=1;
			}
			else
			{
				dy=-1;
			}
			
	//oldScrollVal = vScrollBar1.Value;

			
		}

		public bool scroll(int dy)
		{
			try
			{
				// kopier selected thingy
//				int thisItemNr = listView1.SelectedIndices[0];
				//listView1.SelectedItems[0].
				int newItemNr = thisItemNr+dy;
				
				Debug.WriteLine("Move: from "+thisItemNr+" to "+newItemNr);	
				Object lI = listView1.Items[thisItemNr].Clone();
				Object lI2 = listView1.Items[newItemNr].Clone();
				//lI.Checked=listView1.Items[thisItemNr].Checked;
				// kopier item over , eller under
				listView1.Items[thisItemNr]=(ListViewItem) lI2;

				// kopier dette item til ny plass
				//lI.Selected=true;
				listView1.Items[newItemNr]=(ListViewItem) lI;
				listView1.Items[newItemNr].Selected=true;
				listView1.Focus();
				listView1.EnsureVisible(newItemNr);
				richTextBox1.SelectAll();
				richTextBox1.Focus();
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
				return false;
			}
			
		}

		private void button5_Click_1(object sender, System.EventArgs e)
		{
			int dy = -1;
			scroll(dy);
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			int dy = 1;
			scroll(dy);
		}

		private void listView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			Debug.WriteLine("Drop at pos:"+listView1.SelectedIndices[0].ToString());
		}

		private void buttonAllUp_Click(object sender, System.EventArgs e)
		{
			int dy = -1;
			while(thisItemNr>0)
			{
				scroll(dy);
			}
		}

		private void buttonAllDown_Click(object sender, System.EventArgs e)
		{
			int dy = 1;
			while(thisItemNr<listView1.Items.Count-1)
			{
				scroll(dy);
			}
		}



		
		
		

		private void customcolorsform_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		Debug.WriteLine("ABORT?");
		}

		private void abort_Click(object sender, System.EventArgs e)
		{
		
		}

		public string getColor(Color tC)
		{
			// search the rtf file for the specific color
			//if exists, return the specific cf
			string temps = frm.richTextBox2.Rtf;
			string searchColor="\\red"+tC.R+"\\green"+tC.G+"\\blue"+tC.B;

			int startPos = temps.IndexOf("{\\colortbl ");
			int endPos = temps.IndexOf("}",startPos);

			string colorstring = temps.Substring(startPos,endPos-startPos-1);
			colorstring = colorstring.Substring(10);
			Debug.WriteLine("ColorTable: "+colorstring);

			string[] colorA = colorstring.Split(';');
			string outColor="";
			//colorstring = "{\\colortbl ";
			StringBuilder newCtbl = new StringBuilder();
			newCtbl.Append("{\\colortbl ");
			int n=0;
			bool found=false;
			foreach(string line in colorA)
			{
				Debug.WriteLine("Comparing '"+line+"' to '"+searchColor+"'");
				newCtbl.Append(line+";");
				if(line==searchColor)
				{
					outColor="\\cf"+n.ToString()+" ";
					found=true;
					Debug.WriteLine("Matching color "+outColor);
					break;
				}
				n++;
			}
			if(found==false)
			{
				newCtbl.Append(searchColor);
				newCtbl.Append(";}");
				newCtbl.Replace("  "," ");
				outColor="\\cf"+n.ToString()+" ";
				Debug.WriteLine("New ColorTable: "+newCtbl.ToString());
			}
			//else, insert the color, return specific cf
			
			return outColor;
		}

		private void button5_Click_2(object sender, System.EventArgs e)
		{
			frm.filtering= true;
			if(frm.filtering==true)
			{
				thePos = frm.richTextBox2.SelectionStart;
				Cursor.Current = Cursors.WaitCursor;
				for(int i=0;i<listView1.CheckedItems.Count;i++)
				{
					//frm.textBox1.Text+="\r\n"+frm.richTextBox2.UndoActionName;
					string pattern = listView1.CheckedItems[i].SubItems[1].Text;
					string myColor = listView1.CheckedItems[i].SubItems[2].Text;
					frm.statusBar1.Panels[0].Text="Coloring:";
					frm.statusBar1.Panels[1].Text="\'"+pattern+"\'";
					string theColor = "";
					//theColor=getColor(Color.FromArgb(Int32.Parse(myColor)));
					//frm.setColor(pattern,Color.FromArgb(Int32.Parse(myColor)));
					
					string ctrl = "\\^$*+";
					char[] ctrlch = ctrl.ToCharArray();

					//if(pattern.IndexOfAny(ctrl.ToCharArray())>-1)
					Debug.WriteLine("Should be pure text, goahead");
					frm.regReplace(pattern,theColor+pattern,RegexOptions.None,Color.FromArgb(Int32.Parse(myColor)));
				}
				frm.statusBar1.Panels[1].Text="";
				frm.statusBar1.Panels[0].Text="";
				Cursor.Current = Cursors.Default;
				frm.filtering=false;
				
				//frm.richTextBox2.HideSelection=false;
			
				// force lineupdate
				frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
				frm.richTextBox2.SelectionLength=0;
				frm.richTextBox2.SelectedText=" ";
				frm.richTextBox2.SelectionStart= thePos ; 
				frm.richTextBox2.ScrollToCaret();
				frm.richTextBox2.Focus();
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			//Debug.WriteLine("Paste to the textbox");
			//richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Text));

		}

		

		private void customcolorsform_Activated(object sender, System.EventArgs e)
		{
		Debug.WriteLine("Color form got activated");
			//saveFile("customcolors.xml");
		}

		private void customcolorsform_Deactivate(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Color form got deactivated");
			saveFile("customcolors.xml");
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Paste to the textbox");
			richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Text));
		}

		private void menuItem1_Click_1(object sender, System.EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void button5_Click_3(object sender, System.EventArgs e)
		{
			frm.filtering= true;
			if(frm.filtering==true)
			{
				//button4.Text="Stop application of color";
				//button4.Refresh();

				thePos = frm.richTextBox2.SelectionStart;
			
				

				//frm.richTextBox2.
				Cursor.Current = Cursors.WaitCursor;
			
				colorPattern[] patterns = new colorPattern[listView1.CheckedItems.Count];

				int count = 0;
				for(int i=0;i<listView1.CheckedItems.Count;i++)
				{
					//frm.textBox1.Text+="\r\n"+frm.richTextBox2.UndoActionName;
					string pattern = listView1.CheckedItems[i].SubItems[1].Text;
					string myColor = listView1.CheckedItems[i].SubItems[2].Text;
					patterns[i] = new colorPattern(pattern,Color.FromArgb(Int32.Parse(myColor)));
					//patterns[i].color=Color.FromArgb(Int32.Parse(myColor));
					//patterns[i].pattern=pattern;
					frm.statusBar1.Panels[0].Text="Coloring:";
					frm.statusBar1.Panels[1].Text="\'"+pattern+"\'";
				
					//count += frm.setColor(patterns,"new",Int32.Parse(textBox1.Text));
				
				}
				count = frm.setColor(patterns,"new",Int32.Parse(textBox1.Text),caseO);
				frm.statusBar1.Panels[1].Text="";
				frm.statusBar1.Panels[0].Text="";
				Cursor.Current = Cursors.Default;
				frm.filtering=false;
				
				//frm.richTextBox2.HideSelection=false;
			
				// force lineupdate
				if(frm.richTextBox2.Text.Length>0 && count>0)
				{
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
					frm.richTextBox2.SelectionLength=0;
					frm.richTextBox2.SelectedText=" ";
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
					frm.richTextBox2.SelectionLength=1;
					frm.richTextBox2.SelectedText="";
					frm.richTextBox2.SelectionStart= thePos ; 
					frm.richTextBox2.ScrollToCaret();
				}				
				frm.richTextBox2.Focus();
				try {Sound.Play("tada.wav");}	catch {}
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void black_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.Button mBtn = (System.Windows.Forms.Button) sender;
			//richTextBox1.SelectAll();
			//richTextBox1.SelectionColor= mBtn.BackColor;
			try
			{
				listView1.Items[listView1.SelectedIndices[0]].ForeColor=mBtn.BackColor;
				//listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text=richTextBox1.SelectionColor.ToArgb().ToString();
				listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text=mBtn.BackColor.ToArgb().ToString();
				//richTextBox1.Focus();
//				listView1.Focus();
			}
			catch {}
		}

		private void black_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//listView1.Focus();
			richTextBox1.Focus();
		}
		ListViewItem selectedItem = new ListViewItem();
		private void listView1_Leave(object sender, System.EventArgs e)
		{
			try
			{
				selectedItem = listView1.SelectedItems[0];
				//listView1.SelectedItems[0].BackColor=Color.Navy;
				selectedItem.BackColor=selectionColor;
			}
			catch(Exception ex)
			{
				Debug.WriteLine("bah");
			}
		}

	

		

		

		private void listView1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			listView1.CausesValidation=false;
			richTextBox1.SelectAll();
			richTextBox1.Focus();
		}

		private void listView1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
			lines = lines/3;
			Debug.WriteLine("Scroll "+lines.ToString());
			try
			{
				listView1.Items[listView1.SelectedIndices[0]-lines].Selected=true;
				listView1.EnsureVisible(listView1.SelectedIndices[0]);
			}
			catch
			{
			}
		}

		private void listView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
//SELECTION
//
//

			int itemHeight = listView1.GetItemRect(0).Height;
			int clientHeight = listView1.Height;
			int dy = (clientHeight-itemHeight*2)/itemHeight;
			int nextPos=0;

			if(e.Control && e.Alt)
			{
				switch(e.KeyCode)
				{
						//MOVING
					case Keys.Home:		//CTRL-ALT-HOME	Move all up
						buttonAllUp.PerformClick();
						e.Handled=true;
						break;
					case Keys.End:			//CTRL-ALT-END	Move all Down
						buttonAllDown.PerformClick();
						e.Handled=true;
						break;
					case Keys.Up:			//CTRL-ALT-UP	Move up
						buttonUp.PerformClick();
						e.Handled=true;
						break;
					case Keys.Down:		//CTRL-ALT-DOWN	Move down
						buttonDown.PerformClick();
						e.Handled=true;
						break;
					case Keys.PageUp:		//CTRL-ALT-pgup	Move pgup
						nextPos = listView1.SelectedIndices[0]-dy;
						if(nextPos<0) {nextPos=0;}
						if(nextPos>listView1.Items.Count-1) {nextPos=listView1.Items.Count-1;}
						while(listView1.SelectedIndices[0]>nextPos)
						{
							scroll(-1);
						}
						e.Handled=true;
						break;
					case Keys.PageDown:	//CTRL-ALT-pgdn	Move pgdn	(need fixed)
						nextPos = listView1.SelectedIndices[0]+dy;
						if(nextPos<0) {nextPos=0;}
						if(nextPos>listView1.Items.Count-1) {nextPos=listView1.Items.Count-1;}
						while(listView1.SelectedIndices[0]<nextPos)
						{
							scroll(1);
						}
						e.Handled=true;
						break;

					default:
						break;
				}
			}
			else if(e.Control)
			{
				//ctrl-home	Selection all up
				//ctrl-end	Selection all down
				switch(e.KeyCode)
				{
					case Keys.Home:
						try
						{
							listView1.Items[0].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch {}
						e.Handled=true;
						break;
					case Keys.End:
						try
						{
							listView1.Items[listView1.Items.Count-1].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch {}
						e.Handled=true;
						break;
					default:
						break;
				}
			}
			else
			{
				
				
				
				

				switch(e.KeyCode)
				{
					case Keys.Up:			//Up		Selection Up
						Debug.WriteLine("UP");
						try
						{
							listView1.Items[listView1.SelectedIndices[0]-1].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch	{}
						e.Handled=true;
						break;
					case Keys.Down:		//Down		Selection Down
						Debug.WriteLine("DOWN");
						try
						{
							listView1.Items[listView1.SelectedIndices[0]+1].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch	{}
						e.Handled=true;
						break;
					case Keys.PageUp:		//PgUp		Selection pgup
						Debug.WriteLine("pgup");
						try
						{

							nextPos = listView1.SelectedIndices[0]-dy;
							if(nextPos<0) {nextPos=0;}
							if(nextPos>listView1.Items.Count-1) {nextPos=listView1.Items.Count-1;}
							listView1.Items[nextPos].Selected=true;
							//listView1.Items[listView1.TopItem.Index-1].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch {}
						e.Handled=true;
						break;
					case Keys.PageDown:			//PgDn		Selection pgdn
						Debug.WriteLine("pgdown");
						try
						{
							nextPos = listView1.SelectedIndices[0]+dy;
							if(nextPos<0) {nextPos=0;}
							if(nextPos>listView1.Items.Count-1) {nextPos=listView1.Items.Count-1;}
							listView1.Items[nextPos].Selected=true;
							listView1.EnsureVisible(listView1.SelectedIndices[0]);
							richTextBox1.SelectAll();
							richTextBox1.Focus();
						}
						catch {}
						e.Handled=true;
						break;
					default:
						break;
				}
			}
			
		}

		private void blue_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			frm.filtering= true;
			if(frm.filtering==true)
			{
				//button4.Text="Stop application of color";
				//button4.Refresh();

				thePos = frm.richTextBox2.SelectionStart;
			
				

				//frm.richTextBox2.
				Cursor.Current = Cursors.WaitCursor;
			
				colorPattern[] patterns = new colorPattern[1];

				int count = 0;
				
				//frm.textBox1.Text+="\r\n"+frm.richTextBox2.UndoActionName;
				string pattern = listView1.SelectedItems[0].SubItems[1].Text;
				string myColor = listView1.SelectedItems[0].SubItems[2].Text;
				patterns[0] = new colorPattern(pattern,Color.FromArgb(Int32.Parse(myColor)));
				//patterns[i].color=Color.FromArgb(Int32.Parse(myColor));
				//patterns[i].pattern=pattern;
				frm.statusBar1.Panels[0].Text="Coloring:";
				frm.statusBar1.Panels[1].Text="\'"+pattern+"\'";
			
				//count += frm.setColor(patterns,"new",Int32.Parse(textBox1.Text));
				
				
				count = frm.setColor(patterns,"new",Int32.Parse(textBox1.Text),caseO);
				frm.statusBar1.Panels[1].Text="";
				frm.statusBar1.Panels[0].Text="";
				Cursor.Current = Cursors.Default;
				frm.filtering=false;
				
				//frm.richTextBox2.HideSelection=false;
			
				// force lineupdate
				if(frm.richTextBox2.Text.Length>0 && count>0)
				{
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
					frm.richTextBox2.SelectionLength=0;
					frm.richTextBox2.SelectedText=" ";
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
					frm.richTextBox2.SelectionLength=1;
					frm.richTextBox2.SelectedText="";
					frm.richTextBox2.SelectionStart= thePos ; 
					frm.richTextBox2.ScrollToCaret();
				}				
				frm.richTextBox2.Focus();
				
			}
			//Sound.Play("c:\\Winnt\\Media\\tada.wav");
			try {Sound.Play("tada.wav");}	catch {}

			//Console.WriteLine("\a"); 
		}

		
		private void casebox_CheckedChanged(object sender, System.EventArgs e)
		{
			if(casebox.Checked)
			{
				caseO = RegexOptions.None;
			}
			else
			{
				caseO = RegexOptions.IgnoreCase;
			}
		}

		private void button4_Click_2(object sender, System.EventArgs e)
		{
			// count the number of colors, if more than 1 then:
			int currentPos = frm.richTextBox2.SelectionStart;

			int startpos=frm.richTextBox2.Rtf.IndexOf("{\\colortbl ")+12;
			int endpos=frm.richTextBox2.Rtf.IndexOf("}",startpos)-1;
			string table = frm.richTextBox2.Rtf.Substring(startpos,endpos-startpos);
			string[] tableA = table.Split(';');
			Debug.WriteLine("table: "+table);
			Debug.WriteLine("tableA count: "+tableA.Length.ToString());
			if(tableA.Length==1||MessageBox.Show(this,"This will remove all current colors from the document.","LogEdit",MessageBoxButtons.OKCancel)==DialogResult.OK)
			{
				
				#region Apply Colors to pure text
				Cursor.Current = Cursors.WaitCursor;
				colorPattern[] patterns = new colorPattern[listView1.CheckedItems.Count];
				int count = 0;
				string pattern;
				string myColor;
				for(int i=0;i<listView1.CheckedItems.Count;i++)
				{
					pattern = listView1.CheckedItems[i].SubItems[1].Text;
					myColor = listView1.CheckedItems[i].SubItems[2].Text;
					patterns[i] = new colorPattern(pattern,Color.FromArgb(Int32.Parse(myColor)));
					frm.statusBar1.Panels[0].Text="Coloring:";
					frm.statusBar1.Panels[1].Text="\'"+pattern+"\'";
					
				}
				pattern=null;
				myColor=null;
				//count = frm.setColor(patterns,"new",Int32.Parse(textBox1.Text),caseO);
				count = frm.setColorRegex(patterns,caseO);
				patterns=null;
				frm.statusBar1.Panels[1].Text="";
				frm.statusBar1.Panels[0].Text="";
				Cursor.Current = Cursors.Default;
				frm.filtering=false;
				
				//frm.richTextBox2.HideSelection=false;
			
				// force lineupdate
				if(frm.richTextBox2.Text.Length>0 && count>0)
				{
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
					frm.richTextBox2.SelectionLength=0;
					frm.richTextBox2.SelectedText=" ";
					frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
					frm.richTextBox2.SelectionLength=1;
					frm.richTextBox2.SelectedText="";
					frm.richTextBox2.SelectionStart= thePos ; 
					frm.richTextBox2.ScrollToCaret();
				}				
				frm.richTextBox2.SelectionStart=currentPos;
				frm.richTextBox2.Focus();
				try {Sound.Play("tada.wav");}	
				catch {}
				#endregion


			}
			else
			{
				Debug.WriteLine("Abort");
			}
			table=null;
			tableA=null;

		}

		

		

		
	}
}
