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
                result.Add(new ItemCount(Item.Metal, 2));
                result.Add(new ItemCount(Item.Paper, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 1));
                result.Add(new ItemCount(Item.Paper, 4));
                result.Add(new ItemCount(Item.Glassware, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Paper, 3));
                result.Add(new ItemCount(Item.Glassware, 2));
                result.Add(new ItemCount(Item.Gemstone, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Oil, 1));
                result.Add(new ItemCount(Item.Chemicals, 1));
                result.Add(new ItemCount(Item.Gemstone, 1));
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
                result.Add(new ShopStock(Item.Stone, 4, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Stone, 4, 2));
                result.Add(new ShopStock(Item.Alcohol, 3, 4));
                break;

            case 3:
                result.Add(new ShopStock(Item.Machinery, 10, 6));
                result.Add(new ShopStock(Item.Sails_2, 1, 12));
                break;

            case 4:
                result.Add(new ShopStock(Item.Machinery, 5, 6));
                result.Add(new ShopStock(Item.Circuitry, 7, 9));
                result.Add(new ShopStock(Item.Weapons, 4, 10));
                break;
        }

        return result;
    }
}
