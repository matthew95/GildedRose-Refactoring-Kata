using System.Threading.Tasks;
using GildedRoseKata;
using VerifyXunit;
using Xunit;

namespace GildedRoseTests.ApprovalTests.PlusFiveDexterityVest;

public class PlusFiveDexterityVest
{
    [Theory]
    [InlineData(10, 20, 1)]
    [InlineData(10, 20, 11)]
    [InlineData(10, 20, 31)]
    public Task PlusFiveDexterityVest_Parameterized(int sellIn, int quality, int testAfterDays)
    {
        Item[] items = { new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality } };
        GildedRose app = new GildedRose(items);
        
        for (int i = 0; i < testAfterDays; i++)
        {
            app.UpdateQuality();
        }
        
        return Verifier.Verify(items).UseParameters(sellIn, quality, testAfterDays);
    }
}