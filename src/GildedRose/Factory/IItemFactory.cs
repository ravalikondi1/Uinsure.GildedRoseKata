using GildedRose.Console.Entities;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.Factory
{
    public interface IItemFactory
    {
        IUpdateItemFactory InitializeItem(Item item);
    }
}
