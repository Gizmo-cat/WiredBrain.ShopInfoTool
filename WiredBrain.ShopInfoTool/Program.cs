using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrain.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WiredBrain ShopInfoTool 2021 June");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
            }
        }
    }
}
