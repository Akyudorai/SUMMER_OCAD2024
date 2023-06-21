using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zenithia 
{
    public static string GetName()
    {
        string result = "Zenithia";

        return result;
    }

    public static string GetDescription()
    {
        string result = "Welcome to Zenithia, a land of wonder and innovation that stands out among other nations.\n\n" +
            "Zenithia's uniqueness lies in its harmonious integration of advanced technology with the natural world.  The nation has harnessed its abundant" +
            "geothermal resources, creating a network of sustainable energy systems that power its cities and industries.  In Zenithia, innovation and " +
            "environmental preservation go hand in hand.";

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
