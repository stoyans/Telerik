using System;
using System.Numerics;

class excelColumns
{
	public static void Main ()
	{
		int n = int.Parse(Console.ReadLine());
		BigInteger power = 1;
        BigInteger sum = 0;
		
		for (int i = 0; i < n-1; i++) {
			
			power *=26;
			
		}
		
		while (n>=1) {
			
			uint letter = char.Parse(Console.ReadLine());
			letter -= 64;
			
			sum += letter*power;
			
			n--;
			power /=26;
		}
		
		Console.WriteLine (sum);
	}
}