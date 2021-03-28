using static System.Console;
using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	Person bob = new Person();
		bob.name = "Bob Smith";
		bob.DateOfBirth = new DateTime(1965, 12, 22);
		WriteLine(
		format:"{0} was born on {1:dddd,d MMMM yyyy}",
		arg0: bob.name,
		arg1: bob.DateOfBirth);

		
		var alice = new Person()
		{
			name = "Alice Jones",
			DateOfBirth = new DateTime(1998, 3, 7)
		};

		WriteLine(
		format: "{0} was born on {1:dddd MMMM yy}",
		arg0: alice.name,
		arg1: alice.DateOfBirth
		);

	}

    }
}
