using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class Order
    {
        public int Number { get; set; }
        public Cart Cart { get; set; }
        public string Address { get; set; }
        public void PlaceOrder()
        {
            Console.WriteLine($"Order placed!");
        }
    }
}
