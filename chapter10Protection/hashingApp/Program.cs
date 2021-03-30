using static System.Console;
using System;
using Packt.Shared;

namespace hashingApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	WriteLine("Registering Alice with Pa$$w0rd.");
		var alice = Protector.Register("Alice","Pa$$w0rd");

		WriteLine($"Name: {alice.Name}");
		WriteLine($"Salt: {alice.Salt}");
		WriteLine("Password (salted and hashed): {0}",alice.SaltedHashedPassword);
		WriteLine();

	}

    }
}
