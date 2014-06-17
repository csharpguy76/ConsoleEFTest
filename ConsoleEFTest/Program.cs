using System;

namespace ConsoleEFTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (var context = new SimpleContext ()) {

				var person = new Person { 
					FirstName = "Joe", 
					LastName = "Bloggs" 
				};

				context.People.Add (person);
				context.SaveChanges ();
			}
		}
	}
}
