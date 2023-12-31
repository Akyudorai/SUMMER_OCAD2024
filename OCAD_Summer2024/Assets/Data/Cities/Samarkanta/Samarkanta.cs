using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samarkanta 
{
    public static string GetName()
    {
        string result = "Samarkanta";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the realm fo Samarkanta, you find yourself enchanted by the vibrant tapestry of colors, scents, and sounds that fill the air." +
            "The nation's bustling bazaars are alive with the vibrant energy of merchants haggling over exotic spices, fine silks, and intrecately woven carpets. " +
            "Samarkanta's history as a vibrant trading hub is ingrained in its very soul.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Fur, 3));
                result.Add(new ItemCount(Item.Wool, 5));
                break;

            case 2:
                result.Add(new ItemCount(Item.Alcohol, 6));
                result.Add(new ItemCount(Item.Cotton, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Fur, 3));
                result.Add(new ItemCount(Item.Wool, 5));
                result.Add(new ItemCount(Item.Cotton, 2));
                break;

            case 4:
                result.Add(new ItemCount(Item.Fur, 6));
                result.Add(new ItemCount(Item.Wool, 6));
                result.Add(new ItemCount(Item.Cotton, 5));
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
                result.Add(new ShopStock(Item.Meat, 3, 2));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Silk, 10, 5));
                result.Add(new ShopStock(Item.Meat, 3, 2));
                result.Add(new ShopStock(Item.Wood, 3, 1));
                break;

            case 3:
                result.Add(new ShopStock(Item.Silk, 6, 4));
                result.Add(new ShopStock(Item.Perfumes, 3, 4));
                result.Add(new ShopStock(Item.Porcelean, 3, 7));
                break;

            case 4:
                result.Add(new ShopStock(Item.Silk, 4, 2));
                result.Add(new ShopStock(Item.Perfumes, 3, 4));
                result.Add(new ShopStock(Item.Porcelean, 3, 7));
                result.Add(new ShopStock(Item.Jewelry, 6, 10));
                break;
        }

        return result;
    }
}
