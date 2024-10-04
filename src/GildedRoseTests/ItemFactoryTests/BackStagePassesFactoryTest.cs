using GildedRose;
using GildedRose.Entities;
using GildedRose.ItemFactories;
using Xunit;

namespace GildedRoseTests.ItemFactoryTests
{
    public class BackStagePassesFactoryTest : BaseTest
    {
        protected Item Item { get; set; }

        [Fact]
        public void Factory_BackStagePasses_Instantiation_Success()
        {
            Item = new Item()
            {
                Name = Constants.BackStagePasses,
                SellIn = 15,
                Quality = 20
            };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<BackStagePassesFactory>(UpdateItemObj);
        }

        [Theory]
        [InlineData(10, 0, 0)]
        public void Factory_BackStagePasses_ItShouldSetQualityToZero(int quality, int sellIn, int expectedQuality)
        {
            Item = new Item()
            {
                Name = Constants.BackStagePasses,
                SellIn = sellIn,
                Quality = quality
            };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
            Assert.True(Item.Quality >= 0);
        }

        [Theory]
        [InlineData(4, 10, 6)]
        [InlineData(6, 5, 9)]
        public void Factory_BackStagePasses_QualityIncreaseByTwoOrThreeBasedOnSellIn(int quality, int sellIn, int expectedQuality)
        {
            Item = new Item()
            {
                Name = Constants.BackStagePasses,
                SellIn = sellIn,
                Quality = quality
            };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
        }
    }
}
