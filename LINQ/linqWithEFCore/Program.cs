using System;
using static System.Console;
using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace linqWithEFCore
{
    class Program
    {
       static void AggregateProducts()
       {
	using (var db = new Northwind())
	{
	  WriteLine("{0,-25} {1,10}",
	  arg0: "Product count:",
	  arg1: db.Products.Count());
	  WriteLine("{0,-25} {1,10:$#,##0.00}",
	  arg0: "Heighest product price:",
	  arg1: db.Products.Max(p=>p.UnitPrice));
	  WriteLine("{0,-25} {1,10:N0}",
	  arg0: "Sum of units in stock:",
	  arg1: db.Products.Sum(p=>p.UnitsInStock));
	  WriteLine("{0,-25} {1,10:$#,##0.00}",
	  arg0: "Sum of units on order:",
	  arg1: db.Products.Sum(p=>p.UnitsOnOrder));
	  WriteLine("{0,-25} {1,10:$#,##0.00}",
	  arg0: "Value of units in stock:",
	  arg1: db.Products.AsEnumerable().Sum(p=>p.UnitPrice* p.UnitsInStock));


	}
       }
       static void GroupJoinCategoriesAndProducts()
       {
	using(var db = new Northwind())
	{
	  // grouping all products by their category to return 8 matches
	  var queryGroup = db.Categories.AsEnumerable().GroupJoin(
		inner : db.Products,
		outerKeySelector: category => category.CategoryID,
		innerKeySelector: product => product.CategoryID,
		resultSelector: (c,matchingProducts) => new{
		  c.CategoryName,
		  Products = matchingProducts.OrderBy(p => p.ProductName)
		});
	
	  foreach(var item in queryGroup)
	  {
		WriteLine("{0} has {1} products",
		arg0: item.CategoryName,
		arg1: item.Products.Count());

		foreach(var product in item.Products)
		{
		  WriteLine($"{product.ProductName}");
		}
	  }
	  
	}
       }
       static void JoinCategoriesAndProducts()
       {
	using(var db = new Northwind())
	{
	  // join every product to its category to return 77 matches
	  var queryJoin = db.Categories.Join(
	  	inner: db.Products,
		outerKeySelector: category => category.CategoryID,
		innerKeySelector: product => product.CategoryID,
		resultSelector: (c,p) => new {c.CategoryName,p.ProductName,p.ProductID}).OrderBy(cp => cp.CategoryName);
	  foreach (var item in queryJoin)
	  {
		WriteLine("{0}: {1} is in {2}.",
		  arg0: item.ProductID,
		  arg1: item.ProductName,
		  arg2: item.CategoryName);
	  }
	}
       }
       static void FilterAndSort()
       {
	using(var db = new Northwind())
	{
	   var query = db.Products
	   //query is DbSet<Product>
	   .Where(product => product.UnitPrice < 10M)
	   //query is now an IQueryable<Product>
	   .OrderByDescending(product => product.UnitPrice)
	   // query is now on an IOrderedQueryable<Product>
	   .Select(product => new //anonymous type
	   {
    	     product.ProductID,
	     product.ProductName,
	     product.UnitPrice
	   });
	   WriteLine("Products that cost less than $10: ");
	   foreach(var item in query)
	   {
		WriteLine("{0}: {1} costs {2:$#,##0.00}",
		 item.ProductID,item.ProductName,item.UnitPrice);
	   }
	   WriteLine();
	}
       }
       static void Main(string[] args)
        {
	//	FilterAndSort();
	//	JoinCategoriesAndProducts();
	//	GroupJoinCategoriesAndProducts();
		AggregateProducts();
        }
    }
}
