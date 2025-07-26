using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.ElixirOfTheMongoose;

public class ElixirOfTheMongoose
{
    [Theory]
    [InlineData(5, 7, 1)]
    [InlineData(5, 7, 6)]
    [InlineData(5, 7, 31)]
    public Task ElixirOfTheMongoose_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "Elixir of the Mongoose", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        
        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}