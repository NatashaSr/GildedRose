using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class BackstagePasses: ItemAbstract
    {
        public BackstagePasses(String name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public override void updateQuality()
        {
            ItemSellIn = ItemSellIn - 1;

            if (ItemSellIn > 10)
                ItemQuality += 1;
            if (ItemSellIn <= 10 && ItemSellIn > 5)
                ItemQuality = ItemQuality * 2;
            if (ItemSellIn <= 5 && ItemSellIn > 0)
                ItemQuality = ItemQuality * 3;

            if (ItemQuality > 50)
                ItemQuality = 50;

            if (ItemSellIn <= 0)
                ItemQuality = 0;

            Console.WriteLine("I am BackstagePasses, my current quality is: " + ItemQuality + " and my current sell in is: " + ItemSellIn);
        }
    }
}
