using System;
using static System.Console;
using System.Globalization;

namespace Internationlization
{
    class Program
    {
        static void Main(string[] args)
        {
        	CultureInfo globalization = CultureInfo.CurrentCulture;
        	CultureInfo localization = CultureInfo.CurrentUICulture;

		WriteLine("The current globalization culture is {0}: {1}",
		  globalization.Name, globalization.DisplayName);
		WriteLine("The current localization culture is {0}: {1}",
		  localization.Name, localization.DisplayName);

		WriteLine();
	}

    }
}
