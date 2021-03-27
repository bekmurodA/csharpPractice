using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
		Console.Write("Type your first name and press enter: ");
		string firstName = Console.ReadLine();
		Console.Write("Type your age and press enter: ");
		string age = Console.ReadLine();

		Console.WriteLine(
			$"Hello {firstName}, you look good for {age}."
				);

        }
    }
}
