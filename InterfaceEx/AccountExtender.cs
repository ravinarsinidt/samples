using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class AccountExtender : Account, IDataExtender
    {
        public void NewMethod()
        {
            Console.WriteLine("Externder : New Mrthod");
        }
    }
}
