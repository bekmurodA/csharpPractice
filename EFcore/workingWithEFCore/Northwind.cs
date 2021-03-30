using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
  
    // this manages the connection to the database
    public class Northwind: DbContext
    {
       //these properties map to tables in the database
       public DbSet<Category> Categories {get;set;}
       public DbSet<Product> Products {get;set;}

       protected override void OnConfiguring(
	DbContextOptionsBuilder optionsBuilder)
       {
		string path = System.IO.Path.Combine(
		System.Environment.CurrentDirectory, "Northwind.db");

		optionsBuilder.UseSqlite($"Filename={path}");
       }
       protected override void OnModelCreating(
	ModelBuilder modelBuilder)
       {
	// examples of using FluentApi instead of attributes
	// to limit the length of a  category name to 15
	modelBuilder.Entity<Category>()
		.Property(category => category.CategoryName)
		.IsRequired() //Not Null
		.HasMaxLength(15);
	//added to "fix" the Lack of decimal support in Sqlite
	modelBuilder.Entity<Product>()
		.Property(product => product.Cost)
		.HasConversion<double>();
	
       }
    }
  }

