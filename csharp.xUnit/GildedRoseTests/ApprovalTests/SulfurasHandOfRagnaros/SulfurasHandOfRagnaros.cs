using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.SulfurasHandOfRagnaros;

public class SulfurasHandOfRagnaros
{
    [Theory]
    [InlineData(0, 80)]
    [InlineData(-1, 80)]
    public Task SulfurasHandOfRagnaros_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}