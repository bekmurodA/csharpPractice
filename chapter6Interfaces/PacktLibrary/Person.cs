using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class PersonComparer:IComparer<Person>
    {
	public int Compare(Person x, Person y)
	{
		// Compare the name lengths...
		int result = x.Name.Length.CompareTo(y.Name.Length);
		
		// if they are equal...
		if (result == 0)
		{
			// ... then  compare by the names
			return x.Name.CompareTo(y.Name);
		}
		else
		{
			return result;
		}
	}
    }
    public class Person : IComparable<Person>
    {
    	//fields
	public string Name;
	public DateTime DateOfBirth;
	public List<Person> Children = new List<Person>();
	
	//methods 
	public void WriteToConsole()
	{
		WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
	}

	//static method to "multiply"
	//static methods are actions that the type does
	public static Person Procreate(Person p1, Person p2)
	{
		Person baby = new Person
		{
			Name=$"Baby of {p1.Name} and {p2.Name}"
		};
		p1.Children.Add(baby);
		p2.Children.Add(baby);

		return baby;
	}
	//instance method to multiply
	//instance methods are actions that an object does to itself
	public Person ProcreateWith(Person partner)
	{
		return Procreate(this,partner);
	}

	//operator to "multiply"
	public static Person operator * (Person p1, Person p2)
	{
		return Person.Procreate(p1,p2);
	}

	//event delegate field
	/* public delegate void EventHandler(object sender,EventArgs e) */
	public EventHandler shout;

	//data field 
	public int AngerLevel;

	//method 
	public void Poke()
	{
		AngerLevel ++;
		if (AngerLevel >=3)
		{
			//if something is listening
			// ... then call the delegate
			shout?.Invoke(this, EventArgs.Empty);
		
		}
	}
	public int CompareTo(Person other)
	{
		return Name.CompareTo(other.Name);
	}

    }
}
