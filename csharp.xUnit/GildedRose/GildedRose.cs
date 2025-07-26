using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }
    private static class ItemNames
    {
        public static string AgedBrie => "Aged Brie";
        public static string BackstagePasses => "Backstage passes to a TAFKAL80ETC concert";
        public static string Conjured => "Conjured Mana Cake";
        public static string ElixirOfTheMongoose => "Elixir of the Mongoose";
        public static string PlusFiveDexterityVest => "+5 Dexterity Vest";
        public static string Sulfuras => "Sulfuras, Hand of Ragnaros";
        
    }

    public void UpdateQuality()
    {
        foreach (var item in this.Items)
        {
            if (item.Name == ItemNames.AgedBrie)
            {
                item.SellIn = item.SellIn - 1;
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
                if (item.SellIn < 0 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
            
            if (item.Name == ItemNames.BackstagePasses)
            {
                if (item.Quality < 50)
                {
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
                
                item.SellIn = item.SellIn - 1;
                
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }
            }

            // will implement this one later. not part of original code.
            if (item.Name == ItemNames.Conjured)
            {
            }

            if (item.Name == ItemNames.ElixirOfTheMongoose)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
                item.SellIn = item.SellIn - 1;

                if (item.SellIn < 0 && item.Quality > 0)
                { 
                    item.Quality = item.Quality - 1;
                }
            }

            // ---------------
            if (item.Name == ItemNames.Conjured ||
                item.Name == ItemNames.PlusFiveDexterityVest
                )
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
            
           

            if (
                item.Name == ItemNames.Conjured ||
                item.Name == ItemNames.PlusFiveDexterityVest
                )
            {
                item.SellIn = item.SellIn - 1;
            }

            
           
            
            if (item.Name == ItemNames.Conjured ||
                item.Name == ItemNames.PlusFiveDexterityVest)
            {
                if (item.SellIn < 0 && item.Quality > 0)
                { 
                    item.Quality = item.Quality - 1;
                }
            }
            
        }
    }
}