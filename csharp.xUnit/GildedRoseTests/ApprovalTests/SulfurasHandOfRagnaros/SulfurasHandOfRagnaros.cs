using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.SulfurasHandOfRagnaros;

public class SulfurasHandOfRagnaros
{
    [Theory]
    [InlineData(0, 80, 1)]
    [InlineData(-1, 80, 1)]
    [InlineData(0, 80, 31)]
    [InlineData(-1, 80, 31)]
    public Task SulfurasHandOfRagnaros_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        
        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}