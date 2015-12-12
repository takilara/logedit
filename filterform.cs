using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;




namespace logedit
{
	
	/// <summary>
	/// Summary description for filterform.
	/// </summary>
	public class filterform : System.Windows.Forms.Form
	{
		//private Form1 doh;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox fromBox;
		private System.Windows.Forms.TextBox toBox;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button countBtn;
		private System.Windows.Forms.Button filterBtn;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		public Form1 frm;
		private DataSet fs;
		private DataTable dt;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonAllUp;
		private System.Windows.Forms.Button buttonAllDown;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.ComponentModel.IContainer components;
		private RegexOptions caseO;
		public filterform()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(filterform));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.fromBox = new System.Windows.Forms.TextBox();
			this.toBox = new System.Windows.Forms.TextBox();
			this.updateBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.countBtn = new System.Windows.Forms.Button();
			this.filterBtn = new System.Windows.Forms.Button();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.buttonAllUp = new System.Windows.Forms.Button();
			this.buttonAllDown = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																												this.columnHeader1,
																												this.columnHeader2,
																												this.columnHeader3});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(296, 192);
			this.listView1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.listView1, "Current filters.");
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.listView1_Click);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "From";
			this.columnHeader1.Width = 135;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "To";
			this.columnHeader2.Width = 113;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Count";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader3.Width = 39;
			// 
			// fromBox
			// 
			this.fromBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fromBox.Location = new System.Drawing.Point(48, 8);
			this.fromBox.Multiline = true;
			this.fromBox.Name = "fromBox";
			this.fromBox.Size = new System.Drawing.Size(192, 24);
			this.fromBox.TabIndex = 1;
			this.fromBox.Text = "";
			this.toolTip1.SetToolTip(this.fromBox, "Enter the \"From\" pattern here.");
			this.fromBox.TextChanged += new System.EventHandler(this.fromBox_TextChanged);
			// 
			// toBox
			// 
			this.toBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.toBox.Location = new System.Drawing.Point(48, 32);
			this.toBox.Multiline = true;
			this.toBox.Name = "toBox";
			this.toBox.Size = new System.Drawing.Size(192, 24);
			this.toBox.TabIndex = 2;
			this.toBox.Text = "";
			this.toolTip1.SetToolTip(this.toBox, "Enter the \"To\" pattern here.");
			this.toBox.TextChanged += new System.EventHandler(this.toBox_TextChanged);
			// 
			// updateBtn
			// 
			this.updateBtn.Enabled = false;
			this.updateBtn.Location = new System.Drawing.Point(88, 56);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(72, 23);
			this.updateBtn.TabIndex = 3;
			this.updateBtn.Text = "Update";
			this.toolTip1.SetToolTip(this.updateBtn, "Update the current filter.");
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Enabled = false;
			this.deleteBtn.Location = new System.Drawing.Point(168, 56);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(64, 23);
			this.deleteBtn.TabIndex = 4;
			this.deleteBtn.Text = "Delete";
			this.toolTip1.SetToolTip(this.deleteBtn, "Delete the current filter.");
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// addBtn
			// 
			this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addBtn.Enabled = false;
			this.addBtn.Location = new System.Drawing.Point(240, 8);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(48, 48);
			this.addBtn.TabIndex = 5;
			this.addBtn.Text = "Add New";
			this.toolTip1.SetToolTip(this.addBtn, "Click to add the new filter.");
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// countBtn
			// 
			this.countBtn.Location = new System.Drawing.Point(8, 56);
			this.countBtn.Name = "countBtn";
			this.countBtn.Size = new System.Drawing.Size(72, 23);
			this.countBtn.TabIndex = 6;
			this.countBtn.Text = "Count";
			this.toolTip1.SetToolTip(this.countBtn, "Count the number of matches.");
			this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
			// 
			// filterBtn
			// 
			this.filterBtn.Location = new System.Drawing.Point(168, 80);
			this.filterBtn.Name = "filterBtn";
			this.filterBtn.Size = new System.Drawing.Size(64, 23);
			this.filterBtn.TabIndex = 7;
			this.filterBtn.Text = "Apply All";
			this.toolTip1.SetToolTip(this.filterBtn, "Apply the filters to the document.");
			this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "LogEdit.chm";
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.Enabled = false;
			this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
			this.buttonUp.Location = new System.Drawing.Point(240, 56);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(24, 23);
			this.buttonUp.TabIndex = 8;
			this.toolTip1.SetToolTip(this.buttonUp, "Click to move the current filter up.");
			this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.Enabled = false;
			this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
			this.buttonDown.Location = new System.Drawing.Point(240, 80);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(24, 23);
			this.buttonDown.TabIndex = 9;
			this.toolTip1.SetToolTip(this.buttonDown, "Click to move the current filter down.");
			this.buttonDown.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "From:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "To:";
			// 
			// buttonAllUp
			// 
			this.buttonAllUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAllUp.Enabled = false;
			this.buttonAllUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllUp.Image")));
			this.buttonAllUp.Location = new System.Drawing.Point(264, 56);
			this.buttonAllUp.Name = "buttonAllUp";
			this.buttonAllUp.Size = new System.Drawing.Size(24, 23);
			this.buttonAllUp.TabIndex = 12;
			this.toolTip1.SetToolTip(this.buttonAllUp, "Click to move the current filter to the top.");
			this.buttonAllUp.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// buttonAllDown
			// 
			this.buttonAllDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAllDown.Enabled = false;
			this.buttonAllDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonAllDown.Image")));
			this.buttonAllDown.Location = new System.Drawing.Point(264, 80);
			this.buttonAllDown.Name = "buttonAllDown";
			this.buttonAllDown.Size = new System.Drawing.Size(24, 23);
			this.buttonAllDown.TabIndex = 13;
			this.toolTip1.SetToolTip(this.buttonAllDown, "Click to move the current filter to the bottom.");
			this.buttonAllDown.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(88, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Apply This";
			this.toolTip1.SetToolTip(this.button1, "Apply the filters to the document.");
			this.button1.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.addBtn);
			this.panel1.Controls.Add(this.buttonAllUp);
			this.panel1.Controls.Add(this.buttonAllDown);
			this.panel1.Controls.Add(this.fromBox);
			this.panel1.Controls.Add(this.countBtn);
			this.panel1.Controls.Add(this.filterBtn);
			this.panel1.Controls.Add(this.updateBtn);
			this.panel1.Controls.Add(this.toBox);
			this.panel1.Controls.Add(this.deleteBtn);
			this.panel1.Controls.Add(this.buttonUp);
			this.panel1.Controls.Add(this.buttonDown);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 197);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(296, 104);
			this.panel1.TabIndex = 15;
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 80);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(88, 24);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "Match Case";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// filterform
			// 
			this.AcceptButton = this.addBtn;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 301);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel1);
			this.helpProvider1.SetHelpKeyword(this, "Overview_Filters.htm");
			this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
			this.helpProvider1.SetHelpString(this, "");
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "filterform";
			this.helpProvider1.SetShowHelp(this, true);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Filters";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.filterform_Closing);
			this.Load += new System.EventHandler(this.filterform_Load);
			this.Activated += new System.EventHandler(this.filterform_Activated);
			this.Deactivate += new System.EventHandler(this.filterform_Deactivate);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void filterform_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide();
			saveFile("filter.xml");
			frm.filtermenu.Checked=false;
		e.Cancel=true;
		}

		private void filterform_Load(object sender, System.EventArgs e)
		{
			caseO = RegexOptions.None;
			helpProvider1.HelpNamespace="LogEdit.chm";
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
			myC.ColumnName = "From";
			myC.AutoIncrement = false;
			myC.Caption = "ParentItem";
			myC.ReadOnly = false;
			myC.Unique = false;
			// Add the column to the table.
			dt.Columns.Add(myC);
 
			myC = new DataColumn();
			myC.DataType = System.Type.GetType("System.String");
			myC.ColumnName = "To";
			myC.AutoIncrement = false;
			myC.Caption = "ParentItem";
			myC.ReadOnly = false;
			myC.Unique = false;
			// Add the column to the table.
			dt.Columns.Add(myC);


			myC = new DataColumn();
			myC.DataType = System.Type.GetType("System.Int32");
			myC.ColumnName = "count";
			myC.ReadOnly = false;
			
			myC.Unique = false;
			myC.AutoIncrement = false;
			myC.DefaultValue=0;
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

			
			loadFile("filter.xml");
			

			// fill fs from file..

			
			
		}
		private bool itemselected;
		public int thisItemNr = 0;
		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
				try
				{
					thisItemNr = listView1.SelectedIndices[0];
					fromBox.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text;
					toBox.Text=listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text;
					// make parentform goto right place.
					frm.findFilter(listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text);
					
					deleteBtn.Enabled=true;
					button1.Enabled=true;
					//updateBtn.Enabled=true;
					itemselected = true;

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
					Debug.WriteLine("ThisItemNr="+thisItemNr.ToString());


				}
				catch 
				{
					deleteBtn.Enabled=false;
					updateBtn.Enabled=false;
					itemselected=false;
					buttonUp.Enabled=false;
					buttonDown.Enabled=false;
					buttonAllUp.Enabled=false;
					buttonAllDown.Enabled=false;
				}
			//frm.Focus();
					saveFile("filter.xml");
		}

		private void addBtn_Click(object sender, System.EventArgs e)
		{
			try
			{
				Regex r = new Regex(fromBox.Text);

				//MatchCollection m = r.Matches(richTextBox2.Text);
				//return m.Count;


				listView1.Items.Add(new ListViewItem(new string[]{fromBox.Text,toBox.Text,"0"}));
				saveFile("filter.xml");
			}
			catch
			{
				
				MessageBox.Show("The filter is not a valid regular expression.", "RegEx Error",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
		}

		private void updateBtn_Click(object sender, System.EventArgs e)
		{
			listView1.Items[listView1.SelectedIndices[0]].SubItems[0].Text=fromBox.Text;
			listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text=toBox.Text;
			saveFile("filter.xml");
		}

		private void deleteBtn_Click(object sender, System.EventArgs e)
		{
			try
			{
				listView1.Items.Remove(listView1.SelectedItems[0]);
			}
			catch {}
			saveFile("filter.xml");
		}

		public void countAll()
		{
			int startTime = Environment.TickCount;
			for(int i=0;i<listView1.Items.Count;i++)
			{
				string from = listView1.Items[i].SubItems[0].Text;
				int count = frm.countX(from,caseO);
				listView1.Items[i].SubItems[2].Text=count.ToString();
			}
			int endTime = Environment.TickCount;
			Debug.WriteLine("countAll took: "+(endTime-startTime).ToString()+"ms");
		}

		private void countBtn_Click(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			countAll();			
			Cursor.Current = Cursors.Default;
		}

		private void filterBtn_Click(object sender, System.EventArgs e)
		{
			//frm.richTextBox2.HideSelection=true;
			frm.filtering=true;
			//frm.richTextBox2.
			Cursor.Current = Cursors.WaitCursor;
			int count = 0;
			string from;
			string to;
			for(int i=0;i<listView1.CheckedItems.Count;i++)
			{
				//frm.textBox1.Text+="\r\n"+frm.richTextBox2.UndoActionName;
				from = listView1.CheckedItems[i].SubItems[0].Text;
				to = listView1.CheckedItems[i].SubItems[1].Text;
				frm.statusBar1.Panels[0].Text="Filtering:";
				frm.statusBar1.Panels[1].Text="\'"+from+"\'";
				//frm.replace(from,to);
				count += frm.replace(from,to,caseO);
			}
			from = null;
			to = null;
			frm.statusBar1.Panels[0].Text="Counting...";
			frm.statusBar1.Panels[1].Text="";
			countAll();
			frm.statusBar1.Panels[0].Text="";
			Cursor.Current = Cursors.Default;
			frm.filtering=false;
			//frm.richTextBox2.HideSelection=false;
			if(frm.richTextBox2.Text.Length>0 && count>0)
			{
				frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
				frm.richTextBox2.SelectionLength=0;
				frm.richTextBox2.SelectedText=" ";
				frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
				frm.richTextBox2.SelectionLength=1;
				frm.richTextBox2.SelectedText="";
			}
			//frm.richTextBox2.Rtf+=" ";
			frm.richTextBox2.Focus();
			try {Sound.Play("tada.wav");}	catch {}

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
				
				ListViewItem lI = new ListViewItem(new string[]{dt.Rows[i]["From"].ToString(),dt.Rows[i]["To"].ToString(),"0"});
				lI.Checked= (bool) dt.Rows[i]["enabled"];
				listView1.Items.Add(lI);
			}

		}


		private void loadBtn_Click(object sender, System.EventArgs e)
		{
			loadFile("filter.xml");

		}

		private void saveFile(string fileName)
		{
			dt.Clear();
			for(int i=0;i<listView1.Items.Count;i++)
			{
				string from = listView1.Items[i].SubItems[0].Text;
				string to = listView1.Items[i].SubItems[1].Text;
				bool enabled = (bool) listView1.Items[i].Checked;
				DataRow myR;
				myR = dt.NewRow();
				myR["From"] = from;
				myR["To"] = to;
				myR["enabled"]=enabled;
				dt.Rows.Add(myR);
			}
			try 
			{
				fs.WriteXml(fileName);
			}
			catch {}
		}

		private void saveBtn_Click(object sender, System.EventArgs e)
		{
	
		}

		private void fromBox_TextChanged(object sender, System.EventArgs e)
		{
			if(itemselected ==true)
			{
				updateBtn.Enabled=true;
			}
			if(fromBox.Text!="")
			{
				addBtn.Enabled=true;
			}
			else
			{
					addBtn.Enabled=false;
			}
		}

		private void toBox_TextChanged(object sender, System.EventArgs e)
		{
			if(itemselected ==true)
			{
				updateBtn.Enabled=true;
			}
			if(fromBox.Text!="")
			{
				addBtn.Enabled=true;
			}
			else
			{
					addBtn.Enabled=false;
			}
		}

		private void listView1_Click(object sender, System.EventArgs e)
		{
			saveFile("filter.xml");
		}

		private void listView1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
//					saveFile("filter.xml");
		}


		private void buttonUp_Click(object sender, System.EventArgs e)
		{
			int dy = -1;
			scroll(dy);
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
			int dy = 1;
			scroll(dy);
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
				
				return true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
				return false;
			}
			
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			//int dy = thisItemNr*(-1);
			int dy = -1;
			// calculate this based on current position and top
			while(thisItemNr>0)
			{
				scroll(dy);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//int dy = listView1.Items.Count-thisItemNr-1;
			// calculate this based on current position and top
			int dy = 1;
			while(thisItemNr<listView1.Items.Count-1)
			{
				scroll(dy);
			}
		}

		private void filterform_Activated(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Filterform got activated");
			//saveFile("filter.xml");
		}

		private void filterform_Deactivate(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Filterform got deactivated");
			saveFile("filter.xml");
		}

		private void button1_Click_2(object sender, System.EventArgs e)
		{
			//frm.richTextBox2.HideSelection=true;
			frm.filtering=true;
			//frm.richTextBox2.
			Cursor.Current = Cursors.WaitCursor;
			int count = 0;
			
				string from = listView1.SelectedItems[0].SubItems[0].Text;
				string to = listView1.SelectedItems[0].SubItems[1].Text;
				frm.statusBar1.Panels[0].Text="Filtering:";
				frm.statusBar1.Panels[1].Text="\'"+from+"\'";
				//frm.replace(from,to);
				count += frm.replace(from,to,caseO);
			
			frm.statusBar1.Panels[0].Text="Counting...";
			frm.statusBar1.Panels[1].Text="";
			countAll();
			frm.statusBar1.Panels[0].Text="";
			Cursor.Current = Cursors.Default;
			frm.filtering=false;
			//frm.richTextBox2.HideSelection=false;
			if(frm.richTextBox2.Text.Length>0 && count>0)
			{
				frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length;
				frm.richTextBox2.SelectionLength=0;
				frm.richTextBox2.SelectedText=" ";
				frm.richTextBox2.SelectionStart=frm.richTextBox2.Text.Length-1;
				frm.richTextBox2.SelectionLength=1;
				frm.richTextBox2.SelectedText="";
			}
			//frm.richTextBox2.Rtf+=" ";
			frm.richTextBox2.Focus();
			try {Sound.Play("tada.wav");}	catch {}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
			{
				caseO=RegexOptions.None;
			}
			else
			{
				caseO=RegexOptions.IgnoreCase;
			}
		}

		
		
	}
}
