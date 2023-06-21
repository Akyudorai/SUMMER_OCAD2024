using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eldorana 
{
    public static string GetName()
    {
        string result = "Eldorana";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the rugged nation of Eldorana, a sprawling landscape unfurls before your eyes, embodying the spirit of the Wild West. " +
            "Endless streches of untamed praries and towering mesas dominate the horizon, adorned with weathered wooden structures and saloons exuding an " +
            "undeniable cowboy charm.  The air carries a hint of leather and gunpowder, as riders in wide-brimmed hats and spurs clatter along the streets, " +
            "embodying the frontier spirit that permeates every corner of Eldorana.  Welcome to a realm where the echoes of yeehaws and the allure of the cowboy " +
            "way of life echo through the very heart of the land.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 3:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 4:
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
                result.Add(new ItemCount(Item.Wood, 3));
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
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;

            case 3:
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;

            case 4:
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;
        }

        return result;
    }
}
