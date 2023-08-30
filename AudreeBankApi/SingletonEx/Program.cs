using System;

namespace SingletonEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart { Item = "TV", Count = 4 };
            cart.PrintCart();
            OrderFacade.PlaceOrderAndShip(cart, "vizag");
        }

        private static void FactoryTest()
        {
            string type = Console.ReadLine();
            Vehicle v = FactoryPattern.CreateVehicle(type);
        }
    }
}
