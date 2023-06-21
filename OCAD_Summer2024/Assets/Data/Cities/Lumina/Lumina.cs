using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumina 
{
    public static string GetName()
    {
        string result = "Lumina";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the radient nation of Lumina, a breathtaking spectacle unfolds before your eyes." +
            "Every corner of this vibrant land pulsates with an etheral glow, casting a captivating tapestry of colors that dances " +
            "with the night sky.  Streets lined with shimmering lanterns guide your path, their warm illumination infusing the air " +
            "with an enchanting ambience.  Lumina, a realm where light is not merely a source of brightness, but a language of expression, " +
            "embraces its identity as the realm of illumination and beckons you to explore its shimmering wonders.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Metal, 2));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Paper, 5));
                break;

            case 3:
                result.Add(new ItemCount(Item.Glassware, 3));
                result.Add(new ItemCount(Item.Clothing, 1));
                result.Add(new ItemCount(Item.Alcohol, 2));
                break;

            case 4:
                result.Add(new ItemCount(Item.Oil, 2));
                result.Add(new ItemCount(Item.Metal, 1));
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
                result.Add(new ShopStock(Item.Cargo_1, 1, 8));
                break;

            case 2:
                result.Add(new ShopStock(Item.Stone, 5, 2));
                result.Add(new ShopStock(Item.Gemstone, 3, 5));
                break;

            case 3:
                result.Add(new ShopStock(Item.Stone, 5, 2));
                result.Add(new ShopStock(Item.Gemstone, 2, 6));
                result.Add(new ShopStock(Item.Machinery, 5, 6));
                result.Add(new ShopStock(Item.Sails_2, 1, 12));
                break;

            case 4:
                result.Add(new ShopStock(Item.Stone, 5, 2));
                result.Add(new ShopStock(Item.Gemstone, 2, 6));
                result.Add(new ShopStock(Item.Machinery, 5, 6));
                result.Add(new ShopStock(Item.Circuitry, 5, 8));
                result.Add(new ShopStock(Item.Chemicals, 4, 9));
                break;
        }

        return result;
    }
}
