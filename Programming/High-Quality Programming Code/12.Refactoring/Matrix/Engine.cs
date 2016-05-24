namespace OperationMatrix
{
    using System;

    public class Engine
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            int dimension = int.Parse(Console.ReadLine());

            var matrix = new Matrix(dimension);
            matrix.FillMatrix();
            matrix.PrintMatrix();
        }
    }
}
