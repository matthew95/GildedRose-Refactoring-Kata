using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.Conjured;

public class Conjured
{
    [Theory]
    [InlineData(3, 6, 1)]
    [InlineData(3, 6, 6)]
    [InlineData(3, 6, 31)]
    public Task Conjured_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        
        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}