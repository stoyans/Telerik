using System;

class Tribonacci
{
	public static void Main ()
	{
		
		long first = long.Parse (Console.ReadLine ());
		long second = long.Parse (Console.ReadLine ());
		long third = long.Parse (Console.ReadLine ());
		long next;
		
		byte l = byte.Parse (Console.ReadLine ());
		
		Console.WriteLine (first);
		Console.WriteLine ("{0} {1}", second, third);
		
		for (int i = 3; i <= l; i++) 
		{
			for (int k = 1; k <= i; k++) 
			{
				next = first+second+third;
				if (k==i) {
					Console.Write ("{0}", next);
				}
				else
				{
					Console.Write ("{0} ", next);
				}
				first = second;
				second = third;
				third = next;
				
			}
			Console.WriteLine ();
		}
		
	}
}