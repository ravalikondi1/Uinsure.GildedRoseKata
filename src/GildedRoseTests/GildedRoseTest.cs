﻿using GildedRose.Console;
using GildedRose.Console.Entities;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.UnitTests
{
    public class GildedRoseTest : BaseTest
    {
        [Fact]
        public void GildedRoseTest_Success()
        {
            List<Item> items = [new() { Name = "Item1", SellIn = 0, Quality = 0 }];
            GildedRoseService app = new(ItemFactory);
            app.UpdateQuality(items);
            Assert.Equal("Item1", items[0].Name);
            Assert.True(items[0].Quality >= 0);
        }
    }
}