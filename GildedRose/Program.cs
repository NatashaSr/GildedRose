using System;

namespace GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {
            GildedRose myGildedRose = new GildedRose();
            myGildedRose.addItem(new AgedBrie("aged brie", 50, 50));
            myGildedRose.addItem(new BackstagePasses("BackstagePasses", 50, 50));
            myGildedRose.addItem(new Conjured("Conjured", 50, 50));
            myGildedRose.addItem(new Sulfuras("Sulfuras", 50, 50));

            myGildedRose.updateQuality();
        }
    }
}
