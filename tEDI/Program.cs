using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace tEDI
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
                Application.Run(new MainForm());
            else if (args.Length == 1)
                Application.Run(new MainForm(args[0]));
            else
                for (int i = 0; i < args.Length; i++)
                    Process.Start(Application.StartupPath + Path.DirectorySeparatorChar + Path.GetFileName(Application.ExecutablePath), "\"" + args[i] + "\"");
		}
		
	}
}
