using GildedRose.Factory;
using GildedRose.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace GildedRoseTests
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseTest
    {
        protected IItemFactory ItemFactory;
        protected IUpdateItemFactory UpdateItemObj;

        protected BaseTest()
        {
            ItemFactory = new ItemFactory();
        }
    }
}
