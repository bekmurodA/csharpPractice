using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
		if (args.Length<3)
		{
			WriteLine("You must specify 2 colors and cursor size, e.g.");
			WriteLine("dotnet run red yellow 50");
			return;
			
		}
		ForegroundColor = (ConsoleColor)Enum.Parse(
			enumType: typeof(ConsoleColor),
			value: args[0],
			ignoreCase: true);
		BackgroundColor = (ConsoleColor)Enum.Parse(
			enumType: typeof(ConsoleColor),
			value: args[1],
			ignoreCase: true);
		CursorSize = int.Parse(args[2]);
		WriteLine($"There are {args.Length} arguments");
	           }
    }
}
