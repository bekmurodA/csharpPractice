using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public partial class Person : object
    {
    
	//fields
	public string name;
	public DateTime DateOfBirth;
	public WondersOfTheAncientWorld BucketList;
	public List<Person> Children = new List<Person>();//List of Person
	public const string Species = "Homo Sapien";
    	public readonly string HomePlanet = "Earth";
	public readonly DateTime Instantiated;

	//constructors
	public Person()
	{
		//setting default values for fields
		//including readonly fields
		name = "unknown";
		Instantiated = DateTime.Now;
	}
	public Person(string initialName, string homePlanet)
	{
		name = initialName;
		HomePlanet = homePlanet;
		Instantiated = DateTime.Now;
	}
	
	//methods 
	public void WriteToConsole()
	{
		WriteLine($"{name} was born on a {DateOfBirth}");
	}
	public string GetOrigin()
	{
		return $"{name} was born on {HomePlanet}";
	}	

	//method that returns multiple types
/*	public class TextAndNumber
	{
		public string Text;
		public int Number;
	}
	public class Processor
	{
		public TextAndNumber GetTheDate()
		{
			return new TextAndNumber
			{
				Text = "What is the meaing of life?",
				Number = 42

			};
		}
	}
	*/


    	public (string Name,int Number) GetFruit()
	{
		return (Name:"apple",Number:2);
	}
	//methods with parameters
	public string SayHelloTo(string Name)
	{
		return $"{name} says 'hello {Name}'";
	}

	public void PassingParameters(int x, ref int y, out int z)
	{
		//out parameters cannot have a default
		//and must be initialized inside the  method
		z = 99;
		
		x++;
		y++;
		z++;
	}
    }

}
