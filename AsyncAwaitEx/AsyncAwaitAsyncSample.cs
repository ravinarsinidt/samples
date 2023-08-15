using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitEx
{
    public class AsyncAwaitAsyncSample
    {
        public static async Task ProcessCustomerPayments()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task t1 = GetDataFromFile();
            Task t2 = GetDataFromDatabase();
            Console.WriteLine("T1 and T2 Completed");
            await t1;
            await t2;
            Task t3 = Validate();
            await t3;
            Task t4 = ProcessPayments();
            Task t5 = SendReport();
            await t4;
            await t5;
            stopwatch.Stop();
            Console.WriteLine("Time Taken : " + (stopwatch.ElapsedMilliseconds));
        }

        public static async Task GetDataFromFile()
        {
            Task t = Task.Run(() =>
            {
                Console.WriteLine("Data reading started from File...");
                Thread.Sleep(5000);
                Console.WriteLine("Data ready from File.");
                return "Done";
            });

            return t;
        }

        public async static Task GetDataFromDatabase()
        {
            Task t = Task.Run(() =>
            {
                Console.WriteLine("Data reading started from DB...");
                Thread.Sleep(5000);
                Console.WriteLine("Data ready from DB.");
                return "DB Data";
            });
        }

        public async static Task Validate()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Data Validation started..");
                Thread.Sleep(2000);
                Console.WriteLine("Data Validation completed");
                return "Validation Complted";
            });            
        }

        public async static Task ProcessPayments()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Process Payments started..");
                Thread.Sleep(10000);
                Console.WriteLine("Process Payments complted");
                return "Process complted";
            });            
        }

        public async static Task SendReport()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Sending report to customer....");
                Thread.Sleep(2000);
                Console.WriteLine("Report sent!");
                return "Sent REport";
            });            
        }
    }
}
