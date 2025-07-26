using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.PlusFiveDexterityVest;

public class PlusFiveDexterityVest
{
    [Theory]
    [InlineData(10, 20)]
    public Task PlusFiveDexterityVest_Parameterized(int sellIn, int quality)
    {
        Item[] items = { new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        
        return Verifier.Verify(items).UseParameters(sellIn, quality);
    }
}