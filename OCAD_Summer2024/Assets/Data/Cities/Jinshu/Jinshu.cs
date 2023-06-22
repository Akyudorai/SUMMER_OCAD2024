using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jinshu 
{
    public static string GetName()
    {
        string result = "Jinshu";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter the remarkable nation of Jinshu, a captivating fusion of two ancient arts envolops your senses." +
            "The air resonates with the echoes of disciplined movements and the rhthmic brushstrokes of calligraphy.  Stately dojos and seren calligraphy " +
            "studios line the streets, their doors adorned with intricate martial arts insignias and elegant inked scrolls. " +
            "Jinshu is a realm where the mastery of both martial arts and calligraphy intertwine, and it beckons you to witness the harmonious " +
            "coalescensce of physical prowess and artistic expression in its very essence.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Paper, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Water, 2));
                result.Add(new ItemCount(Item.Paper, 2));
                break;

            case 3:
                result.Add(new ItemCount(Item.Glassware, 3));
                result.Add(new ItemCount(Item.Alcohol, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Paper, 2));
                result.Add(new ItemCount(Item.Porcelean, 3));
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
                result.Add(new ShopStock(Item.Fish, 4, 2));
                result.Add(new ShopStock(Item.Wood, 5, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Fish, 4, 2));
                result.Add(new ShopStock(Item.Wood, 5, 2));
                result.Add(new ShopStock(Item.Silk, 4, 7));
                break;

            case 3:
                result.Add(new ShopStock(Item.Fish, 4, 2));
                result.Add(new ShopStock(Item.Silk, 6, 7));
                result.Add(new ShopStock(Item.Medicine, 2, 5));
                break;

            case 4:
                result.Add(new ShopStock(Item.Fish, 2, 2));
                result.Add(new ShopStock(Item.Wood, 3, 2));
                result.Add(new ShopStock(Item.Silk, 6, 7));
                result.Add(new ShopStock(Item.Medicine, 5, 5));
                result.Add(new ShopStock(Item.Jewelry, 3, 14));
                result.Add(new ShopStock(Item.Relics, 5, 8));
                break;
        }

        return result;
    }
}
