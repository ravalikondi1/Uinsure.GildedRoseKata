using GildedRose.Entities;
using GildedRose.Interfaces;

namespace GildedRose.ItemFactories
{
    public class BackStagePassesFactory : IUpdateItemFactory
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.Quality < 50)
            {
                item.Quality++;
                if (item.SellIn < 5 && item.Quality < 50)
                {
                    item.Quality += 2;
                }
                else if (item.SellIn < 10 && item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }
    }
}
