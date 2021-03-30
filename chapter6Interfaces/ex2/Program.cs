using System;

namespace ex2
{
    class Program
    {
    	public class  Shape
	{
		public double height;
		public double width;
		
		public double  area;


	}
	public class Rectangle : Shape
	{
		public Rectangle(double h, double w)
		{
			height = h;
			width = w;
			
		
		
			area =  height*width;
		}
		
	}	
	public class Square : Shape
	{	
		public Square(double h)
		{
			height=h;
		
		
			area= height*height;
		}
	}
	        static void Main(string[] args)
        {
        	var r = new Rectangle(3,4.5);
		Console.WriteLine($"Rectangle H: {r.height}, W: {r.width}, area: {r.area}");
		var s = new Square(5);
		Console.WriteLine($"Rectangle H: {s.height}, W: {s.width}, area: {s.area}");
	}
    }
}
