using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nalanda 
{
    public static string GetName()
    {
        string result = "Nalanda";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter Nalanda, you prepare to step into a realm of ancient wisdom and intellectual enlightenment." +
            "This nation, nestled amidst serene landscapes and adorned with architectural marvels, is a beacon of knowledge and scholarship." +
            "Nalanda beckons you to embark on a journey of discovery, where the pursuit of education and the quest for enlightenment are cherished above all else.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wood, 2));
                result.Add(new ItemCount(Item.Water, 1));
                break;

            case 2:
                result.Add(new ItemCount(Item.Wood, 2));
                result.Add(new ItemCount(Item.Meat, 2));
                result.Add(new ItemCount(Item.Metal, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Glassware, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Clothing, 3));
                result.Add(new ItemCount(Item.Glassware, 2));
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
                result.Add(new ShopStock(Item.Stone, 3, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Stone, 3, 1));
                result.Add(new ShopStock(Item.Paper, 4, 3));
                break;

            case 3:
                result.Add(new ShopStock(Item.Stone, 3, 1));
                result.Add(new ShopStock(Item.Paper, 4, 3));
                result.Add(new ShopStock(Item.Machinery, 3, 6));
                break;

            case 4:
                result.Add(new ShopStock(Item.Stone, 3, 1));
                result.Add(new ShopStock(Item.Paper, 4, 3));
                result.Add(new ShopStock(Item.Machinery, 1, 6));
                result.Add(new ShopStock(Item.Oil, 4, 9));
                break;
        }

        return result;
    }
}
