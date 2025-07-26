using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.BackstagePasses;

public class BackstagePasses
{
    [Theory]
    [InlineData(15, 20, 1)]
    [InlineData(10, 20, 1)]
    [InlineData(6, 20, 1)]
    [InlineData(3, 20, 1)]
    [InlineData(3, 20, 2)]
    [InlineData(10, 49, 1)]
    [InlineData(5, 49, 1)]
    [InlineData(15, 20, 31)]
    [InlineData(10, 49, 31)]
    [InlineData(5, 49, 31)]
    public Task BackstagePasses_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        
        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}