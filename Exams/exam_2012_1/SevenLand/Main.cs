using System;

class SevenLand
{
	public static void Main ()
	{
		
		int k = int.Parse(Console.ReadLine());

		for (int i = k+1; i <= 1000; i++) 
		{
			bool isSeven = false;
			
			string num = i.ToString();
			
			for (int n = 0; n < num.Length; n++) 
			{
				if (num[n] - 48 > 6 && num[n] - 48 <=9)
				{
					isSeven = true;
				}
			}
			if (isSeven == false) 
			{
				Console.WriteLine (i);
				break;
			}
			else
			{
				continue;
			}
		}
		
	}
}