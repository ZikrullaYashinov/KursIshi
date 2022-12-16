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
            double x_daraja_n;
            double oraliq_a;
            double oraliq_b;
            public Integral_xn(double n, double a, double b)
            {
                this.x_daraja_n = n;
                this.oraliq_a = a;
                this.oraliq_b = b;
            }
            public double hisobla()
            {
                if (x_daraja_n != -1)
                {
                    return 1.0 / (x_daraja_n + 1) * (Math.Pow(oraliq_b, x_daraja_n + 1) - Math.Pow(oraliq_a, x_daraja_n + 1));
                }
                return Math.Log(oraliq_b) - Math.Log(oraliq_a);

            }
        }
        public class Integral_sinkx
        {
            double k;
            double oraliq_a;
            double oraliq_b;
            public Integral_sinkx(double k, double a, double b)
            {
                this.k = k;
                this.oraliq_a = a;
                this.oraliq_b = b;
            }
            public double hisobla()
            {
                return -1.0 / k * (Math.Cos(k * oraliq_b) - Math.Cos(k * oraliq_a));
            }
        }
    }
}
