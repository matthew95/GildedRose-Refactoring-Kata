using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.BackstagePasses;

public class BackstagePasses
{
    [Theory]
    [InlineData(15, 20)]
    [InlineData(10, 49)]
    [InlineData(5, 49)]
    public Task BackstagePasses_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}