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
                ICommandHandler commandHandler = (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
               ? new HelpCommandHandler(coffeeShops)
               : new CoffeeShopCommandHandler(coffeeShops, line);
               
                commandHandler.HandleCommand();
            }
        }
    }
}
