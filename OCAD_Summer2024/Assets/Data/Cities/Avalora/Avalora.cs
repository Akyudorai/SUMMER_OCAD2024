using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avalora
{
    public static string GetName()
    {
        string result = "Avalora";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the nation of Avalora, a frost-kissed wonderland unfolds before your very eyes.  A presitine landscape " +
            "of glistening ice and pristine snow blankets the land, sparking in the soft glow of the sun.  Majestic ice-capped mountains tower in " +
            "the distance, their peaks piercing the azure sky, while crystalline lakes and frozen rivers create intricate lattices across the terrain. " +
            "Avalora, a realm where ice and snow eave tales of both beauty and resilience, beckons you to accept the cold embrace of its land and to " +
            "discover the hidden wonders within its frozen realm.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wool, 5));
                result.Add(new ItemCount(Item.Fur, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Fur, 5));
                result.Add(new ItemCount(Item.Wood, 2));
                result.Add(new ItemCount(Item.Leather, 3));
                break;

            case 3:
                result.Add(new ItemCount(Item.Cotton, 3));
                result.Add(new ItemCount(Item.Meat, 4));
                result.Add(new ItemCount(Item.Wood, 5));
                break;

            case 4:
                result.Add(new ItemCount(Item.Medicine, 2));
                result.Add(new ItemCount(Item.Clothing, 3));
                break;
        }

        return result;
    }

    public static List<ShopStock> GetShopStock(int i)
    {
        List<ShopStock> result = new List<ShopStock>();

        switch (i)
        {
            case 1:
                result.Add(new ShopStock(Item.Fish, 5, 3));
                result.Add(new ShopStock(Item.Water, 3, 1));
                result.Add(new ShopStock(Item.Stone, 3, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Fish, 6, 2));
                result.Add(new ShopStock(Item.Metal, 3, 4));
                result.Add(new ShopStock(Item.Cargo_1, 1, 10));
                break;

            case 3:
                result.Add(new ShopStock(Item.Fish, 6, 2));
                result.Add(new ShopStock(Item.Glassware, 5, 3));
                result.Add(new ShopStock(Item.Metal, 3, 4));
                break;

            case 4:
                result.Add(new ShopStock(Item.Fish, 6, 2));
                result.Add(new ShopStock(Item.Glassware, 5, 3));
                result.Add(new ShopStock(Item.Metal, 3, 4));
                result.Add(new ShopStock(Item.Jewelry, 4, 8));
                break;
        }

        return result;
    }
}
