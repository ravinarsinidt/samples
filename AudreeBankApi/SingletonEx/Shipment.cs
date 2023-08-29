using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class Shipment
    {
        public static bool ShipPackage(string package, string address)
        {
            Console.WriteLine($"Pacage Shipped to {address}");
            return true;
        }
    }
}
