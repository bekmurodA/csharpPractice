using System;
using System.IO;
using static System.Console;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = @"./";
	   Write("Press R for readonly or W for write: ");
	   ConsoleKeyInfo key = ReadKey();
	   WriteLine();

	   Stream s = null;
	   if (key.Key == ConsoleKey.R)
	   {
		s = File.Open(
			Path.Combine(path,"file.txt"),
			FileMode.OpenOrCreate,
			FileAccess.Read);
	   }
	   else 
	   {
		s = File.Open(
			Path.Combine(path,"file.txt"),
			FileMode.OpenOrCreate,
			FileAccess.Write);
	   }
	   string message = string.Empty;
	   switch(s)
	   {
		case FileStream writetableFile when s.CanWrite:
			message = "The stream is a file that I can write to";
			break;
		case FileStream readOnlyFile:
			message = "The stream is read-only file";
			break;
		case MemoryStream ms:
			message = "The stream is a memory address";
			break;
		default: //always evaluated last
			message = "The stream is some other type.";
			break;
		case null:
			message = "The stream is null";
			break;
	   }
	   WriteLine(message);
        }
    }
}
