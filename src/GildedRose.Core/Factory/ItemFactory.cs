using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;
using GildedRose.Core.ItemFactories;

namespace GildedRose.Core.Factory;

public class ItemFactory : IItemFactory
{
    public IUpdateItemFactory InitializeItem(Item? item)
    {
        if (item != null)
            return item.Name switch
            {
                Constants.AgedBrie => new AgedBrieFactory(),
                Constants.BackStagePasses => new BackStagePassesFactory(),
                Constants.Sulfuras => new SulfurasFactory(),
                Constants.Conjured => new ConjuredItemsFactory(),
                _ => new StandardItemsFactory()
            };
        throw new ArgumentNullException(nameof(item));

    }
}