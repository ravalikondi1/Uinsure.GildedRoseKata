using GildedRose.Core.Entities;
using GildedRose.Core.Interfaces;

namespace GildedRose.Core.Factory;

public interface IItemFactory
{
    IUpdateItemFactory InitializeItem(Item? item);
}