using GildedRose.Entities;
using GildedRose.Interfaces;
using GildedRose.ItemFactories;
using System;

namespace GildedRose.Factory
{
    public class ItemFactory : IItemFactory
    {
        public IUpdateItemFactory InitializeItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            switch (item.Name)
            {
                case Constants.AgedBrie:
                    return new AgedBrieFactory();
                case Constants.BackStagePasses:
                    return new BackStagePassesFactory();
                case Constants.Sulfuras:
                    return new SulfurasFactory();
                case Constants.Conjured:
                    return new ConjuredItemsFactory();
                default:
                    return new StandardItemsFactory();
            }
        }
    }
}
