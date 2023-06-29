using System;
using System.Collections.Generic;

namespace InterfaceEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDataExtender data = new AccountExtender();
            //data.Get("100");
            //data.Save("100", "200");
            //data.Update("500", "400");
            //data.Delete("100");           
            //data.NewMethod();

            ITestA testA = new Test();
            testA.A();
            ITestB testB = new Test();
            testB.A();
        }
    }
}

