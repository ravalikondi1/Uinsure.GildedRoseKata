using GildedRose.Entities;
using GildedRose.Factory;
using GildedRose.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRoseService(IItemFactory itemFactory) : IGildedRose
    {
        public string UpdateQuality(List<Item> Items)
        {
            StringBuilder sb = new();
            foreach (var item in Items)
            {
                sb.AppendLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
                var updateItem = itemFactory.InitializeItem(item);
                updateItem.UpdateQuality(item);
            }
            return sb.ToString();
        }
    }
}
