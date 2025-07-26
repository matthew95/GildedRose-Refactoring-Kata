using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRose_ElixirOfTheMongoose
{
    [Fact]
    public void ElixirOfTheMongoose_Decreases_Quality_By_Day_By_One()
    {
        var elixirOfTheMongoose = new Item { Name = "Elixir of the Mongoose", SellIn = 2, Quality = 6 };
        List<Item> items = [elixirOfTheMongoose];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Assert.Equal(5, elixirOfTheMongoose.Quality);
    }

    [Fact]
    public void ElixirOfTheMongoose_Decreases_SellIn_By_Day_By_One()
    {
        var elixirOfTheMongoose = new Item { Name = "Elixir of the Mongoose", SellIn = 2, Quality = 6 };
        List<Item> items = [elixirOfTheMongoose];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();

        Assert.Equal(1,  elixirOfTheMongoose.SellIn);
    }
    
    
    [Fact]
    public void ElixirOfTheMongoose_Decreases_Quality_After_SellIn_Gets_ZeroOrNegative_By_Two()
    {
        var elixirOfTheMongoose = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 10 };
        List<Item> items = [elixirOfTheMongoose];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(8, elixirOfTheMongoose.Quality);
    }
    
    [Fact]
    public void ElixirOfTheMongoose_Doesnt_Decrease_Quality_Beyond_Zero()
    {
        var elixirOfTheMongoose = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 1 };
        List<Item> items = [elixirOfTheMongoose];

        var gildedRose = new GildedRose(items);
        gildedRose.UpdateQuality();
        
        Assert.Equal(0, elixirOfTheMongoose.Quality);
    }
}