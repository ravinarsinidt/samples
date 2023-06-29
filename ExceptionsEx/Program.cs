using System;
using System.IO;

namespace ExceptionsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            if(int.TryParse("1234", out i))
            {
                Console.WriteLine("Parsed i = " + i);
            }
            else
            {
                Console.WriteLine("Not Parsed i = " + i);
            }
            
            // 1, 5, 7, 9, 3, 4
            string input = null;
            try
            {
                Console.WriteLine("1");
                //Sub1();
                Console.WriteLine("2");
            }
            catch (Exception ex)
            {
                AudreeExption audree = (AudreeExption)ex;
                Console.WriteLine("3");
                Console.WriteLine(audree.ToString());
                Console.WriteLine(audree.AudreeData);
            }
            finally
            {
                Console.WriteLine("4");
            }
        }

        static void Sub1()
        {
            try
            {
                // 100 line
                Console.WriteLine("5");
                Sub2();
                Console.WriteLine("6");
            }
            catch (AudreeExption ex)
            {
                Console.WriteLine("Audree exception handler : " + ex.AudreeData);
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        static void Sub2()
        {

            // 100 lines of code
            int number = int.Parse("1234");
            int number1 = int.Parse("2345");
            int sum = number + number1;
            if(sum != 555)
            {
                AudreeExption newEx = new AudreeExption("My Custom exception: Where Sum is not equal to 555.", 99999);
                throw newEx;
            }            
        }
    }
}
