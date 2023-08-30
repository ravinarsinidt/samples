using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonEx
{
    public class OrderFacade
    {
        public static void PlaceOrderAndShip(Cart cart, string address)
        {
            Order order = new Order { Cart = cart, Address = address, Number = 1 };
            order.PlaceOrder();
            string item = Warehouse.GetItems(order);
            string packedItem = Package.PackItems(item);
            Shipment.ShipPackage(packedItem, order.Address);
        }
    }
}
