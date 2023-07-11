using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEx
{
    public class PublicCalculator
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Sum(int x, int y)
        {
            InternalCalculator ic = new InternalCalculator();
            return ic.Sum(x, y);
        }
    }
}
