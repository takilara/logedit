using System;
using System.Drawing;

namespace logedit
{
	/// <summary>
	/// 
	/// </summary>
	public class colorPattern
	{
		public colorPattern()
		{

		}
		public colorPattern(string pattern,Color color)
		{
			thePattern = pattern;
			theColor = color;
		}
		private Color theColor;
		private string thePattern;
		public Color color
		{
			get
			{
				return theColor;
			}
			set
			{
				theColor=value;
			}
		}
		public string pattern
		{
			get
			{
				return thePattern;
			}
			set
			{
				thePattern=value;
			}
		}
	}
}
