using System;

class A_nacci
{
	public static void Main ()
	{
		int firstLetter = char.Parse (Console.ReadLine ());
		int secondLetter = char.Parse (Console.ReadLine ());
		int lines = int.Parse (Console.ReadLine ());
		firstLetter -=64;
		secondLetter -=64;
		int empty = lines - 2;
		int next = firstLetter + secondLetter;
		
		if (next > 26) {
			next %= 26;	
		}
		
		
		if (lines == 1) {
			Console.WriteLine ((char)(firstLetter+64));
		}
		if (lines == 2) {
			Console.WriteLine ((char)(firstLetter+64));
			Console.WriteLine ("{0}{1}", (char)(secondLetter+64), (char)(next + 64));
		}
		if (lines > 2) {
			Console.WriteLine ((char)(firstLetter+64));
			Console.WriteLine ("{0}{1}", (char)(secondLetter+64), (char)(next + 64));
			
			for (int k = 3; k <= lines; k++) {
				
				firstLetter =  secondLetter;
				secondLetter = next;
				next = firstLetter + secondLetter;
					
				if (next > 26) {
					next %= 26;	
				}
				Console.Write ((char)(next + 64));
				
				for (int n = 1; n <= k - 2; n++) {
						
					Console.Write (' ');
				}
				
				firstLetter =  secondLetter;
				secondLetter = next;
				next = firstLetter + secondLetter;
				
				if (next > 26) {
					next %= 26;	
				}
				
				Console.Write ((char)(next + 64));
				Console.WriteLine ();

			}

		}
		
	}
}