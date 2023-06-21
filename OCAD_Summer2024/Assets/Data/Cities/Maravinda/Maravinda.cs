using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maravinda 
{
    public static string GetName()
    {
        string result = "Maravinda";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter Maravinda, prepare to be transported to a realm of mysticism and spiritual awakening." +
            "This nation is adorned with sacred sites and holds the promise of self-discovery and inner transformation." +
            "Maravinda invites you to embark on a soul stirring journey, where echoes of ancient rituals and the serenity" +
            " of its landscapes create an atmosphere of transcendence.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Stone, 1));
                result.Add(new ItemCount(Item.Wood, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Wood, 6));
                result.Add(new ItemCount(Item.Stone, 5));
                break;

            case 3:
                result.Add(new ItemCount(Item.Wood, 4));
                result.Add(new ItemCount(Item.Stone, 2));
                result.Add(new ItemCount(Item.Glassware, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Wood, 4));
                result.Add(new ItemCount(Item.Glassware, 3));
                result.Add(new ItemCount(Item.Relics, 1));
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
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Wood, 4, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Cotton, 4, 4));
                result.Add(new ShopStock(Item.Silk, 4, 5));
                break;

            case 3:
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Cotton, 4, 4));
                result.Add(new ShopStock(Item.Silk, 4, 5));
                result.Add(new ShopStock(Item.Perfumes, 4, 7));
                break;

            case 4:
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Cotton, 4, 4));
                result.Add(new ShopStock(Item.Silk, 4, 5));
                result.Add(new ShopStock(Item.Perfumes, 4, 7));
                result.Add(new ShopStock(Item.Porcelean, 2, 6));
                break;
        }

        return result;
    }
}
