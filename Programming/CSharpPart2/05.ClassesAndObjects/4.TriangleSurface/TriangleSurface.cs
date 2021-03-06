/*Write methods that calculate the surface of a triangle by given:Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;
using System.Collections.Generic;

class TriangleSurface
{
    static decimal AreaSideAndAltitude()
    {
        Console.Write("value for the side: ");
        decimal side = decimal.Parse(Console.ReadLine());
        Console.Write("value for the altitude: ");
        decimal altitude = decimal.Parse(Console.ReadLine());

        return (side * altitude) / 2;
    }

    static double AreaByThreeSides()
    {
        Console.Write("value for the sideA: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("value for the sideB: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("value for the sideC: ");
        double sideC = double.Parse(Console.ReadLine());

        double semiPerimeter = (sideA + sideB + sideC) / 2;

        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        return area;
    }

    static double AreaByTwoSidesAngleBetween()
    {
        Console.Write("value for the sideA: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("value for the sideB: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("value for the angle: ");
        double angle = double.Parse(Console.ReadLine());

        double area = sideA * sideB * Math.Sin(angle);

        return area;



    }

    static void Main()
    {
        Console.WriteLine("{0:F3} m^2", AreaSideAndAltitude());
        Console.WriteLine("{0:F3} m^2", AreaByThreeSides());
        Console.WriteLine("{0:F3} m^2", AreaByTwoSidesAngleBetween());
    }
}