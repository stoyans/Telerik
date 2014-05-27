namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        public abstract double Area();

        public abstract double Perimeter();

        public override string ToString()
        {
            string typeFigure = string.Format("I am a {0}", this.GetType().Name);
            string perimeter = string.Format("My perimeter is {0:f2}", this.Perimeter());
            string area = string.Format("My surface is {0:f2}", this.Area());

            return typeFigure + '\n' + perimeter + '\n' + area;
        }
    }
}
