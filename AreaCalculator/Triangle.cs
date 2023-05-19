using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AreaCalculator
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Triangle(double ab, double bc, double ca)
        {
            // Проверка допустимости значений
            if (((ab + bc) > ca) && ((bc + ca) > ab) && ((ab + ca) > bc))
            {
                A = ab;
                B = bc;
                C = ca;
            }
            else
            {
                throw new Exception("Некорректные значения размеров сторон");
            }
        }

        public override double CalculateArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool CheckRightTriangle()
        {
            double cat1 = A, cat2 = B, hyp = C;
            hyp = Math.Max(A, Math.Max(B, C));
            cat1 = Math.Min(A, Math.Min(B, C));
            cat2 = A + B + C - hyp - cat1;

            return Math.Pow(hyp, 2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2);
        }

    }
}
