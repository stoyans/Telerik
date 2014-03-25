using System;

namespace Task13_ExchangeBIts
{
    class Task13_ExchangeBIts
    {
        static void Main()
        {
            Console.Write("Enter an unsigned integer number: ");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The number in bits is: {0}", Convert.ToString(num, 2).PadLeft(32, '0'));

            uint mask = 7; //Избираме маска 7, тъй като в двоична система числото представлява 111
            Console.WriteLine("mask in bits is:       {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));

            uint firstbits = num & (mask << 3); // Запазваме битове 3,4,5 в променливата firstbits
            Console.WriteLine("firstbits are:         {0}", Convert.ToString(firstbits, 2).PadLeft(32, '0'));
            uint secondbits = num & (mask << 24); // В променливата secondbits запазваме битове 24, 25, 26
            Console.WriteLine("secondbits are:        {0}", Convert.ToString(secondbits, 2).PadLeft(32, '0'));

            uint modified_num = num & (~(mask << 3)) & (~(mask << 24)); // Нулираме позиции 3, 4, 5 и 24, 25, 26 във въведеното число
            Console.WriteLine("Positions 3,4,5 and 24,25,26\nreplaced with zeros:   {0}", Convert.ToString(modified_num, 2).PadLeft(32, '0'));

            modified_num |= ((firstbits >> 3) << 24) | ((secondbits >> 24) << 3); // Събираме побитово числото със занулените битове и запазените битове (firstbits И secondbits)...
            // като им разменяме местата
            Console.WriteLine("The result in bits is: {0}", Convert.ToString(modified_num, 2).PadLeft(32, '0'));

            Console.WriteLine();
            Console.WriteLine("The number with exchanged bits is: {0}", modified_num);

        }
    }
}
