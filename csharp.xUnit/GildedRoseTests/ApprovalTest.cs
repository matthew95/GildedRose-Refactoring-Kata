using GildedRoseKata;

using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using VerifyXunit;

using Xunit;

namespace GildedRoseTests;

public class ApprovalTest
{
    // [Theory]
    // [InlineData(10, 20)]
    // [InlineData(1, 2)]
    // public Task PlusFiveDexterityVest(int sellIn, int quality)
    // {
    //     Item[] items = { new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality } };
    //     GildedRose app = new GildedRose(items);
    //     app.UpdateQuality();
    //     
    //     return Verifier.Verify(items);
    // }
    //
    [Fact]
    public Task AgedBrie()
    {
        Item[] items = { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task ElixirOfTheMongoose()
    {
        Item[] items = { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task SulfurasHandOfRagnaros()
    {
        Item[] items = { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task SulfurasHandOfRagnaros2()
    {
        Item[] items = { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items);
    }
    
    [Fact]
    public Task ThirtyDays()
    {
        var fakeoutput = new StringBuilder();
        Console.SetOut(new StringWriter(fakeoutput));
        Console.SetIn(new StringReader($"a{Environment.NewLine}"));

        Program.Main(new string[] { "30" });
        var output = fakeoutput.ToString();

        return Verifier.Verify(output);
    }
}