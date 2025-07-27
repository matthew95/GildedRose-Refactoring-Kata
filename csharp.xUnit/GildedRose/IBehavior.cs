using GildedRoseKata.Behaviors;

namespace GildedRoseKata;

public interface IBehavior
{
    public void UpdateQuality();
    
    // okay this might be a bit ugly. Behaviors are now their own factory, but I can't be
    // bothered to create separate factories for every behavior.
    // would rather have <IBehavior implementation>.CreateInstance(item)
    // instead of (new <IBehavior implementation>).CreateInstance(item)
    // but I'm no c# expert and don't want to make this exercise about that.
    // ¯\_(ツ)_/¯
    // it does keep the file count somewhat low, though :).
    public IBehavior CreateInstance(Item item);
}