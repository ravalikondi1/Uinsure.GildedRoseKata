using GildedRose;
using GildedRose.Entities;
using GildedRose.ItemFactories;
using Xunit;

namespace GildedRoseTests.ItemFactoryTests
{
    public class AgedBrieFactoryTest : BaseTest
    {
        protected Item Item { get; set; }

        [Fact]
        public void Factory_AgedBrie_Instantiation_Success()
        {
            Item = new Item() { Name = Constants.AgedBrie, SellIn = 2, Quality = 0 };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<AgedBrieFactory>(UpdateItemObj);
        }

        [Theory]
        [InlineData(15, 12, 16)]
        [InlineData(12, 20, 13)]
        public void Factory_AgedBrie_QualityIncreaseEachDay(int quality, int sellin, int expectedQuality)
        {
            Item = new Item() { Name = Constants.AgedBrie, SellIn = sellin, Quality = quality };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
        }

        [Theory]
        [InlineData(50, 10, 50)]
        public void Factory_AgedBrie_QualityNotGreaterThan50(int quality, int sellin, int expectedQuality)
        {
            Item = new Item() { Name = Constants.AgedBrie, SellIn = sellin, Quality = quality };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
            Assert.True(Item.Quality <= 50);
        }
    }
}
