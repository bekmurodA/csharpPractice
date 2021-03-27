using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
        	int numberOfApples = 12;
		decimal pricePerApple = 0.35M;

		Console.WriteLine(
			format: "{0} apple costs {1:C}",
			//{index [, alignment][:formatstring]}
			//:C format string means currence
			arg0:numberOfApples,
			arg1:pricePerApple* numberOfApples);

		string formatted = string.Format(
			format:"{0} apples costs {1:C}",
			
			arg0:numberOfApples,
			arg1:pricePerApple* numberOfApples);
			//WriteToFile(formatted) //writes string into a file

	}
    }
}
