using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            p.MakeTea();
            stopwatch.Stop();
            Console.WriteLine("Time Taken : " +  stopwatch.Elapsed);
        }

        public void MakeTea()
        {
            // get Boil Water // 5 - 6 min task
            ThreadStart st = new ThreadStart(BoilWater);
            Thread t1 = new Thread(st);
            t1.Start();
            //string water = BoilWater();
            Console.WriteLine("Take cups from cupboard");
            Task.Delay(2000).Wait();
            Console.WriteLine("Clean Cups");
            //Task.Delay(2000).Wait();
            Thread.Sleep(2000);
            t1.Join();
            Console.WriteLine($"Add tea bags in to boiled {output}");
            Task.Delay(2000).Wait();
            Console.WriteLine("Tea is ready");
            Task.Delay(2000).Wait();
            Console.WriteLine("Pour into cups");
            Task.Delay(2000).Wait();
            Console.WriteLine("Serve tea");
        }

        public void BoilWater()
        {
            Console.WriteLine("Added water in to Kettle");
            Console.WriteLine("Kettle switched on.. Boiling started");
            Task.Delay(10000).Wait(); 
            Console.WriteLine("Boiling completed and water ready");
        }
    }
}
