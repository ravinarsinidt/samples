using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctEx
{
    public abstract class Account
    {
        public int Add(int i, int j)
        {
            return i + j;
        }

        public abstract int YourAdd(int i, int j);
    }
}
