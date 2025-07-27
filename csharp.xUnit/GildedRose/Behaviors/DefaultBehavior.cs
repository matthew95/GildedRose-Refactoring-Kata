namespace GildedRoseKata.Behaviors;

public class DefaultBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        _item.SellIn = _item.SellIn - 1;

        ItemHelper.DecreaseQuality(_item);
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new DefaultBehavior
        {
            _item = item
        };
    }
}