using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Point3D
{
    static class CalculateDistance
    {
        public static double Distance(Point3D PointA, Point3D PointB)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(PointA.X - PointB.X, 2) + Math.Pow(PointA.Y - PointB.Y, 2) + Math.Pow(PointA.Z - PointB.Z, 2));

            return distance;
        }

    }
}
