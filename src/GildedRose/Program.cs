using GildedRose;
using GildedRose.Entities;
using GildedRose.Factory;
using GildedRose.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            ServiceProvider serviceProvider = RegisterServices();

            var service = serviceProvider.GetService<IGildedRose>();

            List<Item> Items = GetDefaultInventoryDetails();

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                var output = service.UpdateQuality(Items);
                Console.WriteLine(output);
            }
        }

        private static ServiceProvider RegisterServices()
        {
            //setup our DI
            return new ServiceCollection()
                .AddSingleton<IItemFactory, ItemFactory>()
                .AddSingleton<IGildedRose, GildedRoseService>()
            .BuildServiceProvider();
        }

        private static List<Item> GetDefaultInventoryDetails()
        {
            List<Item> Items = [
                new() {Name = Constants.DexterityVest, SellIn = 10, Quality = 20},
                new() {Name = Constants.AgedBrie, SellIn = 2, Quality = 0},
                new() {Name = Constants.Elixir, SellIn = 5, Quality = 7},
                new() {Name = Constants.Sulfuras, SellIn = 0, Quality = 80},
                new() {Name = Constants.Sulfuras, SellIn = -1, Quality = 80},
                new()
                {
                    Name = Constants.BackStagePasses,
                    SellIn = 15,
                    Quality = 20
                },
                new()
                {
                    Name = Constants.BackStagePasses,
                    SellIn = 10,
                    Quality = 49
                },
                new()
                {
                    Name = Constants.BackStagePasses,
                    SellIn = 5,
                    Quality = 49
                },
                new() {Name = Constants.Conjured, SellIn = 3, Quality = 6}
                ];
            return Items;
        }
    }
}
