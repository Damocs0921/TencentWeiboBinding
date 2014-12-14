using System;
using System.IO;


namespace TCWBTest
{
	public class ErrorLog
	{

	
		static string doc = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
		static string filename = Path.Combine (doc, "Errorlog.txt");


		public static void WriteErrorLog(string str)
		{
			string inputstr = DateTime.Now.ToString() + " " + str + "\n";
			File.AppendAllText (filename, inputstr);
		}


		public static void ResetErrorLog()
		{
			File.WriteAllText (filename, "");
		}
			
	}
}

