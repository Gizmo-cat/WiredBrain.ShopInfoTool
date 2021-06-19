using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrain.ShopInfoTool
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private IEnumerable<CoffeeShop> coffeeShops;

        public HelpCommandHandler(IEnumerable<CoffeeShop> coffeeShops)
        {
            this.coffeeShops = coffeeShops;
            //comment
            //comment2
        }

        public void HandleCommand()
        {
            Console.WriteLine("Write 'help' to list available coffee shop commands:");
            foreach (var coffeeShop in coffeeShops)
            {
                Console.WriteLine($"> {coffeeShop.Location}"); ;
            }
        }
    }
}