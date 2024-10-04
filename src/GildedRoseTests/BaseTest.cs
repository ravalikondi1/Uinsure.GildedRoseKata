using System.Diagnostics.CodeAnalysis;
using GildedRose.Core.Factory;
using GildedRose.Core.Interfaces;

namespace GildedRose.UnitTests;

[ExcludeFromCodeCoverage]
public abstract class BaseTest
{
    protected IItemFactory ItemFactory = new ItemFactory();
    protected IUpdateItemFactory UpdateItemObj;
}