namespace GildedRoseKata.Behaviors;

public class DefaultBehavior: Behavior
{
    private Item _item;
    
    public void SetItem(Item item)
    {
        this._item = item;
    }
    
    public void UpdateQuality()
    {
        
    }
}