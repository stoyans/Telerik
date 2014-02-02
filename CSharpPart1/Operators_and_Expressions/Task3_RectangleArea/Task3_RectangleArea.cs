using System;

namespace Task3_RectangleArea
{
    class Task3_RectangleArea
    {
        static void Main()
        {
            Console.Write("The height of the rectangle will be: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("The width of the rectangle will be: ");
            double width = double.Parse(Console.ReadLine());


            Console.WriteLine("The area of the rectangle is: {0}", height*width);
        }
    }
}
