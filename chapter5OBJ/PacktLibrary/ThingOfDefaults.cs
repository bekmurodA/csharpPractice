using System;
using System.Collections.Generic;

namespace Packt.Shared
{
	public class ThingOfDefaults
	{
		public int Population;
		public DateTime When;
		public string name;
		public List<Person> People;

		public ThingOfDefaults()
		{
			Population = default;	//(int);
			When = default;		//(DateTime);
			name = default;		//(string);
			People = default;	//(List<Person>);
		}

	}
}
