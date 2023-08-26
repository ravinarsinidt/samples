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
            Task<string> t1 = GetDataFromFile();
            Task<string> t2 = GetDataFromDatabase();
            Console.WriteLine("T1 and T2 Completed");
            string s = await t1;
            s += await t2;
            Task<string> t3 = Validate();
            s += await t3;
            Task<string> t4 = ProcessPayments();
            Task<string> t5 = SendReport();
            s += await t4;
            s += await t5;
            stopwatch.Stop();
            Console.WriteLine(s);
            Console.WriteLine("Time Taken : " + (stopwatch.ElapsedMilliseconds));
        }

        public static async Task<string> GetDataFromFile()
        {
            Console.WriteLine("Data reading started from File...");
            await Task.Delay(4000);
            Console.WriteLine("Data ready from File.");
            return "File Data Ready";
        }

        public async static Task<string> GetDataFromDatabase()
        {
            Console.WriteLine("Data reading started from DB...");
            await Task.Delay(4000);

            Console.WriteLine("Data ready from DB.");
            return "DB Data";
        }

        public async static Task<string> Validate()
        {
            Console.WriteLine("Data Validation started..");
            await Task.Delay(2000);

            Console.WriteLine("Data Validation completed");
            return "Validation Complted";
        }

        public async static Task<string> ProcessPayments()
        {
            Console.WriteLine("Process Payments started..");
            await Task.Delay(3000);

            Console.WriteLine("Process Payments complted");
            return "Process complted";
        }

        public async static Task<string> SendReport()
        {
            Console.WriteLine("Sending report to customer....");
            await Task.Delay(2000);

            Console.WriteLine("Report sent!");
            return "Sent REport";
        }
    }
}
