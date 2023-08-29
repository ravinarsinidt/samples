using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class Warehouse
    {
        public static string GetItems(Order order)
        {
            Console.WriteLine($"Items : {order.Cart.Item} selected from this warehose");
            return order.Cart.Item;
        }
    }
}
