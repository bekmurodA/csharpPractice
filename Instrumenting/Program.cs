using System.Diagnostics;
using System.IO;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
		//Write text file in the project folder
		Trace.Listeners.Add(new TextWriterTraceListener(
					File.CreateText("log.txt"))); 

		//Text writer is buffered, so this option calls
		//Flush() on all listener after writing
		Trace.AutoFlush = true;

		Debug.WriteLine("Debug says I'm listening");

		Trace.WriteLine("Trace says I'm listening");
	}
    }
}
