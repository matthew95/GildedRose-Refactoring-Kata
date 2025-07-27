namespace GildedRoseKata;

public static class ItemHelper
{
    public static void DecreaseQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
        
        if (item.SellIn < 0 && item.Quality > 0)
        { 
            item.Quality--;
        }
    }
    
    
    public static void IncreaseQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality++;
        }
        
        if (item.SellIn < 0 && item.Quality < 50)
        { 
            item.Quality++;
        }
    }
}