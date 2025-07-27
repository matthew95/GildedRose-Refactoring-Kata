namespace GildedRoseKata.Behaviors;

public class BackstagePassesBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new BackstagePassesBehavior
        {
            _item = item
        };
    }
}