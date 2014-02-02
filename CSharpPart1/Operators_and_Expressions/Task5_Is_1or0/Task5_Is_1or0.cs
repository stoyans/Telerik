using System;

namespace Task5_Is_1or0
{
    class Task5_Is_1or0
    {
        static void Main()
        {
            Console.Write("Enter some number: ");
            int num = int.Parse(Console.ReadLine());
            //Изразът може да бъде представен и като num & 8, тъй като 1 << 3 представлява 0100 в двоична бройна система.
            //След това уможаваме побитово двете числа: ако num = 9 имаме 1001
            //                                                            1000. Ако отговорът е равен на 0 следователно третият бит е 0, ако result = 8 => третият бит е 1;
            int result = num & (1 << 3);
            Console.WriteLine(result == 0? "3rd bit is -> 0": "3rd bit is -> 1");
        }
    }
}
