using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class Sulfuras: ItemAbstract
    {
        public Sulfuras(String name, int sellIn, int quality) : base(name, sellIn , 80) { }
        public override void updateQuality()
        {
            //ItemQuality = 80;
            //And never decreases in SellIn
            Console.WriteLine("I am Sulfuras, my current quality is: "+ ItemQuality + " and my current sell in is: " + ItemSellIn);
        }
    }
}
