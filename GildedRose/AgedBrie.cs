using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class AgedBrie : ItemAbstract
    {
        public AgedBrie(String name, int sellIn, int quality):base(name, sellIn, quality){}
        public override void updateQuality()
        {
            ItemSellIn = ItemSellIn - 1;

            if (ItemQuality<50)
                ItemQuality += 1;

            Console.WriteLine("I am AgedBrie, my current quality is: " + ItemQuality + " and my current sell in is: " + ItemSellIn);
        }
    }
}
