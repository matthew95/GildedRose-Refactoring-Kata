namespace GildedRoseKata.Behaviors;

public class NoBehavior: Behavior
{
    private Item _item;
    
    public NoBehavior(Item item)
    {
        this._item = item;
    }
    
    public void UpdateQuality()
    {
        
    }
}