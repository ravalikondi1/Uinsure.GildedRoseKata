using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;

namespace GildedRose.Core.ItemFactories;

public class AgedBrieFactory : IUpdateItemFactory
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        if (item.Quality >= 50) return;
        item.Quality++;

        if (item is { SellIn: < 0, Quality: < 50 })
        {
            item.Quality++;
        }
    }
}