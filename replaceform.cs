using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace logedit
{
	/// <summary>
	/// Summary description for replaceform.
	/// </summary>
	public class replaceform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public replaceform()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Find what:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Replace with:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(272, 16);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "Find Next";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(272, 40);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "Replace";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(272, 64);
			this.button3.Name = "button3";
			this.button3.TabIndex = 6;
			this.button3.Text = "Replace All";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button4.Location = new System.Drawing.Point(272, 88);
			this.button4.Name = "button4";
			this.button4.TabIndex = 7;
			this.button4.Text = "Cancel";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 72);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Mach &case";
			// 
			// replaceform
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button4;
			this.ClientSize = new System.Drawing.Size(354, 119);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "replaceform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Replace";
			this.TopMost = true;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.replaceform_Closing);
			this.VisibleChanged += new System.EventHandler(this.replaceform_VisibleChanged);
			this.ResumeLayout(false);

		}
		#endregion
		public Form1 frm;
		private void replaceform_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide();
			e.Cancel=true;
		}
private bool found=false;
		private int searchpos=0;
		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void find()
		{
						
			searchpos = frm.richTextBox2.SelectionStart+frm.richTextBox2.SelectionLength;
			string needle = textBox1.Text;
			string haystack = frm.richTextBox2.Text;

			if(checkBox1.Checked==false)
			{
				needle=needle.ToLower();
				haystack=haystack.ToLower();
			}

				
			searchpos = haystack.IndexOf(needle,searchpos);
			


			if(searchpos>-1)
			{
				frm.richTextBox2.SelectionStart=searchpos;
				frm.richTextBox2.SelectionLength=textBox1.Text.Length;
				found = true;
			}
			else
			{
				MessageBox.Show("Cannot find \'"+textBox1.Text+"\'", "LogEdit",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				found=false;
			}

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			find();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string needle = textBox1.Text;
			string haystack = frm.richTextBox2.Text;

			if(checkBox1.Checked==false)
			{
				needle=needle.ToLower();
				if(found==true && frm.richTextBox2.SelectionLength>0 && frm.richTextBox2.SelectedText.ToLower()==needle)
				{

					frm.richTextBox2.SelectedText=textBox2.Text;
				}	
			}
			else
			{
				if(found==true && frm.richTextBox2.SelectionLength>0 && frm.richTextBox2.SelectedText==needle)
				{

					frm.richTextBox2.SelectedText=textBox2.Text;
				}	
			}
			find();
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			RegexOptions opt;
			if(checkBox1.Checked==false)
			{
				opt = RegexOptions.IgnoreCase;
			}
			else
			{
				opt = RegexOptions.None;
			}
			
			//if(frm.regReplace(textBox1.Text,textBox2.Text,opt,Color.Empty)==false)
			if(false==false)
			{
				Debug.WriteLine("Regex replace didnt work, running old replace");
			
				Cursor.Current=Cursors.WaitCursor;
				string needle = textBox1.Text;
				string haystack = frm.richTextBox2.Text;
				RichTextBox tempBox = new RichTextBox();
				tempBox.Visible=false;
				tempBox.Rtf = frm.richTextBox2.Rtf;
				
				if(checkBox1.Checked==false)
				{
					needle	=	needle.ToLower();
					haystack	=	haystack.ToLower();
					tempBox.SelectionStart=0;
					int thepos = 0;
					int oldthepos = -1;
					thepos = tempBox.Text.ToLower().IndexOf(needle,thepos);
					while(thepos>-1 && thepos!=oldthepos)
					{
						tempBox.SelectionStart=thepos;
						tempBox.SelectionLength=needle.Length;
						tempBox.SelectedText=textBox2.Text;

						oldthepos = thepos;
						thepos = tempBox.Text.ToLower().IndexOf(needle,thepos+needle.Length);
					}
				}
				else
				{
					tempBox.SelectionStart=0;
					int thepos = 0;
					int oldthepos = -1;
					thepos = tempBox.Text.IndexOf(needle,thepos);
					while(thepos>-1 && thepos!=oldthepos)
					{
						tempBox.SelectionStart=thepos;
						tempBox.SelectionLength=needle.Length;
						tempBox.SelectedText=textBox2.Text;
						
						oldthepos=thepos;
						thepos = tempBox.Text.IndexOf(needle,thepos+needle.Length);
					}
				}
				tempBox.SelectAll();
				tempBox.Copy();
				frm.richTextBox2.SelectAll();
				frm.richTextBox2.Paste();
				tempBox.Visible=true;
				tempBox.Dispose();
				Cursor.Current=Cursors.Default;
			}
		}

		private void replaceform_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible==true)
			{
				checkBox1.Checked=false;
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Length>0)
			{
				button1.Enabled=true;
				button2.Enabled=true;
				button3.Enabled=true;
			}
			else
			{
				button1.Enabled=false;
				button2.Enabled=false;
				button3.Enabled=false;
			}
		}
	}
}
