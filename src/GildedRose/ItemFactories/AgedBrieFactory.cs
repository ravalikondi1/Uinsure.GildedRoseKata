using GildedRose.Console.Entities;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.ItemFactories
{
    public class AgedBrieFactory : IUpdateItemFactory
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.Quality < 50)
            {
                item.Quality++;

                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
    }
}
