using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class CalculatorTest
    {
        public static void TestAdd()
        {
            int a = 100;
            int b = 200;
            int extected = 300;
            int actual = SimpleCalculator.Add(a, b);
            if(actual == extected)
            {
                Console.WriteLine("Method Working Correctly");
            }
            else
            {
                Console.WriteLine("Expected and Actual are not same.");
            }

        }
    }
}
