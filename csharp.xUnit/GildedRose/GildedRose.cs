using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Product> _products;
    
    public GildedRose(IList<Item> items)
    {
        this._products = ProductHelper.FromItems(items);
    }

    public void UpdateQuality()
    {
        foreach (var product in this._products)
        {
            product.Behavior.UpdateQuality();
        }
    }
}