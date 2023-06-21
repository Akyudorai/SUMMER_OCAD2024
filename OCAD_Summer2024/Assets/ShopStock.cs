using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopStock
{
    public Item Resource;
    public int Quantity;
    public int MaxAmount;
    public int Cost;

    public ShopStock(Item item, int max, int cost)
    {
        Resource = item;
        Quantity = max;
        MaxAmount = max;
        Cost = cost;
    }
}
