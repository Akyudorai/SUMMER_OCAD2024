using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delphoria 
{
    public static string GetName()
    {
        string result = "Delphoria";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the enchanting nation of Delphoria, a symphony of animal calls and whispers of nature greet your arrival." +
            "Lush forests teeming with diverse wildlife spread their verdant embrace, offering a sanctuary for creatures both familiar and fantastical. " +
            "Delphira, a realm where the animal kingdom reigns supreme, invites you to embark on a remarkable journey where the boundaries between humans and beasts blur, " +
            "and the wisdom and beauty of the animal realm intertwine with the human experience.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Stone, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Stone, 5));
                result.Add(new ItemCount(Item.Metal, 1));
                result.Add(new ItemCount(Item.Water, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Metal, 4));
                result.Add(new ItemCount(Item.Fish, 3));
                result.Add(new ItemCount(Item.Clothing, 2));
                break;

            case 4:
                result.Add(new ItemCount(Item.Weapons, 4));
                result.Add(new ItemCount(Item.Medicine, 2));
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
                result.Add(new ShopStock(Item.Wood, 7, 2));
                result.Add(new ShopStock(Item.Meat, 5, 3));
                break;

            case 2:
                result.Add(new ShopStock(Item.Wood, 5, 2));
                result.Add(new ShopStock(Item.Meat, 5, 3));
                result.Add(new ShopStock(Item.Wool, 2, 3));
                
                break;

            case 3:
                result.Add(new ShopStock(Item.Wood, 4, 2));
                result.Add(new ShopStock(Item.Leather, 2, 3));
                result.Add(new ShopStock(Item.Fur, 2, 2));
                result.Add(new ShopStock(Item.Cotton, 4, 3));
                break;

            case 4:
                result.Add(new ShopStock(Item.Wood, 10, 1));
                result.Add(new ShopStock(Item.Leather, 5, 3));
                result.Add(new ShopStock(Item.Fur, 12, 3));
                result.Add(new ShopStock(Item.Cotton, 4, 3));
                result.Add(new ShopStock(Item.Paper, 5, 3));
                break;
        }

        return result;
    }
}
