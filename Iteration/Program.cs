using System;
using static System.Console;
namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
		/*int x = 0;
		while (x<3)
		{
			WriteLine(x);
			x++;
		}
		string password = string.Empty;
		do 
		{
			Write("Enter your password:  ");
			password = ReadLine();

		}
		while (password != "pass");
		
		WriteLine("Correct!");*/

		string[] names = {"Adam","Barry","Charlie"};
		foreach(string name in names)
		{
			WriteLine($"{name} has {name.Length} characters");
		}
        }
    }
}
