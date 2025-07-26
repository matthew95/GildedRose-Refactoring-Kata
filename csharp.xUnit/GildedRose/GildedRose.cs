using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in this.Items)
        {
            if (item.Quality > 0 &&
                item.Name != "Sulfuras, Hand of Ragnaros" &&
                item.Name != "Aged Brie" && 
                item.Name != "Backstage passes to a TAFKAL80ETC concert"
                )
            {
                item.Quality = item.Quality - 1;
            }

            if (item.Name == "Aged Brie" && item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
            
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.Quality < 50) {
                item.Quality = item.Quality + 1;
                
                if (item.SellIn < 11 &&
                    item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                if (item.SellIn < 6 &&
                    item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                    
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
                        item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        if (item.Quality > 0)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                if (item.Name == "Aged Brie")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}