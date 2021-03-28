namespace Packt.Shared
{
	public partial class Person
	{	
		// a property defined using c# 1-5 systax
		public string Origin
		{
			get
			{
				return $"{name} was born on {HomePlanet}";
			}
		}
		
		// two properties defined using C# 6+ Lambda expression

		public string Greeting => $"{name} says 'Hello!'";

		public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

		public string FavoriteIceCream{ get; set; }//auto syntax
		private string favoritePrimaryColor;
		
		public string FavoritePrimaryColor
		{
			get
			{
				return favoritePrimaryColor;	
			}
			set
			{
				switch(value.ToLower())
				{
					case "red":
					case "green":
					case "blue":
						favoritePrimaryColor = value;
						break;
					default:
						throw new System.ArgumentException(
						$"{value} is not an primary color. " + "Chose from: red, green, blue.");
				}
			}
			
		}

		//indexers 
		public Person this[int index]
		{
		   get
		   {
		   	return Children[index];
		   }
		   set
		   {

			Children[index] = value;
		   }
		}

	}
}
