using System;

namespace DelegatesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, string, bool> actionDelegate = ((x, y, z) => { x += 10;  Console.WriteLine(y); Console.WriteLine(x); });
            Func<int, int, bool> funcDeleage = ((x, y) => ((x + y) > 100));
            Func<string, string, bool> funcDeleage = ((x, y) => (x > y));
            Predicate<int> pre = ((x) => x > 10);
            Predicate<string> stringPredicate = ((x) => x.Contains("R"));
            HoleInMiddle(funcDeleage);
        }

        public static void HoleInMiddle(Func<int, int, bool> funcDelegate)
        {
            bool x = funcDelegate(20, 30);
            Console.WriteLine(x);
        }

        public static void HoleInMiddle(Action<int, string, bool> actionDelegateArg)
        {
            actionDelegateArg(20, "Ravi", false);
        }

        public static void HoleInMiddle(Predicate<int> myPredicate)
        {
            bool x = myPredicate(20);
            Console.WriteLine(x);
        }

        public static void HoleInMiddle(Predicate<string> myPredicate)
        {
            bool x = myPredicate("Ravi");
            Console.WriteLine(x);
        }
    }
}
