using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    internal class Employee : IData
    {
        public int Delete(string key)
        {
            Console.WriteLine("Employee: Deleted Key = " + key);
            return 1;
        }

        public int Get(string key)
        {
            Console.WriteLine("Employee: Get Successful");
            return 100;
        }

        public void Save(string key, string value)
        {
            Console.WriteLine($"Employee: Saved {key} and {value}");            
        }

        public int Update(string key, string value)
        {
            Console.WriteLine($"Employee: Updated {key} and {value}");
            return 10;
        }
    }
}
