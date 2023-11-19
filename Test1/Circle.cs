using System;

namespace Test1
{
    public class Circle : Figure
    {
        double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new InvalidOperationException("Отрицательного радиуса не существует");
            }
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}