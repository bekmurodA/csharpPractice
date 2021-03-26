using System;

namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
        	int thisCannotBeNull = 4;
	//cnt cnv int to null	thisCannotBeNull = null; //compile error

		int? thisCouldBeNull = null;
		Console.WriteLine(thisCouldBeNull);
		Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

		thisCouldBeNull = 7;
		
		Console.WriteLine(thisCouldBeNull);
		Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
	}
    }
}
