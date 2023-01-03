using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample.Inheritance
{
    public class Square : Shape
    {
        public Square(double lenght) {
            Side = lenght;
        }
        public double Side { get; }

        public override double Area => Math.Pow(Side, 2);

        public override double Perimeter => Side * 4;
        public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
    }
}
