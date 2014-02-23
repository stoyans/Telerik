using System;

namespace Task12_ChangeBitValue
{
    class Task12_ChangeBitValue
    {
        static void Main()
        {
            Console.Write("Enter a integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for v (0 or 1): ");
            byte v = byte.Parse(Console.ReadLine());
            Console.Write("Position of the bit: ");
            byte p = byte.Parse(Console.ReadLine());

            int modifiedn = n & (~(1 << p)); //Битът на позиция p в числото n го превръщаме в 0. Пример: 15 (1111), p = 2; ~(1<<2) == ~0100==1011; 1111 & 1011 = 1011;  
            modifiedn = modifiedn | (v << p); //Полученият резултат 1011 го събираме побитово с v на позиция p: 1011 | 0100 (ако v = 1) = 1011;
            Console.WriteLine("The new number with changed bit at position {0} is {1}", p, modifiedn);

        }
    }
}
