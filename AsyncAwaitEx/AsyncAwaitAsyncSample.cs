using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitEx
{
    public class AsyncAwaitSyncSample
    {
        public static void ProcessCustomerPayments()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetDataFromFile();
            GetDataFromDatabase();
            Validate();
            ProcessPayments();
            SendReport();
            stopwatch.Stop();
            Console.WriteLine("Time Taken : " + (stopwatch.ElapsedMilliseconds/1000));
        }

        public async static Task<string> GetDataFromFile()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Data reading started from File...");
                Thread.Sleep(5000);
                Console.WriteLine("Data ready from File.");
            });
            return "File Data";
        }

        public static string GetDataFromDatabase()
        {
            Console.WriteLine("Data reading started from DB...");
            Thread.Sleep(5000);
            Console.WriteLine("Data ready from DB.");
            return "DB Data";
        }

        public static string Validate()
        {
            Console.WriteLine("Data Validation started..");
            Thread.Sleep(2000);
            Console.WriteLine("Data Validation completed");
            return "Validation Complted";
        }

        public static string ProcessPayments()
        {
            Console.WriteLine("Process Payments started..");
            Thread.Sleep(10000);
            Console.WriteLine("Process Payments complted");
            return "Process complted";
        }

        public static string SendReport()
        {
            Console.WriteLine("Sending report to customer....");
            Thread.Sleep(2000);
            Console.WriteLine("Report sent!");
            return "Sent REport";
        }
    }
}
