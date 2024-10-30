using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal class Class1
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Parallelogram : Shape
        {
            double A;
            double H;

            public Parallelogram(double a, double h)
            {
                A = a;
                H = h;
            }

            public override double GetArea()
            {
                return A * H;
            }
        }

        public class Trapezium : Shape
        {
            public double C;
            public double D;
            public double H;

            public Trapezium(double c, double d, double h)
            {
                C = c;
                D = d;
                H = h;
            }

            public override double GetArea()
            {
                return 0.5 * (C + D) * H;
            }
        }
    }
}
