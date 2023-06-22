using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solaterra 
{
    public static string GetName()
    {
        string result = "Solaterra";

        return result;
    }

    public static string GetDescription()
    {
        string result = "Welcome to Solaterra, a vibrant nastion nestled amidst lush landscapes and steeped in rich culteral heritage.\n\n" +
            "Solaterra prides itself on its emphasis of sustainability and renewable energy sources.  The nation has made significant strides in harnessing" +
            "solar, wind, and hydroelectric power, earning it the nickname 'The Land of Sustainable Energy.'  Solaterra's commitment to the environmental preservation" +
            "is evident in its extensive green initiatives, such as vast nature reserves, eco-friendly infrastructure, and a strong focus on reducing carbon emissions.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Fish, 3));
                result.Add(new ItemCount(Item.Stone, 2));
                break;

            case 2:
                result.Add(new ItemCount(Item.Metal, 3));
                result.Add(new ItemCount(Item.Gemstone, 1));
                break;

            case 3:
                result.Add(new ItemCount(Item.Metal, 10));
                break;

            case 4:
                result.Add(new ItemCount(Item.Machinery, 4));
                result.Add(new ItemCount(Item.Chemicals, 1));
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
                result.Add(new ShopStock(Item.Meat, 3, 2));
                result.Add(new ShopStock(Item.Water, 5, 2));
                break;

            case 2:
                result.Add(new ShopStock(Item.Meat, 3, 2));
                result.Add(new ShopStock(Item.Water, 5, 2));
                result.Add(new ShopStock(Item.Cotton, 3, 1));
                break;

            case 3:
                result.Add(new ShopStock(Item.Water, 3, 2));
                result.Add(new ShopStock(Item.Cotton, 3, 1));
                result.Add(new ShopStock(Item.Medicine, 3, 5));
                result.Add(new ShopStock(Item.Sails_2, 1, 13));
                break;

            case 4:
                result.Add(new ShopStock(Item.Water, 3, 2));
                result.Add(new ShopStock(Item.Cotton, 3, 1));
                result.Add(new ShopStock(Item.Medicine, 3, 5));
                result.Add(new ShopStock(Item.Circuitry, 6, 8));
                break;
        }

        return result;
    }
}
