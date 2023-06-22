using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sylvestria 
{
    public static string GetName()
    {
        string result = "Sylvestria";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the realm of Sylvestria, you're greeted by the ethereal melodies of birdsong and gentle whispers of the wind through the ancient trees." +
            "The nation is renown for its breathtaking landscapes, from towering emerald forests to crystal-clear lakes reflecting the shimmering moonlight.  Sylbestria's " +
            "pristine wilderness and vibrant fauna are a wonder to behold.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Fish, 1));
                result.Add(new ItemCount(Item.Stone, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Silk, 1));
                result.Add(new ItemCount(Item.Cotton, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Gemstone, 4));
                result.Add(new ItemCount(Item.Wool, 3));
                break;

            case 4:
                result.Add(new ItemCount(Item.Clothing, 8));
                result.Add(new ItemCount(Item.Fish, 6));
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
                result.Add(new ShopStock(Item.Wood, 5, 2));
                result.Add(new ShopStock(Item.Water, 3, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Wood, 3, 2));
                result.Add(new ShopStock(Item.Water, 3, 2));
                result.Add(new ShopStock(Item.Paper, 3, 5));
                break;

            case 3:
                result.Add(new ShopStock(Item.Meat, 4, 2));
                result.Add(new ShopStock(Item.Paper, 3, 5));
                result.Add(new ShopStock(Item.Medicine, 3, 5));
                break;

            case 4:
                result.Add(new ShopStock(Item.Water, 3, 2));
                result.Add(new ShopStock(Item.Paper, 3, 5));
                result.Add(new ShopStock(Item.Medicine, 8, 4));
                result.Add(new ShopStock(Item.Cargo_3, 1, 15));
                break;
        }

        return result;
    }
}
