namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string NumberToWords(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }
            
            throw new ArgumentException("The number must be between 0 and 9");
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException("The number of elements should be at least one");
            }

            int maxElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        static void PrintAsFixedPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintRightAligned(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            if (y1 == y2 && x1 == x2)
            {
                throw new ArgumentException("There is no line!");
            }

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static bool CheckIfHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }

        public static bool CheckIfVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToWords(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsFixedPoint(1.3);
            PrintAsPercent(0.75);
            PrintRightAligned(2.30);

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + CheckIfHorizontal(2, 2));
            Console.WriteLine("Vertical? " + CheckIfVertical(3, 3));

            Student peter = new Student("Peter", "Ivanov", "17.03.1992");
            peter.OtherInfo = "From Sofia";

            Student stella = new Student("Stella", "Markova", "03.11.1993");
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
