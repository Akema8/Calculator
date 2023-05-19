using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : Figure
    {
        public double R { get; set; }


        public Circle(double radius)
        {
            R = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(R, 2);

    }
}
