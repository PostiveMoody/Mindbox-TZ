using Run;

namespace Contract
{
    public class Triangle : IShape
    {
        private double A;
        private double B;
        private double C;
        private bool RightTriangle;


        public Triangle(double a, double b, double c)
        {
            // The possibility of the existence of a figure
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Значение стороны треугольника выходит за пределы диапазона допустимых значений");

            if (a + b < c || a + c < b || b + c < a)
                throw new ArithmeticException("Треугольник с сторонами: " + a + "," + b + "," + c + "не существует");

            // Rectangular triangle
            RightTriangle = (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || 
                (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)) ||
                (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) ? true : false;

            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double GetArea()
        {
            double semiperimeter = this.A + this.B + this.C;

            return Math.Sqrt(semiperimeter * (semiperimeter - this.A) * (semiperimeter - this.B) * (semiperimeter - this.C));
        }
    }
}