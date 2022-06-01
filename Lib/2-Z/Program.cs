using System;


namespace _2_Z
{
    using BreadLib;
    class Program
    {
        static void Main(string[] args)
        {
            Bread[] bread = new Bread[2];
            bread[0] = new Bread.WhiteBread("Пшеничная", 1.24);
            bread[1] = new Bread.BlackBread("Ржаная", 1.04);
            foreach (Bread elem in bread)
            {
                elem.Opisanie();
            }
            Console.ReadLine();
        }
    }
}
