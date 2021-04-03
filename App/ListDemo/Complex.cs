using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public Complex(double re = 0, double im = 0)
        {
            Re = re;
            Im = im;
        }

        public override string ToString()
        {
            return $"{Re} + {Im}";
        }
    }
}
