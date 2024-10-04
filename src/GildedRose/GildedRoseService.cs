using System.Collections.Generic;
using System.Text;
using GildedRose.Core.Entities;
using GildedRose.Core.Factory;
using GildedRose.Core.Interfaces;

namespace GildedRose.Console;

public class GildedRoseService(IItemFactory itemFactory) : IGildedRose
{
    public string UpdateQuality(List<Item> items)
    {
        StringBuilder sb = new();
        foreach (var item in items)
        {
            sb.AppendLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
            var updateItem = itemFactory.InitializeItem(item);
            updateItem.UpdateQuality(item);
        }
        return sb.ToString();
    }
}