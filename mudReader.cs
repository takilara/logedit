using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace logedit
{
	/// <summary>
	/// 
	/// </summary>
	public class mudReader
	{
		// private variables
		string priv_ansi;
		string priv_rtf;
		string priv_text;
		string priv_html;
		int priv_progress;
		int priv_tags;
		string priv_filename;
		bool priv_working;
		string priv_initialpath;

		public string initialpath
		{
			get
			{
				return priv_initialpath;
			}
			set
			{
				priv_initialpath=value;
			}
		}

		public bool working
		{
			get
			{
				return priv_working;
			}
			set
			{
				priv_working = value;
			}
		}
		public string filename
		{
			get
			{
				return priv_filename;
			}
			set
			{
				priv_filename = value;
			}
		}

		// private richTextBox to hold the rtf text
		
		//private System.Windows.Forms.RichTextBox rtfBox;

		EventArgs e = new EventArgs();

		public Hashtable ca;

		// = new Hashtable();
		public ArrayList posA;
		public Hashtable tagA;
		public Hashtable replaceA;
		public Hashtable colorA;
		public Hashtable undefT;
		private ArrayList removeNr;
		// = new ArrayList();
		public mudReader ()
		{
			priv_working=false;
			priv_ansi="";
			priv_filename="";
			priv_rtf="";
			priv_text="";
			priv_html="";
			priv_progress = 0;
			priv_initialpath="C:";
			colorA = new Hashtable();
		
			//rtfBox = new RichTextBox();
			colorA["\x1B"+"\x5B"+  "30"+"\x6D"]="\\cf1 ";
			colorA["\x1B"+"\x5B"+"0;30"+"\x6D"]="\\cf1 ";
			colorA["\x1B"+"\x5B"+"1;30"+"\x6D"]="\\cf2 ";
		
			colorA["\x1B"+"\x5B"+  "31"+"\x6D"]="\\cf3 ";
			colorA["\x1B"+"\x5B"+"0;31"+"\x6D"]="\\cf3 ";
			colorA["\x1B"+"\x5B"+"1;31"+"\x6D"]="\\cf4 ";

			colorA["\x1B"+"\x5B"+  "32"+"\x6D"]="\\cf5 ";
			colorA["\x1B"+"\x5B"+"0;32"+"\x6D"]="\\cf5 ";
			colorA["\x1B"+"\x5B"+"1;32"+"\x6D"]="\\cf6 ";
		
			colorA["\x1B"+"\x5B"+  "33"+"\x6D"]="\\cf7 ";
			colorA["\x1B"+"\x5B"+"0;33"+"\x6D"]="\\cf7 ";
			colorA["\x1B"+"\x5B"+"1;33"+"\x6D"]="\\cf8 ";
		
			colorA["\x1B"+"\x5B"+  "34"+"\x6D"]="\\cf9 ";
			colorA["\x1B"+"\x5B"+"0;34"+"\x6D"]="\\cf9 ";
			colorA["\x1B"+"\x5B"+"1;34"+"\x6D"]="\\cf10 ";

			colorA["\x1B"+"\x5B"+  "35"+"\x6D"]="\\cf11 ";
			colorA["\x1B"+"\x5B"+"0;35"+"\x6D"]="\\cf11 ";
			colorA["\x1B"+"\x5B"+"1;35"+"\x6D"]="\\cf12 ";
		
			colorA["\x1B"+"\x5B"+  "36"+"\x6D"]="\\cf13 ";
			colorA["\x1B"+"\x5B"+"0;36"+"\x6D"]="\\cf13 ";
			colorA["\x1B"+"\x5B"+"1;36"+"\x6D"]="\\cf14 ";

			colorA["\x1B"+"\x5B"+  "37"+"\x6D"]="\\cf15 ";
			colorA["\x1B"+"\x5B"+"0;37"+"\x6D"]="\\cf15 ";
			colorA["\x1B"+"\x5B"+"1;37"+"\x6D"]="\\cf16 ";


			// ANSI:  [32mHp: 744(744)  [0mGp: 460(460)  Xp: 11869989  Socp: 1000
			// VT100: Hp: 744(744)  [37mGp: 460(460)  Xp: 11869989  Socp: 1000[0m
			//colorA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf5 ";    // VIRKER VT100
			colorA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf15 ";	// VIRKER ANSI

			replaceA = colorA;

			removeNr = new ArrayList();
			//fix backgrounds
			for(int l=38;l<50;l++)
			{
				removeNr.Add(l);
			}
			//fix blink,reverse
			for(int l=2;l<30;l++)
			{
				removeNr.Add(l);
			}
			removeNr.Add(0);

		
		}
	
		// properties
		// private methods

		public void remove(string inString)
		{
			//rtfBox.Rtf=priv_rtf;
			/*
			string searchString = inString;
			Regex r = new Regex(searchString);
			MatchCollection m = r.Matches(rtfBox.Text);
			for (int i=m.Count-1;i>=0;i--)
			{
				rtfBox.SelectionStart=m[i].Index;
				rtfBox.SelectionLength=m[i].Length;
				rtfBox.SelectedText="";
			}
			priv_rtf=rtfBox.Rtf;
			*/
		}
		public void replace(string inString,string newString)
		{
			/*
			rtfBox.Rtf=priv_rtf;
			string searchString = inString;
			Regex r = new Regex(searchString);
			MatchCollection m = r.Matches(rtfBox.Text);
			for (int i=m.Count-1;i>=0;i--)
			{
				rtfBox.SelectionStart=m[i].Index;
				rtfBox.SelectionLength=m[i].Length;
				rtfBox.SelectedText=newString;
			}
			priv_rtf=rtfBox.Rtf;
			*/
		}



		private void storeTags()
		{
			ca = new Hashtable();
			posA = new ArrayList();
			tagA = new Hashtable();
			undefT = new Hashtable();
			ArrayList tundefT = new ArrayList();
			//			colorA = new Hashtable();
			//posA = null;
			string ts = null;
			string[] ta = null;
			ts = priv_ansi;
			string[] sp = ts.Split('\x1B');
			priv_tags = sp.Length;
			

			
			
			

			
			
			// START REGEX approach
			Regex reg = new Regex("(\x1B\\[)"+ 
				@"(?<tag>(\d|;)+)m");


			//Match m = reg.Match(richTextBox1.Text);
			MatchCollection m = reg.Matches(priv_ansi);
			ts=reg.Replace(priv_ansi,"");
				
				
			for (int i=0;i<m.Count;i++)
			{
				undefT[m[i].ToString()]=true;
				//Form1.textBox1.Text += m[i]+"\r\n";
			}

			ICollection rKeys = replaceA.Keys;
			foreach(string key in rKeys)
			{
				undefT.Remove(key);
			}

			//undefT.Remove(replaceA[]);
				
				

			// END REGEX approach


			// loop the undefT
			ICollection keys = undefT.Keys;
			foreach(string key in keys)
			{
				string newKey = key.Substring(0,2);
				string tk = key.Substring(2,key.Length-3);
				string[] tkA = tk.Split(';');
				ArrayList tkA2 = new ArrayList();
				foreach (string nrs in tkA)
				{
					tkA2.Add((int) Int16.Parse(nrs));
				}
				


				for(int nr=0;nr<tkA2.Count;nr++)
				{
					// check for big numbers etc
					while((int) tkA2[nr]>=50)
					{
						tkA2[nr]=(int) tkA2[nr]-20;
						if((int)tkA2[0]!=1)
						{
							tkA2.Insert(0,(int) 1);
						}
					}
					
				}
				

				// remove stupid 0
				tkA2.Remove(0);

				// remove blink
				tkA2.Remove(5);

				// remove backgrounds
				for(int nr=38;nr<50;nr++)
				{
					tkA2.Remove(nr);
				}

				for(int nr=0;nr<tkA2.Count;nr++)
				{
					newKey += tkA2[nr].ToString()+";";
				}

				newKey=newKey.Substring(0,newKey.Length-1)+"m";

				if(replaceA[newKey]==null)
				{
					replaceA[key]="\\cf15";   // undefinded!!
					
				}
				else
				{
					replaceA[key]=replaceA[newKey];
					tundefT.Add(key);
					
				}
				

			}

			foreach(string key in tundefT)
			{
				undefT.Remove(key);
			}

			ICollection mKey = colorA.Keys;
			foreach(string key in mKey)
			{
				undefT.Remove(key);
			}


			priv_text=ts;
			//return priv_text;
		}
	
		private void ansiToRtf() 
		{
			string ts = "";

			ts =  "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang2057{\\fonttbl{\\f0\\fnil\\fcharset0 Courier New;}}\n";
			ts += "{\\colortbl ;"+
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
			ts	+= "\\viewkind4\\uc1\\pard\\cf15\\f0\\fs18 ";
			



			string tempS = priv_ansi;

			// count number of green vs number of gray tags
			//colorA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf5 ";    // VIRKER VT100
			//colorA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf15 ";	// VIRKER ANSI
			

			Regex tr = new Regex("\\x1B"+"\\x5B"+"32"+"\\x6D");
			MatchCollection m = tr.Matches(tempS);
			int count32 = m.Count;
			Debug.WriteLine("Count 32m: "+m.Count);

			tr = new Regex("\\x1B"+"\\x5B"+"37"+"\\x6D");
			m = tr.Matches(tempS);
			int count37 = m.Count;
			Debug.WriteLine("Count 37m: "+m.Count);
			// check if VT100

			string defcolor = "37";

			if(count37>count32)
			{
				Debug.WriteLine("Assuming VT100 protocol has been used.");
				replaceA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf5 ";    // VIRKER VT100
				colorA["\x1B"+"\x5B"+"0"+"\x6D"]="\\cf5 ";    // VIRKER VT100
				defcolor = "32";


			}
			else
			{
				Debug.WriteLine("Assuming ANSI protocol has been used.");
			}

			// insert GRAY color in beginning of each line to support ansi terminal
			tempS = tempS.Replace("\n","\\par\n"+"\x1B"+"\x5B"+defcolor+"m");
			ICollection keys = replaceA.Keys;

			foreach(string key in keys)
			{
				//tempS = tempS+="Replaced\n";
				tempS = tempS.Replace(key,(string) colorA[key]);
			}

			


			ts += tempS;
			
			
			ts += "}";
			priv_rtf=ts;
			//rtfBox.Rtf=priv_rtf;
			//return ts;
		}
	
		// public methods
		

		public int Progress
		{
			get
			{
				return priv_progress;
			}
		}

		public int getProgress()
		{
			return priv_progress;
		}
		
		public string getText()
		{
			//priv_text=rtfBox.Text;
			return priv_text;
		}
		public void setRtf(string inString)
		{
			priv_rtf=inString;
			//rtfBox.Rtf=priv_rtf;
		}
		public string getRtf()
		{
			return priv_rtf;
		}
		public string getAnsi()
		{
			return priv_ansi;
		}
		public void setAnsi(string inString)
		{
			priv_ansi = "\x1B"+"\x5B"+"0m"+inString;
			//priv_ansi = inString;
			storeTags();
			ansiToRtf();
		}
		
		
	}
}
