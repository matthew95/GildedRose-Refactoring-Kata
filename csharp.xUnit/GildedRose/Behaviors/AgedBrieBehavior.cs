namespace GildedRoseKata.Behaviors;

public class AgedBrieBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        _item.SellIn = _item.SellIn - 1;
        if (_item.Quality < 50)
        {
            _item.Quality = _item.Quality + 1;
        }
        if (_item.SellIn < 0 && _item.Quality < 50)
        {
            _item.Quality = _item.Quality + 1;
        }
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new AgedBrieBehavior
        {
            _item = item
        };
    }
}