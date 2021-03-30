using System;
//using System.Numerics;
using static System.Console;
namespace chapter8WorkingWithCommonNetTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           /*var largest = ulong.MaxValue;
	   WriteLine($"{largest,40:N0}");

	   var atomsInTheUniverse = 
	    BigInteger.Parse("121233124143452351456165654747");
	    WriteLine($"{atomsInTheUniverse,40:N0}");*/

	    string fullName = "Alan Jones";
	    int indexOfTheSpace = fullName.IndexOf(' ');
		
	    string firstName = fullName.Substring(
	    	startIndex:0, length: indexOfTheSpace);
	
	    string lastName = fullName.Substring(
	    	startIndex:indexOfTheSpace+1);
	    
	    WriteLine($"{lastName}, {firstName}");

	}
    }
}
