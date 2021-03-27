using static System.Convert;
using System;
using static System.Console;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
		long e = 10;
		int f = (int)e;
		WriteLine($"e is {e:N0}, f is {f:N0}");
		e = long.MaxValue;
		f = (int)e;
		WriteLine($"e is {e:N0}, f is {f:N0}");
		double g = 9.8;
		int h = ToInt32(g);
		WriteLine($"g is {g}, h is {h}");
		//anytype can be converted to string
		WriteLine(h.ToString());


        }
    }
}
