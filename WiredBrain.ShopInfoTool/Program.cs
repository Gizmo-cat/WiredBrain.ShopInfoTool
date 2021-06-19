using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrain.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WiredBrain ShopInfoTool 2021 June");

            Console.WriteLine("Write 'help' to list available commands, write 'quit' to exit app");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();
                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Write 'help' to list available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
            }
        }
    }
}
