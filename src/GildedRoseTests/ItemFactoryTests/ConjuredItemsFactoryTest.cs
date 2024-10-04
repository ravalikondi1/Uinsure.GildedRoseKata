using GildedRose.Console;
using GildedRose.Console.Entities;
using GildedRose.Console.ItemFactories;
using Xunit;

namespace GildedRose.UnitTests.ItemFactoryTests
{
    public class ConjuredItemsFactoryTest : BaseTest
    {
        protected Item Item { get; set; } = new() { Name = Constants.Conjured, SellIn = 3, Quality = 6 };

        [Fact]
        public void Factory_ConjuredItems_Instantiation_Success()
        {
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<ConjuredItemsFactory>(UpdateItemObj);
        }

        [Theory]
        [InlineData(10, 0, 8)]
        public void Factory_ConjuredItems_QualityDecreaseByTwiceAsSellDatePasses(int quality, int sellIn, int expectedQuality)
        {
            Item = new Item()
            {
                Name = Constants.Conjured,
                SellIn = sellIn,
                Quality = quality
            };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
        }
    }
}
