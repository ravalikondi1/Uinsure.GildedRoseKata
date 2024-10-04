using GildedRose.Factory;
using GildedRose.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace GildedRoseTests
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseTest
    {
        protected IItemFactory ItemFactory = new ItemFactory();
        protected IUpdateItemFactory UpdateItemObj;
    }
}
