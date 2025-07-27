namespace GildedRoseKata.Behaviors;

public class AgedBrieBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new AgedBrieBehavior
        {
            _item = item
        };
    }
}