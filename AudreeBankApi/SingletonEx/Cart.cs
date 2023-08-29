using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class Cart
    {
        public string Item { get; set; }
        public int Count { get; set; }

        public void PrintCart()
        {
            Console.WriteLine($"Selected : Items = {Item} and Count = {Count}");
        }
    }
}
