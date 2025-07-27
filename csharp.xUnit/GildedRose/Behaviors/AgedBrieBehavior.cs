namespace GildedRoseKata.Behaviors;

public class AgedBrieBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        _item.SellIn = _item.SellIn - 1; 
        ItemHelper.IncreaseQuality(_item);
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new AgedBrieBehavior
        {
            _item = item
        };
    }
}