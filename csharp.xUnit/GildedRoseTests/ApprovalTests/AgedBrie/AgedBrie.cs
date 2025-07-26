using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.AgedBrie;

public class AgedBrie
{
    [Theory]
    [InlineData(2, 0, 1)]
    [InlineData(2, 0, 31)]
    [InlineData(2, 0, 7)]
    public Task AgedBrie_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);

        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}