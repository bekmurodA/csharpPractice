using static System.Console;
using System.Text.RegularExpressions;
using System;

namespace regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
          Write("enter your age: ");
	  string input = ReadLine();

	 // var ageChecker = new Regex(@"\d"); //contains one digit
	  var ageChecker = new Regex(@"^\d+$");

	  if (ageChecker.IsMatch(input))
	  {
		WriteLine("Thank you!");
	  }
	  else
	  {
		WriteLine($"This is not a valid age: {input}");
	  }
	}

    }
}
