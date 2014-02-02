using System;

class Garden {
	
	static void Main ()
	{
		ushort tomatoAmount = ushort.Parse (Console.ReadLine());
		byte tomatoArea = byte.Parse(Console.ReadLine());
		ushort cucumberAmount = ushort.Parse (Console.ReadLine());
		byte cucumberArea = byte.Parse(Console.ReadLine());
		ushort potatoAmount = ushort.Parse (Console.ReadLine());
		byte potatoArea = byte.Parse(Console.ReadLine());
		ushort carrotAmount = ushort.Parse (Console.ReadLine());
		byte carrotArea = byte.Parse(Console.ReadLine());
		ushort cabbageAmount = ushort.Parse (Console.ReadLine());
		byte cabbageArea = byte.Parse(Console.ReadLine());
		ushort beansAmount = ushort.Parse (Console.ReadLine());
		
		decimal tomatoPrice = tomatoAmount*0.5m;
		decimal cucumberPrice = cucumberAmount*0.4m;
		decimal potatoPrice = potatoAmount*0.25m;
		decimal carrotPrice = carrotAmount*0.6m;
		decimal cabbagePrice = cabbageAmount*0.3m;
		decimal beansPrice = beansAmount*0.4m;
		
		decimal totalSum = cabbagePrice + carrotPrice + cucumberPrice+ potatoPrice+ tomatoPrice + beansPrice;
		Console.WriteLine ("Total costs: {0:F2}",totalSum);
		
		int areaSum = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
		if (areaSum > 250) {
			Console.WriteLine ("Insufficient area");
		}
		else if (areaSum < 250) {
			Console.WriteLine ("Beans area: {0}", 250-areaSum);
		}
		else if (areaSum == 250) {
			Console.WriteLine ("No area for beans");
		}
		
		
	}
}