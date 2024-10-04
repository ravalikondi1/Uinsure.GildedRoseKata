using GildedRose.Console;
using GildedRose.Console.Entities;
using GildedRose.Console.ItemFactories;
using Xunit;

namespace GildedRose.UnitTests.ItemFactoryTests
{
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
}
