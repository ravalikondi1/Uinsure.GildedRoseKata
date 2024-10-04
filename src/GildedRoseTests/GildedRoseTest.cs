using GildedRose.Entities;
using GildedRose.Interfaces;
using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest : BaseTest
    {
        [Fact]
        public void GildedRoseTest_Success()
        {
            List<Item> Items = [new Item { Name = "Item1", SellIn = 0, Quality = 0 }];
            IGildedRose app = new GildedRoseService(ItemFactory);
            app.UpdateQuality(Items);
            Assert.Equal("Item1", Items[0].Name);
            Assert.True(Items[0].Quality >= 0);
        }
    }
}
