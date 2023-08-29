using System;

namespace SingletonEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart { Item = "TV", Count = 4 };
            cart.PrintCart();
            Order order = new Order { Cart = cart, Address = "Hyderabad", Number = 1 };
            order.PlaceOrder();
            string item = Warehouse.GetItems(order);
            string packedItem = Package.PackItems(item);
            Shipment.ShipPackage(packedItem, order.Address);
        }

        private static void FactoryTest()
        {
            string type = Console.ReadLine();
            Vehicle v = FactoryPattern.CreateVehicle(type);
        }
    }
}
