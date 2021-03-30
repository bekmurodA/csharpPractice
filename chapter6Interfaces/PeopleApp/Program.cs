using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
		//creating three people
		var harry = new Person{Name="Harry"};
		var mary = new Person{Name="Mary"};
		var jill = new Person{Name="Jill"};

		/*/calling instance method
		var baby1 = mary.ProcreateWith(harry);
		baby1.Name = "Gary";

		//calling static method
		var baby2 = Person.Procreate(harry,jill);

		//call an operator method
		var baby3 = harry * jill;

		WriteLine($"{harry.Name} has {harry.Children.Count} children");
		WriteLine($"{mary.Name} has {mary.Children.Count} children");
		WriteLine($"{jill.Name} has {jill.Children.Count} children");
        	*/

        	/*
		static void Harry_Shout(object sender, EventArgs e)
		{
			Person p = (Person)sender;
			WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
		}
		//assigning the method to the delegate field
		harry.shout=Harry_Shout;

		harry.shout();
		harry.shout();
		harry.shout();
		harry.shout();

        	*/
        	/*
		Person[] people = 
		{
			new Person{Name="Simon"},
			new Person{Name="Jenny"},
			new Person{Name="Adam"},
			new Person{Name="Richard"},
			
		};

		WriteLine("Initial list of people:");
		foreach(Person person in people)
		{
			WriteLine($" {person.Name}");
		}

        	
		WriteLine("Using Person's IComparable implementatino to sort:");
		Array.Sort(people);
		foreach(Person person in people)
		{
			WriteLine($" {person.Name}");
		}
        	
		WriteLine("using PersonComparer's IComparer implementation to sort");
		Array.Sort(people,new Comparer());
		foreach(Person person in people)
		{
			WriteLine("$ {person.Name}");
		}
        	*/

        	/*
		var t1 = new Thing();
		t1.Data = 42;
		WriteLine($"Thing with an integer: {t1.Process(42)}");

		var t2 = new Thing();
		t2.Data = "apple";
		WriteLine($"Thing with a string: {t2.Process("apple")}");
		*/
		/*

		var gt1 = new GenericThing<int>();
		gt1.Data = 42;
		WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

		var gt2 = new GenericThing<string>();
		gt2.Data = "apple";
		WriteLine($"GenericThing with a string: {gt2.Process("apple")}");
		
		*/
		/*
		string number1 = "4";
		WriteLine("{0} squared is {1}",
			arg0:number1,
			arg1:Squarer.Square<string>(number1));
		
		byte number2 = 3;
		WriteLine("{0} squared id {1}",
			arg0:number2,
			arg1:Squarer.Square<byte>(number2));
		*/

		Employee john = new Employee
		{
			Name = "John Jones",
			DateOfBirth = new DateTime(1990, 7, 28)
		};
		john.WriteToConsole();

	}
    }
}
