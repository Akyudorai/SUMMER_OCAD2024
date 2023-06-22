using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemuria 
{
    public static string GetName()
    {
        string result = "Zemuria";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the marvelous nation of Zemuria, a symphony of gears turning and steam hissing fills the air, enveloping you in a world " +
            "of mechanical wonders.  Towering structures with intricate brass embellishments and whirling machinery dominate the skyline, casting logn shadows " +
            "over bustling streets.  Zemuria, a realm where the beauty of steam-powered machinery intertwines with Victorian elegance, invites you to embark on " +
            "a journey where innovation and imagination converge, forging a landscape that pulsates with the charm and ingenuity of a steampunk marvel. ";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wool, 2));
                result.Add(new ItemCount(Item.Leather, 5));
                break;

            case 2:
                result.Add(new ItemCount(Item.Leather, 6));
                result.Add(new ItemCount(Item.Meat, 4));
                break;

            case 3:
                result.Add(new ItemCount(Item.Metal, 5));
                result.Add(new ItemCount(Item.Paper, 4));
                break;

            case 4:
                result.Add(new ItemCount(Item.Circuitry, 3));
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
                result.Add(new ShopStock(Item.Wool, 4, 2));
                result.Add(new ShopStock(Item.Wood, 5, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Metal, 6, 4));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Cargo_1, 1, 8));
                break;

            case 3:
                result.Add(new ShopStock(Item.Machinery, 3, 6));
                result.Add(new ShopStock(Item.Metal, 6, 4));
                break;

            case 4:
                result.Add(new ShopStock(Item.Machinery, 3, 6));
                result.Add(new ShopStock(Item.Weapons, 3, 9));
                result.Add(new ShopStock(Item.Cargo_3, 1, 18));
                break;
        }

        return result;
    }
}
