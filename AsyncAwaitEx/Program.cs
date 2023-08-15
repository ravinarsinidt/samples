using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitEx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AsyncAwaitAsyncSample.ProcessCustomerPayments();
        }

        static async Task TeaSample(string[] args)
        {
            Program p = new Program();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await p.MakeTea();
            stopwatch.Stop();
            Console.WriteLine("Time Taken : " + stopwatch.Elapsed);
        }

        public async Task MakeTea()
        {
            Task<string> t = BoilWater();
            Console.WriteLine("Take cups from cupboard");
            Task.Delay(2000).Wait();
            Console.WriteLine("Clean Cups");
            Thread.Sleep(2000);
            string water = await t;
            Console.WriteLine($"Add tea bags in to {water}");
            Task.Delay(2000).Wait();
            Console.WriteLine("Tea is ready");
            Task.Delay(2000).Wait();
            Console.WriteLine("Pour into cups");
            Task.Delay(2000).Wait();
            Console.WriteLine("Serve tea");
        }

        public async Task<string> BoilWater()
        {
            Console.WriteLine("Added water in to Kettle");
            Console.WriteLine("Kettle switched on.. Boiling started");
            await Task.Run(() => 
            { 
                for(int  i = 0; i < 10000000; i++)
                {
                    
                }
            });
            Console.WriteLine("Boiling completed and water ready");
            return "boiled water";
        }
    }
}
