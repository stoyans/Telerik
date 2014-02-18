using System;

namespace Bank
{
	public class Individual: Customer
	{
		private int age;
		
		public Individual (string name, string address, int age)
			:base(name, address)
		{
			this.Age = age;
		}
		
		public int Age {get; set;}
	}
}

