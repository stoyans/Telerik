namespace RefactorCodeProperNaming
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Figure GetRotatedSize(Figure figure, double rotatedAngle)
        {
            double resizedWidth = (Math.Abs(Math.Cos(rotatedAngle)) * figure.width) + (Math.Abs(Math.Sin(rotatedAngle)) * figure.height);
            double resizedHeight = (Math.Abs(Math.Sin(rotatedAngle)) * figure.width) + (Math.Abs(Math.Cos(rotatedAngle)) * figure.height);

            return new Figure(resizedWidth, resizedHeight);
        }
    }
}
