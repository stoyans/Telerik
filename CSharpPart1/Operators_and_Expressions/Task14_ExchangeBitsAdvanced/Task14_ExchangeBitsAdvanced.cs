using System;

namespace Task14_ExchangeBitsAdvanced
{
    class Task14_ExchangeBitsAdvanced
    {
        static void Main()
        {
			
            Console.Write("Enter a positive integer number: ");
            uint num = uint.Parse(Console.ReadLine());
			
            Console.Write("Enter starting position of the first group of bits p: ");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("How many bits do you want to exchange: ");
            byte count = byte.Parse(Console.ReadLine());
            Console.Write("Enter starting position of the second group of bits q (q > p+count): ");
            byte q = byte.Parse(Console.ReadLine());
            
            uint modifiedNum = num;
            // Инициализираме цикъл, който ще обиколи броя на битовете зададен в count
            
			for (int i = 0; i < count; i++)
			{
				uint maskfirstbit = (uint) 1 << p + i; 
				uint firstbit =  (uint) (num & (1 << p + i)); // Запазваме бита от позиция 0 до p при всяка итерация на цикъла
				uint masksecondbit = (uint) 1 << q + i;
				uint secondbit =(uint) (num & (1 << q + i)); // Запазваме бита от позиция 0 до q при всяка итерация на цикъла
				
				modifiedNum &= (~maskfirstbit) & (~masksecondbit); // Нулираме позиции от p до p+i и от q до q+i
				modifiedNum |= ((firstbit >> p)<<q) | ((secondbit >> q)<<p); // Събираме побитово модифицираното числото(със занулените битове)
				//със запазените битове като им разменяме позициите
			
			}
			
			Console.WriteLine(modifiedNum);
        }
    }
}
