using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class GildedRose
    {
        List<ItemAbstract> myItems;

        public GildedRose()
        {
            myItems = new List<ItemAbstract>();
        }

        public void addItem(ItemAbstract newItem)
        {
            if (!(newItem is Sulfuras))
                if (newItem.ItemQuality > 50)
                    newItem.ItemQuality = 50;
            myItems.Add(newItem);
        }

        public void updateQuality()
        {
            foreach(var item in myItems)
            {
                item.updateQuality();
            }
        }
    }
}
