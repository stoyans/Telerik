namespace CohesionAndCoupling
{
    using System;

    public class Example
    {
        public static void Main()
        {
            Console.WriteLine(FileName.GetFileExtension("example"));
            Console.WriteLine(FileName.GetFileExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileName.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Platform2D.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Platform3D.CalcDistance3D(5, 2, -1, 3, -6, 4));

            int width = 3;
            int height = 4;
            int depth = 5;
            Console.WriteLine("Volume = {0:f2}", Platform3D.CalcVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Platform3D.CalcDiagonalXYZ(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Platform2D.CalcDiagonalXY(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Platform2D.CalcDiagonalXZ(width, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Platform2D.CalcDiagonalYZ(height, depth));
        }
    }
}
