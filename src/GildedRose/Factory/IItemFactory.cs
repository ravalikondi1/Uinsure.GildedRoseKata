using GildedRose.Entities;
using GildedRose.Interfaces;

namespace GildedRose.Factory
{
    public interface IItemFactory
    {
        IUpdateItemFactory InitializeItem(Item item);
    }
}
