using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caledonia 
{
    public static string GetName()
    {
        string result = "Caledonia";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the regal nation of Caledonia, a palpable air of majesty and tradition surrounds you.  The landscape is adorned with " +
            "grant castles and stately palaces, their turrets reaching towards the heavens as a testament to the enduring legacy of monarchy.  The nation's " +
            "colors proudly fly from flagpoles, symbolizing loyalty and reverence for the royal lineage that has guided Caledonia through the ages. Caledonia, " +
            "a realm where the crown sits at the heart of its identity, invites you to immerse yourself in a world where history, heritage, and the splendor of " +
            "monarchy intertwine in a tapesty of noble tales.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Wood, 6));
                result.Add(new ItemCount(Item.Meat, 2));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 2));
                result.Add(new ItemCount(Item.Silk, 2));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 3:
                result.Add(new ItemCount(Item.Glassware, 2));
                result.Add(new ItemCount(Item.Perfumes, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Jewelry, 2));
                result.Add(new ItemCount(Item.Relics, 2));
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
                result.Add(new ShopStock(Item.Stone, 4, 3));
                result.Add(new ShopStock(Item.Leather, 3, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Stone, 5, 3));
                result.Add(new ShopStock(Item.Leather, 3, 2));
                result.Add(new ShopStock(Item.Alcohol, 3, 5));
                break;

            case 3:
                result.Add(new ShopStock(Item.Stone, 5, 3));
                result.Add(new ShopStock(Item.Clothing, 3, 4));
                result.Add(new ShopStock(Item.Alcohol, 4, 5));
                result.Add(new ShopStock(Item.Sails_2, 13, 1));
                break;

            case 4:
                result.Add(new ShopStock(Item.Stone, 5, 3));
                result.Add(new ShopStock(Item.Clothing, 3, 4));
                result.Add(new ShopStock(Item.Alcohol, 4, 5));
                result.Add(new ShopStock(Item.Porcelean, 4, 6));
                result.Add(new ShopStock(Item.Weapons, 6, 8));
                result.Add(new ShopStock(Item.Cargo_3, 13, 1));
                break;
        }

        return result;
    }
}
