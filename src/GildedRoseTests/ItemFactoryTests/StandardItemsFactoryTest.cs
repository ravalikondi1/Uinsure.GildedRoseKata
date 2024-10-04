using GildedRose.Core;
using GildedRose.Core.Entities;
using GildedRose.Core.ItemFactories;
using Xunit;

namespace GildedRose.UnitTests.ItemFactoryTests;

public class StandardItemsFactoryTest : BaseTest
{
    protected Item Item { get; set; } = new() { Name = Constants.DexterityVest, SellIn = 10, Quality = 20 };

    [Fact]
    public void Factory_StandardItems_Instantiation_Success()
    {
        UpdateItemObj = ItemFactory.InitializeItem(Item);
        Assert.IsType<StandardItemsFactory>(UpdateItemObj);
    }
}