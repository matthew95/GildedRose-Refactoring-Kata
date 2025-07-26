using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.Conjured;

public class Conjured
{
    [Theory]
    [InlineData(3, 6)]
    public Task Conjured_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}