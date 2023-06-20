using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shop
{
    [Header("Shop Settings")]
    public float RestockTime = 1.0f;
    private float time = 0.0f;

    [Header("Shop Stock")]
    // Populate this list with whatever the city should trade regularly.
    public List<ShopStock> Inventory = new List<ShopStock>();


    private void Tick()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = RestockTime;
            RefreshStock();
        }
    }

    private void RefreshStock()
    {
        // NOTE: We could potentially do a random roll for what shop items are available and quantity.
        foreach (ShopStock stock in Inventory)
        {
            stock.Quantity = stock.MaxAmount;
        }
    }

    public void Purchase(PlayerController pc, ShopStock stock)
    {
        Debug.Log("Purchase Called");

        if (stock.Quantity > 0 && pc.Gold >= stock.Cost)
        {
            pc.Gold -= stock.Cost;
            //update the UI too
            pc.UpdateGoldText();
            pc.inventory.Add(stock.Resource, 1);
            stock.Quantity -= 1;

            InterfaceManager.Instance.RefreshShop(this);
        }
    }
    
}
