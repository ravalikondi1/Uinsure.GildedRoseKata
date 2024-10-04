using GildedRose.Console.Entities;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.ItemFactories
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
                switch ((item.SellIn, item.Quality))
                {
                    case ( < 5, < 50):
                        item.Quality += 2;
                        break;
                    case ( < 10, < 50):
                        item.Quality++;
                        break;
                }
            }
        }
    }
}
