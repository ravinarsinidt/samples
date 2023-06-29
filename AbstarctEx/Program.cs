using System;

namespace AbstarctEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount();

            int sum = account.Add(10, 20);
            int sum1 = account.YourAdd(10, 20);
            Console.WriteLine("Base Class Account Implmentation of Add: " + sum);
            Console.WriteLine("Class SavingsAccount Implmentation of YourAdd: " + sum1);
        }
    }
}
