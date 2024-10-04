using GildedRose;
using GildedRose.Entities;
using GildedRose.ItemFactories;
using Xunit;

namespace GildedRoseTests.ItemFactoryTests
{
    public class ConjuredItemsFactoryTest : BaseTest
    {
        protected Item Item { get; set; }

        public ConjuredItemsFactoryTest()
        {
            Item = new Item() { Name = Constants.Conjured, SellIn = 3, Quality = 6 };
        }

        [Fact]
        public void Factory_ConjuredItems_Instantiation_Success()
        {
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<ConjuredItemsFactory>(UpdateItemObj);
        }

        [Theory]
        [InlineData(10, 0, 8)]
        public void Factory_ConjuredItems_QualityDecreaseByTwiceAsSellDatePasses(int quality, int sellin, int expectedQuality)
        {
            Item = new Item()
            {
                Name = Constants.Conjured,
                SellIn = sellin,
                Quality = quality
            };
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            UpdateItemObj.UpdateQuality(Item);
            Assert.Equal(expectedQuality, Item.Quality);
        }
    }
}
