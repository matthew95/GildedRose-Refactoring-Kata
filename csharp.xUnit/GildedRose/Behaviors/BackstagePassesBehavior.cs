namespace GildedRoseKata.Behaviors;

public class BackstagePassesBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
       ItemHelper.IncreaseQuality(_item);
                
        if (_item.SellIn < 11)
        {
            ItemHelper.IncreaseQuality(_item);
        }

        if (_item.SellIn < 6)
        {
            ItemHelper.IncreaseQuality(_item);
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