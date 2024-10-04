using GildedRose.Entities;
using GildedRose.Interfaces;

namespace GildedRose.ItemFactories
{
    public class StandardItemsFactory : IUpdateItemFactory
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0)
            {
                item.Quality--;

                if (item.SellIn < 0 && item.Quality > 0)
                {
                    item.Quality--;
                }
            }
        }
    }
}
