namespace Packt.Shared
{
    public class ImmutablePerson
    {
	public string FirstName {get;init;}
	public string LastName {get;init;}
    }
    //making the whole object immutable
    public record ImmutableVehicle
    {
	public int Wheels {get;init;}
	public string Color {get;init;}
	public string Brand {get;init;}
    }

   /* public record ImmutableAnimal
    {
	string Name; // i.e public init-only property
	string Species;
    
   	 public ImmutableAnimal(string name, string species)
    {
	Name = name;
	Species = species;
    }

    public void Deconstruct(out string name, out string species)
    {
	name = Name;
	species = Species;
    }
    }*/
    public record ImmutableAnimal
    {
    string Name;
    string Species;
    public data class ImmutableAnimal(string name,string species);
    }   
}
