/// <summary>
/// /start
/// </summary>

namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeeShop
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int BeansInStockInKg { get; set; }
        public int PaperCupsInStock { get; set; }

        public string Monday { get; set; }
        public string Tuesday { get; set; }

        //On main branch and commenting
    }
}
