using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace WorkingWithTasks
{
    class Program
    {
	static decimal CallWebService()
	{
	  WriteLine("Starting call to web service ...");
	  Thread.Sleep((new Random()).Next(2000,4000));
	  WriteLine("Finished call to web service");
	  return 89.99M;
	}

	static string CallStoredProcedure(decimal amount)
	{
	  WriteLine("Starting call to stored procedure..");
	  Thread.Sleep((new Random()).Next(2000,4000));
	  WriteLine("Finished call to stored procedure.");
	  return $"{amount:C}.";
	}
	static void MethodA()
	{
	  WriteLine("Starting MethodA... ");
	  Thread.Sleep(3000); //simulate three seconds of work
	  WriteLine("Finished MethodA... ");
	}
	static void MethodB()
	{
	  WriteLine("Starting MethodB... ");
	  Thread.Sleep(2000); //simulate two   seconds of work
	  WriteLine("Finished MethodB... ");
	}
	static void MethodC()
	{
	  WriteLine("Starting MethodC... ");
	  Thread.Sleep(1000); //simulate one   seconds of work
	  WriteLine("Finished MethodC... ");
	}
        static void Main(string[] args)
        {
        	var timer = Stopwatch.StartNew();
		WriteLine("Running methods asynchronously on multiple threads.");
	//	MethodA();
	//	MethodB();
	//		MethodC();
	//	WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed");
		/*Task taskA = new Task(MethodA);
		taskA.Start();
		Task taskB = Task.Factory.StartNew(MethodB);
		Task taskC = Task.Run(new Action(MethodC));

		Task[] tasks = {taskA, taskB, taskC};
		Task.WaitAll(tasks);*/

		WriteLine("Passing the result of one task as an input into another.");

		var taskCallWS = Task.Factory.StartNew(CallWebService).ContinueWith(previousTask => CallStoredProcedure(previousTask.Result));
		WriteLine($"Result: {taskCallWS.Result}");
	}
    }
}
