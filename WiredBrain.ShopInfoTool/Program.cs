using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WiredBrain.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WiredBrain ShopInfoTool 2021 June");

            Console.WriteLine("Write 'help' to list available commands, write 'quit' anytime to exit application thanks.");

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
                else
                {
                    var foundCoffeeShops = coffeeShops.Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (foundCoffeeShops.Count == 0)
                    { 
                        Console.WriteLine($"> Command '{line}' not found");
                    }
                    else if (foundCoffeeShops.Count == 1)
                    {
                        var coffeeShop = foundCoffeeShops.Single();
                        Console.WriteLine($"> Location: {coffeeShop.Location}");
                        Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} Kg");
                    }
                    else
                    {
                        Console.WriteLine($"> Multiple matching coffee shops found:");
                        foreach(var coffeeType in foundCoffeeShops)
                        {
                            Console.WriteLine($"> Location: {coffeeType.Location}");
                        }
                    }
                }
            }
        }
    }
}
