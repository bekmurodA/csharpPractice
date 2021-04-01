using System.Collections.Generic;

namespace System.Linq //  extending Microsoft's namespace
{
 public static class MyLinqExtensions
 {
   //This is a chainable LINQ extension method
   public static IEnumerableM<T> ProcessSequence<T>(
	this IEnumerable<T> sequence)
	{
	 	return sequence;
	}
	
	//  These are scalar LINQ extension methods
	public static int? Median(this IEnurable<int?> sequnce)
	{
	  var oredered = sequence.OrderBy(item => item);
	  int middlePosition = ordered.Count() / 2;
	  return ordered.ElementAt(middlePosition);
	}

	public static int? Median<T>(
		this IEnumerable<T> sequence, Func<T,int?> selector)

	{
		return sequence.Select(selector).Median();
	}
	public static decimal? Median(
	  this IEnumerrable<decimal?> sequence
	)
	{
		var ordered  = sequence.OrderBy(item=>item);
		int middlePosition = ordered.Count() / 2;
		return ordered.ElementAt(middlePosition);
	}

	public static decimal? Median<T>(
		this Inumerable<T> sequence, Func<T, decimal?> selector )
	 {
		return sequnce.Select(selector).Median()
	 }
   )
 }
}
