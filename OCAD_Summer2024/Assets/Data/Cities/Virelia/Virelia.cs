using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virelia 
{
    public static string GetName()
    {
        string result = "Virelia";

        return result;
    }

    public static string GetDescription()
    {
        string result = 
            "As you step foot into Virelia, you're greeted by a sense of tranquility and harmony.  The nation is blessed with an abundance of lush forests, cascading waterfalls, " +
            "and serene lanes that reflect the azure sky.  Virelia's commitment to environmental preservation is evident in its pristine nature reserves, where rare flora and " +
            "fauna thrive, offerring a glimpse into the nation's rich biodiversity.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Leather, 3));
                result.Add(new ItemCount(Item.Meat, 2));
                break;

            case 2:
                result.Add(new ItemCount(Item.Wool, 2));
                result.Add(new ItemCount(Item.Fur, 3));
                break;

            case 3:
                result.Add(new ItemCount(Item.Silk, 5));
                result.Add(new ItemCount(Item.Metal, 2));
                break;

            case 4:
                result.Add(new ItemCount(Item.Chemicals, 1));
                result.Add(new ItemCount(Item.Machinery, 5));
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
                result.Add(new ShopStock(Item.Wood, 3, 3));
                result.Add(new ShopStock(Item.Water, 5, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Wood, 3, 3));
                result.Add(new ShopStock(Item.Cotton, 5, 4));
                result.Add(new ShopStock(Item.Fish, 4, 2));
                break;

            case 3:
                result.Add(new ShopStock(Item.Wood, 3, 3));
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Medicine, 3, 6));
                result.Add(new ShopStock(Item.Perfumes, 3, 5));
                break;

            case 4:
                result.Add(new ShopStock(Item.Medicine, 6, 6));
                result.Add(new ShopStock(Item.Perfumes, 3, 5));
                result.Add(new ShopStock(Item.Oil, 3, 9));
                break;
        }

        return result;
    }
}
