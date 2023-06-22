using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xanadune 
{
    public static string GetName()
    {
        string result = "Xanadune";

        return result;
    }

    public static string GetDescription()
    {
        string result =
            "As you step foot into Xanadune, you find yourself to be immersed in a world of ancient wonders.  The nation is dotted with magnificent ruins, remnants of a bygone era that tell" +
            "tales of lost civilizations and forgottne secrets.  Xanadune's unique blend of history and mysticism makes it a haven for archaeologists, adventurers, and those" +
            "that thirst for unraveling the enigmatic past.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Meat, 2));
                result.Add(new ItemCount(Item.Wool, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Meat, 2));

                break;

            case 3:
                result.Add(new ItemCount(Item.Alcohol, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 4:
                result.Add(new ItemCount(Item.Machinery, 3));
                result.Add(new ItemCount(Item.Weapons, 1));
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
                result.Add(new ShopStock(Item.Stone, 5, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Paper, 3, 3));
                result.Add(new ShopStock(Item.Gemstone, 5, 4));
                break;

            case 3:
                result.Add(new ShopStock(Item.Glassware, 3, 6));
                result.Add(new ShopStock(Item.Porcelean, 4, 5));
                break;

            case 4:
                result.Add(new ShopStock(Item.Jewelry, 4, 8));
                result.Add(new ShopStock(Item.Relics, 8, 10));
                break;
        }

        return result;
    }
}
