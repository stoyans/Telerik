namespace RefactorTheStatement
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            int x = 0;
            int y = 0;
            int minX = 0;
            int maxX = 0;
            int minY = 0;
            int maxY = 0;
            bool shouldNotVisitCell = true;

            bool isRangeX = minX < x && x < maxX;
            bool isRangeY = minY < y && y < maxY;

            if (isRangeX && isRangeY && !shouldNotVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
