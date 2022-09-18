using Run;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class Circle : IShape
    {
        private double Radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус круга не может быть меньше нуля");

            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}
