using System;
using static System.Console;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number between 0 and 255: ");
	    string number = ReadLine();
            Write("Enter an another number between 0 and 255: ");
	    string number2 = ReadLine();
	    try
	    {
		 int numberI = int.Parse(number);
	int	number2I = int.Parse(number2);

		WriteLine($"{numberI} divided by {number2I} is {numberI/number2I}");	
	    }

	    catch(DivideByZeroException)
	    {
		    WriteLine("you cannot divide by 0");
	    }
	    catch(Exception ex)
	    {
		    WriteLine($"{ex.GetType()} says {ex.Message}");
	    }
        }
    }
}
