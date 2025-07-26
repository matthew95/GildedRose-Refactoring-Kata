using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.ElixirOfTheMongoose;

public class ElixirOfTheMongoose
{
    [Theory]
    [InlineData(5, 7)]
    public Task ElixirOfTheMongoose_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}