using System;
using static System.Console;
using System.Linq;

namespace linqWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
        	static void linqWithArrayOfStrings()
		{
			var names = new string[] {"Michael","Pam","Jim","Dwight","Angela",
			"Kevin","Toby","Creed"};

			var query = names.Where(new Func<string, bool>(NameLongerThanFour));
			//Func<string,bool> input:string output:bool

			foreach(string item in query)
			{
				WriteLine(item);
			}
		}
		linqWithArrayOfStrings();
	}

	static bool NameLongerThanFour(string name)
	{
		return name.Length > 4; 
	}

    }
}
