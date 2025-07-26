using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRose_PlusFiveDexterityVest
{
    [Fact]
    public void PlusFiveDexterityVest_Decreases_Quality_By_Day_By_One()
    {
        var plusFiveDexterityVest = new Item { Name = "+5 Dexterity Vest", SellIn = 2, Quality = 6 };
        List<Item> items = [plusFiveDexterityVest];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Assert.Equal(5, plusFiveDexterityVest.Quality);
    }

    [Fact]
    public void PlusFiveDexterityVest_Decreases_SellIn_By_Day_By_One()
    {
        var plusFiveDexterityVest = new Item { Name = "+5 Dexterity Vest", SellIn = 2, Quality = 6 };
        List<Item> items = [plusFiveDexterityVest];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Assert.Equal(1,  plusFiveDexterityVest.SellIn);
    }
    
    
    [Fact]
    public void PlusFiveDexterityVest_Decreases_Quality_After_SellIn_Gets_ZeroOrNegative_By_Two()
    {
        var plusFiveDexterityVest = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10 };
        List<Item> items = [plusFiveDexterityVest];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(8, plusFiveDexterityVest.Quality);
    }
    
    [Fact]
    public void PlusFiveDexterityVest_Doesnt_Decrease_Quality_Beyond_Zero()
    {
        var plusFiveDexterityVest = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 1 };
        List<Item> items = [plusFiveDexterityVest];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(0, plusFiveDexterityVest.Quality);
    }
}