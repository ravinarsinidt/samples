using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateEx2
{
    class Program
    {
        // Declare Delegate
        public delegate int Mydelegate(int a, int b);
        public delegate void MyNewDelegate(int a);

        static void Main(string[] args)
        {
            Action<int> myAction = Print; // (item) => Console.WriteLine(item);
            Func<int, bool> myFunc = IsGreaterThan5;
            List<int> mydata = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};
            //Create Delegate Variable and Pass it to below fucntion.
            mydata.ForEach(myAction);
            List<int> result = mydata.Where(myFunc).ToList();
            Console.WriteLine("After Filter: Where");
            result.ForEach(myAction);
        }

        public static bool IsGreaterThan5(int i)
        {
            return (i > 5);
        }

        public static void Print(int i)
        {
            Console.WriteLine(i);
        }

        // Create Function
        public static int Sum(int a, int b)
        {
            return a + b;
        }



        public static void DelegateExCode()
        {
            Func<int, int, int> sumDelegate = Sum;
            Mydelegate sumDelegate1 = new Mydelegate(Sum);

            Func<int, int, int> diffDelegate = Diff;
            Func<int, int, int> divDelegate = Div;

            Console.WriteLine("Del1-Sum: " + sumDelegate(1, 2));
            Console.WriteLine("Del2-Diff: " + diffDelegate(1, 2));
            Console.WriteLine("Del3.Div: " + divDelegate(1, 2));

            Console.WriteLine("Passing Delegate: " + RunDelegate(2, 3, divDelegate));

            Console.WriteLine("Hello World!");
        }

        public static int RunDelegate(int x, int y, Func<int, int, int> del)
        {
            // Do somthing
            int result = del(x, y);
            // do somethig
            return result;
        }

        public static long Mul(int a, int b)
        {
            return a + b;
        }

        

        public static int Diff(int a, int b)
        {
            return a - b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}
