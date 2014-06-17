using System;
using System.Data.Entity;

namespace ConsoleEFTest
{
	public class SimpleContext : DbContext
	{
		public DbSet<Person> People {
			get;
			set;
		}

		public SimpleContext () : base("name=SimpleContext")
		{
		}
	}
}

