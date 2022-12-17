using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrallarniHisoblash
{
    internal class IntegralHisobla
    {
        public class Integral_xn
        {
            double n, a, b;
            public Integral_xn(double n, double a, double b) 
            {
                this.a = a;
                this.b = b;
                this.n = n;
            }
            
        }
        public class Integral_sinkx
        {
            public Integral_sinkx() { }
            public double hisobla(double k, double a, double b)
            {
                return -1.0 / k * (Math.Cos(k * b) - Math.Cos(k * a));
            }
        }
    }
}
