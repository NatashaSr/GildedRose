using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class Conjured: ItemAbstract
    {
        public Conjured(String name, int sellIn, int quality) : base(name, sellIn, quality){ }
        public override void updateQuality()
        {

            ItemSellIn = ItemSellIn - 1;

            if (ItemSellIn >= 0)
                ItemQuality = ItemQuality - 2;
            else
                ItemQuality = ItemQuality - 4;

            if (ItemQuality < 0)
                ItemQuality = 0;

            
            Console.WriteLine("I am Conjured, my current quality is: " + ItemQuality + " and my current sell in is: " + ItemSellIn);
        }
    }
}
