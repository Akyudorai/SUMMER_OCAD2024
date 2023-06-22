using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tyrovia 
{
    public static string GetName()
    {
        string result = "Tyrovia";

        return result;
    }

    public static string GetDescription()
    {
        string result = 
            "As you enter the realm of Tyrovia, you feel an air of purpose and readiness.  The nation's imposing citadels and meticulously designed fortifications" +
            "stand as a testament to its military might.  Tyrovia's strategic positioning and rigorous defense training make it a force to be reckoned with," +
            "ensuring the security of its people and the sovereignty of its land.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Leather, 6));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 6));
                result.Add(new ItemCount(Item.Leather, 3));
                break;

            case 3:
                result.Add(new ItemCount(Item.Clothing, 5));
                result.Add(new ItemCount(Item.Gemstone, 3));
                break;

            case 4:
                result.Add(new ItemCount(Item.Oil, 3));
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
                result.Add(new ShopStock(Item.Stone, 3, 2));
                result.Add(new ShopStock(Item.Wood, 3, 2));

                break;

            case 2:
                result.Add(new ShopStock(Item.Wood, 3, 1));
                result.Add(new ShopStock(Item.Sails_1, 1, 6));

                break;

            case 3:
                result.Add(new ShopStock(Item.Clothing, 3, 1));
                result.Add(new ShopStock(Item.Cargo_2, 1, 8));
                break;

            case 4:
                result.Add(new ShopStock(Item.Weapons, 10, 8));
                break;
        }

        return result;
    }
}
