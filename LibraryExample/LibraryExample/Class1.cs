using System;

namespace LibraryExample
{
    public abstract class Figure
    {
        public string name;
        public abstract string Perimeter();
        public abstract string Square();

        class Triangle : Figure
        {
            public double a, b, c;
            public Triangle(double triangleA, double triangleB, double triangleC)
            {
                a = triangleA;
                b = triangleB;
                c = triangleC;
            }
            public static string TriangleExist(double triangleA, double triangleB, double triangleC)
            {
                string rez;

                if ((triangleA + triangleB > triangleC) & (triangleB + triangleC > triangleA) & (triangleA + triangleC) > triangleB)
                {
                    rez = "треугольник существует";
                }
                else
                {
                    rez = "треугольник не существует";
                }

                return rez;
            }
            public bool Ravnostor(double triangleA, double triangleB, double triangleC)
            {
                bool end = true;
                if (triangleA == triangleB & triangleB == triangleC & triangleA == triangleC)
                { end = true; }
                else
                { end = false; }
                return end;
            }

            public bool Neravnostor(double triangleA, double triangleB, double triangleC)
            {
                bool end = true;
                if (triangleA != triangleB && triangleB != triangleC && triangleA != triangleC)
                { end = true; }
                else
                { end = false; }
                return end;
            }

            public bool Ravnobedr(double triangleA, double triangleB, double triangleC)
            {
                bool end = true;
                if (triangleA == triangleB || triangleB == triangleC || triangleA == triangleC)
                { end = true; }
                else
                { end = false; }
                return end;
            }
            public override string Perimeter()
            {
                return (a + b + c).ToString();
            }
            public override string Square()
            {
                double semPer = (a + b + c) / 2;
                return Math.Sqrt(semPer * (semPer - a) * (semPer - b) * (semPer - c)).ToString();
            }
        }
        class Rectangle : Figure
        {
            public double a, b;
            public Rectangle(double rectangleA, double rectangleB)
            {
                a = rectangleA;
                b = rectangleB;
            }
            public override string Perimeter()
            {
                return (a * 2 + b * 2).ToString();
            }
            public override string Square()
            {
                return (a * b).ToString();
            }
        }
    }
}
