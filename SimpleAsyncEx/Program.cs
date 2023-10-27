using System;
using System.Threading.Tasks;

namespace SimpleAsyncEx
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main Started!");
            Task<string> fileDataTask = GetDataFromFile();
            Task<string> dbDataTask = GetDataFromDatabase();
            Console.WriteLine("Main Ended!");
            // some logic
            string fileData = await fileDataTask;
            string dbData = await dbDataTask;
            Console.WriteLine("Task 1: " + fileData);
            Console.WriteLine("Task 2: " + dbData);
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
    }
}
