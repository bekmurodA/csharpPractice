using System;
using static System.Console;
using System.Reflection;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
        	/*WriteLine("assembly metadata:");
		Assembly assembly = Assembly.GetEntryAssembly();

		WriteLine($"Full Name : {assembly.FullName}");
		WriteLine($"Location : {assembly.Location}");

		var attributes = assembly.GetCustomAttributes();

		WriteLine("Attributes:");
		foreach (Attribute a in attributes)
		{
			WriteLine($"{a.GetType()}");
		}
		*/
		Assembly assembly = Assembly.GetEntryAssembly();
		var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();

		WriteLine($"Version: {version.InformationalVersion}");

		var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
		WriteLine($" Company: {company.Company}");

	}
    }
}
