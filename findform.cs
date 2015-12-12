using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace logedit
{
	/// <summary>
	/// Summary description for findform.
	/// </summary>
	public class findform : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public findform()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(264, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Find Next";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Find what:";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(264, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(16, 48);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Match &case";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(120, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 40);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(64, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 16);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "&Down";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(8, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(40, 16);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "&Up";
			// 
			// findform
			// 
			this.AcceptButton = this.button1;
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(352, 99);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "findform";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Find";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.findform_Closing);
			this.Load += new System.EventHandler(this.findform_Load);
			this.VisibleChanged += new System.EventHandler(this.findform_VisibleChanged);
			this.Activated += new System.EventHandler(this.findform_Activated);
			this.Enter += new System.EventHandler(this.findform_Enter);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		public Form1 frm;
		private void findform_Load(object sender, System.EventArgs e)
		{
			
		}

		private void findform_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Hide();
			e.Cancel=true;
		}
		private bool found=false;
		private int searchpos=0;
		private void button1_Click(object sender, System.EventArgs e)
		{
			
			searchpos = frm.richTextBox2.SelectionStart+frm.richTextBox2.SelectionLength;
			//if(found==true)
			//{
//				searchpos++;
			//}
			//if(searchpos<frm.richTextBox2.Text.Length && searchpos>-1)
			//{
				//searchpos = frm.richTextBox2.Find(textBox1.Text,searchpos,RichTextBoxFinds.None|RichTextBoxFinds.Reverse);
				string needle = textBox1.Text;
				string haystack = frm.richTextBox2.Text;

				if(checkBox1.Checked==false)
				{
					needle=needle.ToLower();
					haystack=haystack.ToLower();
				}

				
				if(radioButton2.Checked==true)
				{
					searchpos = haystack.IndexOf(needle,searchpos);
				}
				else
				{
					searchpos = haystack.LastIndexOf(needle,searchpos-frm.richTextBox2.SelectionLength);
				}


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
			//}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void findform_Enter(object sender, System.EventArgs e)
		{
			//searchpos = frm.richTextBox2.SelectionStart;
			
		}

		private void findform_Activated(object sender, System.EventArgs e)
		{
			//checkBox1.Checked=false;
		}

		private void findform_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible==true)
			{
				checkBox1.Checked=false;
				radioButton2.Checked=true;
				textBox1.SelectAll();
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Length>0)
			{
				button1.Enabled=true;
			}
			else
			{
				button1.Enabled=false;
			}
		}
	}
}
