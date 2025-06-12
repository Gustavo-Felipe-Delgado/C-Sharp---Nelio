using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Triangulo
    {
        public int l1;
        public int l2;
        public int l3;

        public double area()
        {
            double p = (l1 + l2 + l3) / 2;
            double a = Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));

            return a;
        }

    }
}
