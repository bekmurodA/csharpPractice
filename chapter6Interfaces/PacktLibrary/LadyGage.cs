using static System.Console;

namespace Packt.Shared
{
	public class Singer
	{
		// virtual allows the method to be overridden
		public virtual void Sing()
		{
		  WriteLine("Singing ...);
		}


	}
	public class LadyGaga : Singer
	{
		// sealed prevents overriding the method in subclasses
		public sealed override Sing()
		{
			WriteLine("Singing with style ...");
		}
	}
}
