using System.Linq;
using Packt.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NorthwindWeb.Pages
{	

	public  class SuppliersModel : PageModel
	{
		[BindProperty] // easiy connect HTML elements on the web page
		public Supplier Supplier {get;set;}

		public IActionResult OnPost()
		{
		  if (ModelState.IsValid) // checks property values
		  {
			db.Suppliers.Add(Supplier);
			db.SaveChanges();
			return RedirectToPage("/suppliers");
		  }
		  return Page();
		}

		private Northwind db;
		public SuppliersModel(Northwind injectedContext)
		{
			db = injectedContext;
		}
		public IEnumerable<string> Suppliers {get;set;}
		
		public void OnGet()
		{
			ViewData["Title"] = "Northwind Web Site - Suppliers";
			Suppliers = db.Suppliers.Select(s=>s.CompanyName); 
		}
	}
}
