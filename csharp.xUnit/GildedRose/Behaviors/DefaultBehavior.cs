namespace GildedRoseKata.Behaviors;

public class DefaultBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new DefaultBehavior
        {
            _item = item
        };
    }
}