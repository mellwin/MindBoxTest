using System;

namespace Test1
{
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidOperationException("Значение стороны не может быть отрицательным или равным нулю");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = CalculateSemiPerimeter();

            if (!IsPossible())
            {
                throw new InvalidOperationException($"Треугольник со сторонами {a}, {b}, {c} невозможно построить");
            }

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool IsRectangular()
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public string TriangleType()
        {
            if (IsRectangular()) return "прямоугольный";
            else return "не прямоугольный";
        }

        private bool IsPossible()
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        private double CalculateSemiPerimeter()
        {
            return (a + b + c) / 2;
        }
    }
}