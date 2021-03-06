﻿using System;
using System.Collections.Generic;

namespace Subset_Sums
{
	class Subset_Sums
	{
		static void Main ()
		{
			//Идеята на метода е да обходим всички възможни комбинации на числата. За тази цел ще използваме числата от 0 до (2 на степен 5) минус 1 - (31) - ще ги използваме като шаблон
			// т.е. 00000, 00001, 00010... 00111 и така до 11111 = 31 в десетична система

			Console.WriteLine ("enter five numbers");
			int [] array = new int[5]; // ще запазваме всички въведени числа в масив
			int count = 0; // запазва броя на подсумите = 0;
			long sum = 0; //запазваме текущата сума
			int power = Convert.ToInt32 (Math.Pow (2, 5)) - 1; //повдигаме на степен
			List<int> nums = new List<int> ();			


			for (int i = 0; i < 5; i++) {
				int number = int.Parse (Console.ReadLine ());
				array [i] = number; // зазване на числата в масива
			}

			for (int i1 = 1; i1 <= power; i1++) { //С първия цикъл обхождаме комбинациите от 0 до 31. Да кажем, че сме стигнали до 11 - 1011. При втория цикъл обхождаме единиците на 11 в двоична система, като си правим маска
				for (int i2 = 0; i2 < 5; i2++) { //Там където имаме 1, съответното число от масива го добавяме към сумата
					int mask = 1 << i2;
					int bit = mask & i1;
					int bit1 = bit >> i2; //получената стойност на позиция i2 я преместваме точно толкова позиции надясно т.е. да дойде на позиция 0, за да имаме резултат 1 и да направим сравнение със следващия if,
					if (bit1 == 1) {        //защото не може динамично да проверяваме кои числа са се поличили на различните позиции (т.е. при 00010 = 2, 01000 = 8 и т.н.)
						sum += array [i2];
						nums.Add (array [i2]);
					}
				}
				if (sum == 0) { //Проверка дали получената сума е = 0;
					foreach (int item in nums) {
						Console.Write ("{0} ", item);
					}
					Console.WriteLine ();
					count++;
				}
				sum = 0;
				nums.Clear();
				
			}
			
			
			
			Console.WriteLine ();
			Console.WriteLine ("There are(is) {0} subset(s) equal(s) to 0", count);
		}
	}
}
