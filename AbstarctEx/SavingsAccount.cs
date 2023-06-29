using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctEx
{
    public class SavingsAccount : Account
    {
        public override int YourAdd(int i, int j)
        {
            return i + j + 100;
        }
    }
}
