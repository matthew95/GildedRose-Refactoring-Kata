namespace GildedRoseKata.Behaviors;

public class DeterioratesTwiceAsFastBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        _item.SellIn = _item.SellIn - 1;
        
       ItemHelper.DecreaseQuality(_item);
       ItemHelper.DecreaseQuality(_item);
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new DeterioratesTwiceAsFastBehavior
        {
            _item = item
        };
    }
}