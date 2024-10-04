using GildedRose.Console.Factory;
using GildedRose.Console.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace GildedRose.UnitTests
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseTest
    {
        protected IItemFactory ItemFactory = new ItemFactory();
        protected IUpdateItemFactory UpdateItemObj;
    }
}
