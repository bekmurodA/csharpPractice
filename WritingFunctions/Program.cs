using static System.Console;



namespace WritingFunctions
{
    class Program
    {
	static int FibFunctional(int term) => 
		term switch
		{
			1=>0,
			2=>1,
			_=>FibFunctional(term-2)+FibFunctional(term-1)
		};
	static void RunFib()
	{
		for(int i=1;i<30;i++)
		{
			WriteLine(
				format:"{0}-term for the sequence is {1:N0}",
				arg0:i-1,
				arg1:FibFunctional(term:i));
		}
	}
	static int Factorial(int number)
	{
		if(number<1)
		{
			return 0;
		}
		if(number == 1)
		{
			return 1;
		}
		else
		{
			checked
			{
				return number * Factorial(number-1);
			}
		}
	}

	static void RunFactorial()
	{
		for(int i=1;i<15;i++)
		{
			try{
			Write($"{i}! = {Factorial(i):N0}  {Factorial(i).GetType()}\n ");
			}

			catch(System.OverflowException)
			{
				WriteLine("too big for int 32");
			}
		}
	}
	static decimal CalculateTax(
			decimal amount, string regionCode)
    	{
		decimal rate = 0.0M;
		switch(regionCode)
		{
			case "CH": //Switzerland
				rate = 0.08M;
				break;
			case "DK": //Denmark
			case "NO": //Norway
				rate = 0.25M;
				break;
			case "GB":
			case "FR":
				rate = 0.2M;
				break;
		}
		return amount*rate;
	}
	static void RunCalculateTax()
	{
		Write("Enter an amount: ");
		string amountT = ReadLine();
		Write("Enter a two letter region code: ");
		string region = ReadLine();
		if(decimal.TryParse(amountT,out decimal amount))
		{
			decimal taxToPay = CalculateTax(amount,region);
			WriteLine($"You must pay {taxToPay} in sales tax");
		}	
		else
		{
			WriteLine("You did not enter a valid amount");
		}
	}
	static void TimesTable(byte number)
	{
		WriteLine($"The is the {number} time tables");

		for (int row=1; row<=12;row++)
		{
			WriteLine(
				$"{row}x{number} = {row*number}");
		}
		WriteLine();
	}
	static void RunTimesTable()
	{
		bool isNumber;
		do
		{
			Write("Enter a number between 0 and 255: ");
			isNumber = byte.TryParse(
				ReadLine(),out byte number);
			
			if(isNumber)
			{
				TimesTable(number);
			}
			else
			{
				WriteLine("You did not enter a valid number!");
			}
		}
		while(isNumber);
	}
        static void Main(string[] args)
        {
		//RunTimesTable();
		//RunCalculateTax();
		//RunFactorial();
		RunFib();
        }
    }
}
