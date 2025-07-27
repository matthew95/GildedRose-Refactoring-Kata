using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Behaviors;

namespace GildedRoseKata;

public class ProductHelper
{
    private static readonly Dictionary<string, Behavior> BehaviorMap = new Dictionary<string, Behavior>
    {
        { ItemNames.AgedBrie, new AgedBrieBehavior() },
        { ItemNames.BackstagePasses, new BackstagePassesBehavior() },
        { ItemNames.Conjured, new DefaultBehavior()},
        { ItemNames.ElixirOfTheMongoose, new DefaultBehavior()},
        { ItemNames.PlusFiveDexterityVest, new DefaultBehavior()},
        { ItemNames.Sulfuras, new NoBehavior()},
    };

    public static IList<Product> FromItems(IList<Item> items)
    {
        return items.Select(FromItem).ToList();
    }

    private static Product FromItem(Item item)
    {
        return new Product()
        {
            Item = item,
            Behavior = BehaviorMap.ContainsKey(item.Name) ? BehaviorMap[item.Name] : new NoBehavior()
        };
    }
}