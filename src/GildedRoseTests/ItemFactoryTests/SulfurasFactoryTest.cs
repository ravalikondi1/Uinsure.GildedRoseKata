using GildedRose.Console;
using GildedRose.Console.Entities;
using GildedRose.Console.ItemFactories;
using Xunit;

namespace GildedRose.UnitTests.ItemFactoryTests
{
    public class SulfurasFactoryTest : BaseTest
    {
        protected Item Item { get; set; } = new() { Name = Constants.Sulfuras, SellIn = 0, Quality = 80 };

        [Fact]
        public void Factory_Sulfuras_Instantiation_Success()
        {
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<SulfurasFactory>(UpdateItemObj);
        }

        [Fact]
        public void Factory_Sulfuras_QualityNotDegrading()
        {
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.Equal(80, Item.Quality);
        }
    }
}
