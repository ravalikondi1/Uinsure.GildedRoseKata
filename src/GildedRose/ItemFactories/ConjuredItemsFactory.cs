﻿using GildedRose.Console.Entities;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.ItemFactories
{
    public class ConjuredItemsFactory : IUpdateItemFactory
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if (item.Quality > 0)
            {
                item.Quality--;

                if (item.SellIn < 0 && item.Quality > 0)
                {
                    item.Quality--;
                }
            }
        }
    }
}
