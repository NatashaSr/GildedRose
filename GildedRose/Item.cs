using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class Item
    {
        public String ItemName { get; set; }
        public int ItemSellIn { get; set; }
        public int ItemQuality { get; set; }

        public Item(String name, int sellIn, int quality)
        {
            ItemName = name;
            ItemSellIn = sellIn;
            ItemQuality = quality;
        }
    }
} 
