using System;
using System.Threading;

namespace Packt.Shared
{
 // Squares class is non-generic
 public static class Squarer
 {
  // generic method
  public static double Square<T>(T input) where T : IConvertible
  {
   //convert using the current culture
   double d = input.ToDouble(
   	Thread.CurrentThread.CurrentCulture);
   return d * d;
  }
 }
}
