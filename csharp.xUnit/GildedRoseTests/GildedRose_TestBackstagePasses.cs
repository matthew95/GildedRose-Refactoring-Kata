using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseTests.ApprovalTests.AgedBrie;

namespace GildedRoseTests;

public class GildedRose_BackstagePasses
{
    [Fact]
    public void BackstagePasses_Increases_Quality_By_Day_By_One_SellIn_More_Than_10()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 20 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(21, backstagePasses.Quality);
    }
    
    [Fact]
    public void BackstagePasses_Increases_Quality_By_Day_By_Two_SellIn_More_Than_5_Less_Than_Or_Equal_10()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(22, backstagePasses.Quality);
    }
    
    [Fact]
    public void BackstagePasses_Increases_Quality_By_Day_By_Two_SellIn_Less_Than_Or_Equal_5()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(23, backstagePasses.Quality);
    }
    
    [Fact]
    public void BackstagePasses_Increases_Quality_By_Day_By_Two_SellIn_Less_Than_Or_Equal_5_case_2()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 10 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(13, backstagePasses.Quality);
    }
    
    [Fact]
    public void BackstagePasses_Sets_Quality_To_Zero_SellIn_Less_Than_Or_Equal_0()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(0, backstagePasses.Quality);
    }
    
    
    [Fact]
    public void BackstagePasses_Quality_Doesnt_Increase_Beyond_50()
    {
        var backstagePasses = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 49 };
        List<Item> items = [backstagePasses];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(50, backstagePasses.Quality);
    }
}
