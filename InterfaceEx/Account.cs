using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class Account : IData
    {
        public int Delete(string key)
        {
            Console.WriteLine("Account: Deleted Key = " + key);
            return 20;
        }

        public int Get(string key)
        {
            Console.WriteLine("Account: Get Successful");
            return 22222;
        }

        public void Save(string key, string value)
        {
            Console.WriteLine($"Account: Saved {key} and {value}");
        }

        public int Update(string key, string value)
        {
            Console.WriteLine($"Account: Updated {key} and {value}");
            return 30;
        }
    }
}
