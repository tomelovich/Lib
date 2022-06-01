using System;

namespace BreadLib
{
    public abstract class Bread
    {
        public string name;
        public abstract void Opisanie();

        public class WhiteBread : Bread
        {
            string typeFlour;
            double price;
            public WhiteBread(string whiteFlour, double whitePrice)
            {
                typeFlour = whiteFlour;
                price = whitePrice;
            }
            public override void Opisanie()
            {
                Console.WriteLine("Тип муки - {0}, Цена - {1}", typeFlour, price);
            }
        }
        public class BlackBread : Bread
        {
            string typeFlour;
            double price;
            public BlackBread(string blackFlour, double blackPrice)
            {
                typeFlour = blackFlour;
                price = blackPrice;
            }
            public override void Opisanie()
            {
                Console.WriteLine("Тип муки - {0}, Цена - {1}", typeFlour, price);
            }
        }
    }
}
