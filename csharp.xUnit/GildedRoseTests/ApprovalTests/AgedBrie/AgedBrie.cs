using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.AgedBrie;

public class AgedBrie
{
    [Theory]
    [InlineData(2, 0)]
    public Task AgedBrie_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}