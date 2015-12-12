using System;

namespace logedit
{
	/// <summary>
	/// 
	/// </summary>
	public class Sound
	{
		public static void Play( string strFileName )
		{
			Helpers.PlaySound( strFileName, IntPtr.Zero, Helpers.PlaySoundFlags.SND_FILENAME | Helpers.PlaySoundFlags.SND_ASYNC );
			//Helpers.Beep(5000,100);
		}
	}
}
