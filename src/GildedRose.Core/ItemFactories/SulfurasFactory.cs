using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;

namespace GildedRose.Core.ItemFactories;

public class SulfurasFactory : IUpdateItemFactory
{
    public void UpdateQuality(Item item)
    {
        //"Sulfuras" is a legendary item. Its Quality is 80 and it never alters.
    }
}