using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class Test : ITestB, ITestA
    {
        void ITestA.A()
        {
            Console.WriteLine("Its ITestA's Implementation");
        }

        public override void A()
        {
            Console.WriteLine("Its ITestB's Implementation");
        }
    }
}
