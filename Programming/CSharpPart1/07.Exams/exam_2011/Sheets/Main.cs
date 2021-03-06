using System;

class Sheets
{
	public static void Main ()
	{
		
		int n = int.Parse (Console.ReadLine ());
		n = 2047 - n;
		
		int[] sheets = {1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1};
		int [] result = new int [sheets.Length];
		int a0 = 1024;
		int a1 = 512;
		int a2 = 256;
		int a3 = 128;
		int a4 = 64;
		int a5 = 32;
		int a6 = 16;
		int a7 = 8;
		int a8 = 4;
		int a9 = 2;
		int a10 = 1;
	
		for (int i = 0; i < 2047; i++) {
			int sum = 0;
			
			for (int i1 = 0; i1 < result.Length; i1++) {
				result [i1] = 0;
				
			}
			
			for (int k = 0; k < 11; k++) {
				int mask = 1 << k;
				int bit = i & mask;
				int bitr = bit >> k;
				
				if (bitr == 1) {
					sum += sheets [k];
					result [k] = sheets [k];
				}
				
			}	
			if (sum == n) {
				break;
			}
		}
		
		for (int i = 0; i < result.Length; i++) {
			switch (result [i]) {
			case 1024:
				Console.WriteLine ("A0");
				break;
			case 512:
				Console.WriteLine ("A1");
				break;
			case 256:
				Console.WriteLine ("A2");
				break;
			case 128:
				Console.WriteLine ("A3");
				break;
			case 64:
				Console.WriteLine ("A4");
				break;
			case 32:
				Console.WriteLine ("A5");
				break;
			case 16:
				Console.WriteLine ("A6");
				break;
			case 8:
				Console.WriteLine ("A7");
				break;
			case 4:
				Console.WriteLine ("A8");
				break;
			case 2:
				Console.WriteLine ("A9");
				break;
			case 1:
				Console.WriteLine ("A10");
				break;
			}
		}
		
	}
}