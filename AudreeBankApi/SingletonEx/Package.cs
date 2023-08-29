using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class Package
    {
        public static string PackItems(string items)
        {
            Console.WriteLine($"Package completed for selected items {items}");
            return "items packed";
        }
    }
}
