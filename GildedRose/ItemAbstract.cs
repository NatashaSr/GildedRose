using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    abstract class ItemAbstract : Item
    {
        public ItemAbstract(String name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public abstract void updateQuality();
    }
}
