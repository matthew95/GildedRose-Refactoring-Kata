using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private IList<Product> _products;
    

    public GildedRose(IList<Item> Items)
    {
        this._items = Items;
        this._products = new List<Product>(Items.Count);
        foreach (var item in Items)
        {
            this._products.Add(new Product()
            {
                Item = item,
            });
        }
    }

    public void UpdateQuality()
    {
        foreach (var item in this._items)
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
            // will add the original code tho.
            if (item.Name == ItemNames.Conjured)
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

            if (item.Name == ItemNames.PlusFiveDexterityVest)
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
        }
    }
}