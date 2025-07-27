using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRose_Conjured
{
    [Fact]
    public void Conjured_Decreases_Quality_By_Day_By_Two()
    {
        var conjured = new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 6 };
        List<Item> items = [conjured];
    
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
    
        Assert.Equal(4, conjured.Quality);
    }
    
    [Fact]
    public void Conjured_Decreases_SellIn_By_Day_By_One()
    {
        var conjured = new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 6 };
        List<Item> items = [conjured];
    
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
    
        Assert.Equal(1,  conjured.SellIn);
    }
    
    
    [Fact]
    public void Conjured_Decreases_Quality_After_SellIn_Gets_ZeroOrNegative_By_Four()
    {
        var conjured = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 10 };
        List<Item> items = [conjured];
    
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(6, conjured.Quality);
    }
    
    [Fact]
    public void Conjured_Doesnt_Decrease_Quality_Beyond_Zero()
    {
        var conjured = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 1 };
        List<Item> items = [conjured];
    
        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(0, conjured.Quality);
    }
}