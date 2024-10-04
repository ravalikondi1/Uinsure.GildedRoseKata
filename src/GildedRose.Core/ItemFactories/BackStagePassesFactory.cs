using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;

namespace GildedRose.Core.ItemFactories;

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
            switch (item.SellIn, item.Quality)
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