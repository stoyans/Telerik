namespace RefactorTheClass
{
    using System;

    public class Chef
    {
        private Potato GetPotato()
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private void Cut(Vegetable potato)
        {
            //...
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);    
            bowl.Add(potato);
        }
    }
}
