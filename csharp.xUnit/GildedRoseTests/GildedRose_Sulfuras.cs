using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseTests.ApprovalTests.AgedBrie;

namespace GildedRoseTests;

public class GildedRose_Sulfuras
{
    [Fact]
    public void Sulfuras_DoesntChange_Quality()
    {
        var sulfuras = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 80 };
        List<Item> items = [sulfuras];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(80, sulfuras.Quality);
    }
    
    [Fact]
    public void Sulfuras_DoesntChange_Quality_case2()
    {
        var sulfuras = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 1 };
        List<Item> items = [sulfuras];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(1, sulfuras.Quality);
    }
    
    [Fact]
    public void Sulfuras_DoesntChange_SellIn()
    {
        var sulfuras = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 2, Quality = 80 };
        List<Item> items = [sulfuras];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(2, sulfuras.SellIn);
    }
}