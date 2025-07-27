namespace GildedRoseKata.Behaviors;

public class NoBehavior: IBehavior
{
    private Item _item;
    
    public void UpdateQuality()
    {
        
    }
    
    public IBehavior CreateInstance(Item item)
    {
        return new NoBehavior
        {
            _item = item
        };
    }
}