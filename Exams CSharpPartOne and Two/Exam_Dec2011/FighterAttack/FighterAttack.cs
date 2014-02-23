using System;

namespace FighterAttack
{
    class FighterAttack
    {
        static void Main()
        {
            int px1 = int.Parse(Console.ReadLine());
            int py1 = int.Parse(Console.ReadLine());
            int px2 = int.Parse(Console.ReadLine());
            int py2 = int.Parse(Console.ReadLine());
            int fx = int.Parse(Console.ReadLine());
            int fy = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int missleCenterX = fx + d;
            int missleCenterY = fy;
            int missleUpperX = fx + d;
            int missleUpperY = fy + 1;
            int missleDownX = fx + d;
            int missleDownY = fy - 1;
            int missleFrontX = fx + d + 1;
            int missleFrontY = fy;
            int totalDamage = 0;
            int tempy = py2;
            int tempx = px2;
            if (py1 < py2)
            {
                py2 = py1;
                py1 = tempy;
            }

            if (px2 < px1)
            {
                px2 = px1;
                px1 = tempx;
            }

            if (missleCenterX >= px1 && missleCenterX <= px2 && missleCenterY >= py2 && missleCenterY <= py1)
            {
                totalDamage += 100;
            }
            if (missleDownX >= px1 && missleDownX <= px2 && missleDownY >= py2 && missleDownY <= py1)
            {
                totalDamage += 50;
            }
            if (missleUpperX >= px1 && missleUpperX <= px2 && missleUpperY >= py2 && missleUpperY <= py1)
            {
                totalDamage += 50;
            }
            if (missleFrontX >= px1 && missleFrontX <= px2 && missleFrontY >= py2 && missleFrontY <= py1)
            {
                totalDamage += 75;
            }

            Console.WriteLine("{0}%", totalDamage);
        }
    }
}
