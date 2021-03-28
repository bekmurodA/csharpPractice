using static System.Console;
using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        	/*Person bob = new Person();
		bob.name = "Bob Smith";
		bob.DateOfBirth = new DateTime(1965, 12, 22);
		bob.BucketList= WondersOfTheAncientWorld.Zeus|WondersOfTheAncientWorld.Mausoleum;
		WriteLine(
		format:"{0} was born on {1:dddd,d MMMM yyyy} and he is {2}",
		arg0: bob.name,
		arg1: bob.DateOfBirth,
		arg2: Person.Species);
		WriteLine($"{bob.name} lives on {bob.HomePlanet}");
		WriteLine(
		format: "{0}'s  bucket list is {1}",
		arg0:bob.name,
		arg1:bob.BucketList);
		bob.Children.Add(new Person{name= "Alfred"});
		bob.Children.Add(new Person {name = "Zoe"});

		WriteLine(
		   $"{bob.name} has {bob.Children.Count} children:");
		for (int child = 0; child <bob.Children.Count; child++)
		{
			WriteLine($"  {bob.Children[child].name}");
		}
		
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

		BankAccount.InterestRate = 0.012M; //shared value

		var jonesAccount = new BankAccount();
		jonesAccount.AccountName = "Mrs. Jones";
		jonesAccount.Balance = 2400;

		WriteLine(format:"{0} earned {1:C} interest",
			arg0:jonesAccount.AccountName,
			arg1:jonesAccount.Balance * BankAccount.InterestRate);
		
		var blankPerson = new Person();
		WriteLine(format:
		"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
		arg0:blankPerson.name,
		arg1:blankPerson.HomePlanet,
		arg2:blankPerson.Instantiated);
		
		var gunny = new Person("Gunny", "Mars");
		WriteLine(
		 format:"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
		 arg0:gunny.name,
		 arg1:gunny.HomePlanet,
		 arg2:gunny.Instantiated);
		WriteLine($"Printing Methods for {bob.name}");
		bob.WriteToConsole();
		WriteLine(bob.GetOrigin());
		
		var  fruit = bob.GetFruit();
		WriteLine($"{fruit.Name}, {fruit.Number}");
	
		WriteLine(bob.SayHelloTo("Emily"));

		int a = 10;
		int b = 20;
		int c = 30;
		WriteLine($"before a= {a}, b = {b}, c = {c}");
		bob.PassingParameters(a,ref b, out c);
		WriteLine($"after a = {a}, b = {b} c = {c}");
		
		var sam = new Person
		{
			name = "Sam",
			DateOfBirth = new DateTime(1972, 1, 27)
		};
		/* WriteLine(sam.Origin);
		WriteLine(sam.Greeting);
		WriteLine(sam.Age);*/

		/*sam.FavoriteIceCream = "Chocolate Fudge";
		WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");
		sam.FavoritePrimaryColor = "Red";
		WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
		*/

		/*sam.Children.Add(new Person {name="Charlie"});
		sam.Children.Add(new Person {name="Ella"});

		WriteLine($"Sam's first child is {sam.Children[0].name}");
		WriteLine($"Sam's second child is {sam.Children[1].name}");
		
		WriteLine($"Sam's second child is {sam[1].name}");
		WriteLine($"Sam's second child is {sam[1].name}");
		*/

		/*object[] passengers = {
		    new FirstClassPassenger{AirMiles = 1_419},
		    new FirstClassPassenger{AirMiles = 16_562},
		    new BusinessClassPassenger(),
		    new CoachClassPassenger{CarryOnKG = 25.7},
		    new CoachClassPassenger{CarryOnKG = 0},
		};

		foreach(object passenger in passengers)
		{
			decimal flightCost = passenger switch
			{
				/* C8 syntax
				FirstClassPassenger p when p.AirMiles > 35000 => 1500M,

				FirstClassPassenger p when p.AirMiles > 15000 => 1750M,

				FirstClassPassenger   => 1500M,
				BusinessClassPassenger   => 2000M,*/

				//c# 9 syntax
				/*FirstClassPassenger p => p.AirMiles switch
				{
					>3500 => 1500M,
					>1500 => 1750M,
					_ => 2000M
				},
				BusinessClassPassenger => 1000M,
				CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
				CoachClassPassenger  => 650M,
				_ =>800M
			};
		WriteLine($"Flight costs {flightCost} for {passenger}");
		}*/

	/*	ImmutableVehicle car = new ImmutableVehicle
		{
			Brand = "Mazda MX-5 RF",
			Color = "Metallic",
			Wheels = 4
		};
		//creating new records from existing ones with any changed state 'non-destructive mutation' with keyword
		var repaintedCar = car with {Color = "Polymetal Grey Metallic"};
		WriteLine("Original color was {0}, new color is {1}.",
		arg0:car.Color,
		arg1:repaintedCar.Color);*/

		var oscar = new ImmutableAnimal("Oscar","Labrador");
		var (who,what) = oscar; //calls Deconstruct Method
		WriteLine($"{who} is {what}");
	}



    }
}
