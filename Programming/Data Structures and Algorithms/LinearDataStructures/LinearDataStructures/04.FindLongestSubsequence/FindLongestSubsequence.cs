using System;
using System.Collections.Generic;

namespace FindLongestSubsequence
{
	class MainClass
	{
		public static void FindSequence(List<int> nums)
		{
			int longestSeq = 0;
			var currentList = new List<int>();
			var resultList = new int[currentList.Count];	
			
			for (int i = 0; i < nums.Count; i++) 
			{
				int counter = 0;
				currentList.Clear();
				
				for (int k = 1; k < nums.Count; k++) 
				{
					if (nums[i] == nums[k]) 
					{
						counter++;
						currentList.Add(nums[k]);						
					}
				}
				
				if (counter >= longestSeq) 
				{
					longestSeq = counter;	
					resultList = new int[currentList.Count];
					currentList.CopyTo(resultList);
				}
				
			}
			
			
			foreach (var item in resultList) 
			{
				Console.WriteLine (item);	
			}
		}
		
		public static List<int> FillInNumbers()
		{
			var listOfNumbers = new List<int>();
			
			while(true) 
			{
				string symbol = Console.ReadLine();
				
				if (symbol == string.Empty)
				{
					break;
				}
				listOfNumbers.Add(int.Parse(symbol)); 
			}
			
			return listOfNumbers;
		}
		
		public static void Main ()
		{
			FindSequence(FillInNumbers());
		}
	}
}
