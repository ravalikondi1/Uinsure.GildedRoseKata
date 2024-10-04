﻿using GildedRose;
using GildedRose.Entities;
using GildedRose.ItemFactories;
using System.Reflection.Metadata;
using Xunit;

namespace GildedRoseTests.ItemFactoryTests
{
    public class StandardItemsFactoryTest : BaseTest
    {
        protected Item Item { get; set; }

        public StandardItemsFactoryTest()
        {
            Item = new Item() { Name = Constants.DexterityVest, SellIn = 10, Quality = 20 };
        }

        [Fact]
        public void Factory_StandardItems_Instantiation_Success()
        {
            UpdateItemObj = ItemFactory.InitializeItem(Item);
            Assert.IsType<StandardItemsFactory>(UpdateItemObj);
        }
    }
}
