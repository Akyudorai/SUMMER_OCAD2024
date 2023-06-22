using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mariposa 
{
    public static string GetName()
    {
        string result = "Mariposa";

        return result;
    }

    public static string GetDescription()
    {
        string result = "As you enter Mariposa, you find yourself enveloped in a world of style and beauty.  " +
            "This nation, renowned for its exquisite fashion and the pursuit of aesthetic perfect, beckons you to indulge in a realm " +
            "where creativity knows no bounds.  Mariposa is a haven where artistry, aelegance, and sartorial expression intertwine, " +
            "inviting you to immerse yourself in a tapestry of fashion and allure.";

        return result;
    }

    public static List<ItemCount> GetLevelupRequirement(int i)
    {
        List<ItemCount> result = new List<ItemCount>();

        switch (i)
        {
            case 1:
                result.Add(new ItemCount(Item.Leather, 3));
                break;

            case 2:
                result.Add(new ItemCount(Item.Cotton, 2));
                result.Add(new ItemCount(Item.Silk, 1));
                break;

            case 3:
                result.Add(new ItemCount(Item.Porcelean, 2));
                result.Add(new ItemCount(Item.Wool, 1));
                break;

            case 4:
                result.Add(new ItemCount(Item.Glassware, 5));
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
                result.Add(new ShopStock(Item.Fur, 5, 1));
                break;

            case 2:
                result.Add(new ShopStock(Item.Fur, 3, 2));
                result.Add(new ShopStock(Item.Gemstone, 4, 3));
                break;

            case 3:
                result.Add(new ShopStock(Item.Gemstone, 2, 3));
                result.Add(new ShopStock(Item.Clothing, 4, 5));
                result.Add(new ShopStock(Item.Perfumes, 4, 7));
                break;

            case 4:
                result.Add(new ShopStock(Item.Gemstone, 2, 3));
                result.Add(new ShopStock(Item.Clothing, 3, 5));
                result.Add(new ShopStock(Item.Perfumes, 4, 7));
                result.Add(new ShopStock(Item.Jewelry, 5, 9));
                break;
        }

        return result;
    }
}
