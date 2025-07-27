namespace GildedRoseKata.Behaviors;

public class DefaultBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        if (_item.Quality > 0)
        {
            _item.Quality = _item.Quality - 1;
        }
                
        _item.SellIn = _item.SellIn - 1;

        if (_item.SellIn < 0 && _item.Quality > 0)
        { 
            _item.Quality = _item.Quality - 1;
        }
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new DefaultBehavior
        {
            _item = item
        };
    }
}