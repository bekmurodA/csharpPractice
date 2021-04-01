using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace AsyncEnumerable
{
    class Program
    {
	// method that yield returns a random sequecnce of three numbers async
	async static IAsyncEnumerable<int> GetNumbers()
	{
		var r = new Random();

		// smiluta work
		await Task.Run(()=>Task.Delay(r.Next(1500,3000)));
		yield return r.Next(0,1001);

		await Task.Run(()=>Task.Delay(r.Next(1500,3000)));
		yield return r.Next(0,1001);

		await Task.Run(()=>Task.Delay(r.Next(1500,3000)));
		yield return r.Next(0,1001);
	}

        static async Task  Main(string[] args)
        {
	
		await foreach(int number in GetNumbers())
		{
			WriteLine($"Number: {number}");
		}
		
        }
    }
}
