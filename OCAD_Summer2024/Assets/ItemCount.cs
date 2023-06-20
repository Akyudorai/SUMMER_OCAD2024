using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemCount 
{
    public Item Resource;
    public int Quantity;

    public ItemCount(Item type, int count)
    {
        Resource = type;
        Quantity = count;
    }
}
