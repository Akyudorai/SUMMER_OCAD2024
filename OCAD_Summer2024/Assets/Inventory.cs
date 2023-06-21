using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[System.Serializable]
public class Inventory
{
    [Header("Inventory")]
    [SerializeField] private List<ItemCount> CurrentInventory = new List<ItemCount>();
    public int MaxInventory = 0;


    public void Set(List<ItemCount> result)
    {
        CurrentInventory = result;
    }

    // Add X items to the inventory
    public void Add(Item item, int count)
    {       
        int total = 0;
        foreach (ItemCount ic in CurrentInventory)
        {
            total += ic.Quantity;
        }

        if (MaxInventory != 0 && total >= MaxInventory)
        {
            // MAX INVENTORY REACHED
            return;
        }


        bool isNewItem = true;
        foreach(ItemCount ic in CurrentInventory)
        {
            if (ic.Resource == item)
            {
                ic.Quantity += count;
                isNewItem = false;
            }
        }

        if (isNewItem)
        {
            CurrentInventory.Add(new ItemCount(item, count));
        }
    }

    // Remove X items from the inventory.
    public void Remove(Item item, int count)
    {
        foreach (ItemCount ic in CurrentInventory)
        {
            if (ic.Resource == item)
            {
                ic.Quantity -= count;
            }
        }
    }

    // Check if the inventory contains a specific item
    // EDIT:  Now that I think about it, you could just use the Count function to see if it exists or not.
    public bool Has(Item item)
    {
        foreach (ItemCount ic in CurrentInventory)
        {
            if (ic.Resource == item)
            {
               return true;            
            }
        }

        return false;
    }

    // Get the number of a specific item in the inventory
    public int Count(Item item)
    {
        foreach (ItemCount ic in CurrentInventory)
        {
            if (ic.Resource == item)
            {
                return ic.Quantity;
            }
        }

        return 0;
    }

    // Return the entire list.
    public List<ItemCount> Get()
    {
        return CurrentInventory;
    }
}
