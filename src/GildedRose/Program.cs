using GildedRose.Console.Entities;
using GildedRose.Console.Factory;
using GildedRose.Console.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace GildedRose.Console
{
    public static class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("OMGHAI!");

            ServiceProvider serviceProvider = RegisterServices();

            var service = serviceProvider.GetService<IGildedRose>();

            List<Item> items = GetDefaultInventoryDetails();

            for (var i = 0; i < 31; i++)
            {
                System.Console.WriteLine("-------- day " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                var output = service.UpdateQuality(items);
                System.Console.WriteLine(output);
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
            List<Item> items = [
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
            return items;
        }
    }
}
