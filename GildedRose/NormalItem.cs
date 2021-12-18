using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class NormalItem : ItemAbstract
    {
        public NormalItem(String name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public override void updateQuality()
        {
            ItemSellIn = ItemSellIn - 1;

            if (ItemSellIn >= 0)
                ItemQuality = ItemQuality - 1;
            else
                ItemQuality = ItemQuality - 2;

            if (ItemQuality < 0)
                ItemQuality = 0;

            Console.WriteLine("I am NormalItem, my current quality is: " + ItemQuality + " and my current sell in is: " + ItemSellIn);
        }
    }
}
