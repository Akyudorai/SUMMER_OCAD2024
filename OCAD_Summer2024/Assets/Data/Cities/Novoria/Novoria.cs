using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novoria
{
    public static string GetName()
    {
        string result = "Novoria";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter Novira, you prepare to be swept away by a whirlwind of creativity and innovation." +
            "This nation pulsates with a vibrant cultural scene that captivates the senses and fuels the imagination. " +
            "Novoria is a place where artistry, technology, and boundless posiblities converge.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Stone, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Stone, 3));
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Paper, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Glassware, 1));
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Paper, 2));
                break;

            case 4:
                result.Add(new ItemCount(Item.Metal, 6));
                result.Add(new ItemCount(Item.Glassware, 2));
                result.Add(new ItemCount(Item.Relics, 1));
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
                result.Add(new ShopStock(Item.Meat, 3, 1));
                result.Add(new ShopStock(Item.Leather, 3, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Metal, 3, 2));
                result.Add(new ShopStock(Item.Alcohol, 3, 3));
                break;

            case 3:
                result.Add(new ShopStock(Item.Metal, 3, 2));
                result.Add(new ShopStock(Item.Alcohol, 3, 3));
                result.Add(new ShopStock(Item.Porcelean, 3, 6));
                result.Add(new ShopStock(Item.Machinery, 5, 6));
                break;

            case 4:
                result.Add(new ShopStock(Item.Porcelean, 3, 6));
                result.Add(new ShopStock(Item.Machinery, 5, 6));
                result.Add(new ShopStock(Item.Relics, 3, 8));
                result.Add(new ShopStock(Item.Chemicals, 2, 10));
                break;
        }

        return result;
    }
}
