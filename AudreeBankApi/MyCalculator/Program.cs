using System;

namespace MyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            log.Error("Hi");

            //CalculatorTest.TestAdd();
        }
    }
}
