namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("width must have positive value");
                }

                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("height must have positive value");
                }

                this.height = value;
            }
        }

        public override double Perimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double Area()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
