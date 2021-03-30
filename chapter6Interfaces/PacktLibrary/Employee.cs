using System;
namespace Packt.Shared
{
    public class Employee : Person
    {  

	//overriding the methods
	public override string ToString()
	{
		return $"{Name} is a {base.ToString()}";
		//The base keyword allows a subclass to access members of
		//its superclass
	}
    }
}
