using System;

namespace Packt.Shared
{
  public class GenericThing<T> where T : IComparable
  //it implements IComparable interface, so must have method named CompareTo
  {
	public T Data = default(T);
	
	public string Process(T input)
	{
		if (Data.CompareTo(input) == 0)
		{
			return "Data and input are the same.";
		}
		else
		{
			return "Data and input are NOT the same.";
		}
	}
  }
}
