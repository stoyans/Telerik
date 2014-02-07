using System;

namespace _1.Point3D
{
    class Program
    {
        static void Main()
        {
            Point3D point = new Point3D(2, 3, 7);
            Point3D point2 = new Point3D(1, -3, 8);
            Console.WriteLine(point.ToString());
            Console.WriteLine(CalculateDistance.Distance(point, point2));

            Path pathOfPoints3D = new Path();
            pathOfPoints3D.AddPoint(point);
            pathOfPoints3D.AddPoint(point2);
            PathStorage.savePaths(pathOfPoints3D);

        }
    }
}
