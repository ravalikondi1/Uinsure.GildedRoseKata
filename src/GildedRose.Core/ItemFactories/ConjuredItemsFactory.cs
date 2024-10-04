using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;

namespace GildedRose.Core.ItemFactories;

public class ConjuredItemsFactory : IUpdateItemFactory
{
    public void UpdateQuality(Item item)
    {
        item.SellIn--;
        if (item.Quality <= 0) return;
        item.Quality--;

        if (item is { SellIn: < 0, Quality: > 0 })
        {
            item.Quality--;
        }
    }
}