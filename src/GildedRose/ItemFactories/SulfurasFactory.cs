using GildedRose.Entities;
using GildedRose.Interfaces;

namespace GildedRose.ItemFactories
{
    public class SulfurasFactory : IUpdateItemFactory
    {
        public void UpdateQuality(Item item)
        {
            //"Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.
        }
    }
}
