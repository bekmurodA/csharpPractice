using System;
using static System.Console;
using System.Linq;

namespace linqWithObjects
{
    class Program
    {
	static void LinqWithArrayOfExceptions()
	{
	  var errors = new Exception[]
	  {
		new ArgumentException(),
		new SystemException(),
		new IndexOutOfRangeException(),
		new InvalidOperationException(),
		new NullReferenceException(),
		new InvalidCastException(),
		new OverflowException(),
		new DivideByZeroException(),
		new ApplicationException(),
	  };

	  var numberErrors = errors.OfType<ArithmeticException>();

	  foreach (var e in numberErrors)
	  {
		WriteLine(e);
	  }
	}
        static void Main(string[] args)
        {
        	static void linqWithArrayOfStrings()
		{
			var names = new string[] {"Michael","Pam","Jim","Dwight","Angela",
			"Kevin","Toby","Creed"};

			//var query = names.Where(new Func<string, bool>(NameLongerThanFour));
			//Func<string,bool> input:string output:bool

			//var query = names.Where(NameLongerThanFour);
			var query = names
				.Where(name=>name.Length>4)
				.OrderBy(name=>name.Length)
				.ThenBy(name=>name);
			foreach(string item in query)
			{
				WriteLine(item);
			}
		}
		//linqWithArrayOfStrings();
		LinqWithArrayOfExceptions();
	}

	/*static bool NameLongerThanFour(string name)
	{
		return name.Length > 4; 
	}*/

    }
}
