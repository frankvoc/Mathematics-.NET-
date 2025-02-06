using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        public static double CalcArea(double height, double width)
        {
            return height * width;
        }
        public static double CalcAvg(List<double> x)
        {
            return x.Average();
        }
        public static double Squared(double x)
        {
            return x * x;
        }
        public static double CalcPythagorean(double a, double b)
        {
            return Math.Sqrt(Squared(a)+ Squared(b));
        }
    }
}
