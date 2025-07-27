namespace GildedRoseKata.Behaviors;

public class BackstagePassesBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        if (_item.Quality < 50)
        {
            _item.Quality = _item.Quality + 1;
                
            if (_item.SellIn < 11 &&
                _item.Quality < 50)
            {
                _item.Quality = _item.Quality + 1;
            }

            if (_item.SellIn < 6 &&
                _item.Quality < 50)
            {
                _item.Quality = _item.Quality + 1;
            }   
        }
                
        _item.SellIn = _item.SellIn - 1;
                
        if (_item.SellIn < 0)
        {
            _item.Quality = 0;
        }
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new BackstagePassesBehavior
        {
            _item = item
        };
    }
}