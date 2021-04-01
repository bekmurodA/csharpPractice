using System;
using System.Linq;
using static System.Console;
using Packt.Shared;

namespace MonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
         WriteLine("Processing. Please wait...");
	
	int[] numbers = Enumerable.Range(1,50_000).ToArray();

	WriteLine("Using string with +");
	Recorder.Start();

	string s = "";
	for (int i = 0;i<numbers.Length;i++)
	{
	  s+=numbers[i]+", ";
	}
	Recorder.Stop();
	WriteLine("Using StringBuilder");
	Recorder.Start();
	var builder = new System.Text.StringBuilder();
	for (int i = 0;i<numbers.Length;i++)
	{
	  builder.Append(numbers[i]);
	  builder.Append(", ");
	}
	Recorder.Stop();
	
	/* Recorder.Start();

	 //simulating a process that requires some memory resources
	 int[] longArray = Enumerable.Range(1,20_000).ToArray();

	 // and takes some time to complete
	 System.Threading.Thread.Sleep(
	 	new Random().Next(5,10)*1000);

	Recorder.Stop();*/
	}
    }
}
