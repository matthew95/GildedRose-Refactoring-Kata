using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseTests.ApprovalTests.AgedBrie;

namespace GildedRoseTests;

public class GildedRose_TestBrie
{
    [Fact]
    public void AgedBrie_Increases_Quality_By_Day_By_One()
    {
        var brie = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
        List<Item> items = [brie];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(1, brie.Quality);
    }
    
    [Fact]
    public void AgedBrie_Decreases_SellIn_By_Day_By_One()
    {
        var brie = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
        List<Item> items = [brie];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(1, brie.SellIn);
    }
    
    
    [Fact]
    public void AgedBrie_Increases_Quality_After_SellIn_Gets_ZeroOrNegative_By_Two()
    {
        var brie = new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 };
        List<Item> items = [brie];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(2, brie.Quality);
    }
    
    [Fact]
    public void AgedBrie_Quality_Doesnt_Increase_Beyond_50()
    {
        var brie = new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 };
        List<Item> items = [brie];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(50, brie.Quality);
    }
}