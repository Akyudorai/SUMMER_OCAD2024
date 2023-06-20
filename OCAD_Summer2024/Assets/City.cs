using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : Interactable
{
    [Header("City Settings")]
    public string CityName = "Default City";
    public string CityDialogue = "Welcome to our city!";
    public int CityLevel = 1;

    [Header("Upgrade Requirements")]
    public Inventory Requirement;

    [Header("Shop")]
    public Shop CityShop;

    [Header("Level Up Visuals")]
    public GameObject level2Upgrade;

  

    public void Deposit(PlayerController pc, Item item)
    {       
        // If the city upgrade requirement has been met, don't consume more items
        if (Requirement.Count(item) == 0)
        {
            return;
        }

        // We only care about doing anything if the player actually has the required item.
        if (pc.inventory.Has(item))
        {            
            // Remove item from player inventory and add it to city upgrade inventory.                        
            pc.inventory.Remove(item, 1);

            // Remove one from the requirement
            Requirement.Remove(item, 1);

            // Check for an upgrade after everything is done.
            CheckUpgrade();

            // Refresh the Upgrade Panel.
            InterfaceManager.Instance.RefreshCityUpgrade(this);            
        }               
    }

    private void CheckUpgrade()
    {
        bool upgradable = true;

        foreach (ItemCount req in Requirement.Get())
        {
            if (req.Quantity > 0) 
            {
                upgradable = false;
                return;
            }
        }

        if (upgradable)
        {
            Upgrade();
        }        
    }

    private void Upgrade()
    {
        Debug.Log("UPGRADING CITY TO NEXT LEVEL!");

        // Increase the level
        CityLevel++;

        // TODO: Update shop based on level

        //for now this is it. but can include a switch case to change appearance based on which level it is perhaps.
        level2Upgrade.SetActive(true);

        //just change the color for level 3, level 4
        switch (CityLevel)
        {
            case 3: //green?
                {
                    level2Upgrade.GetComponent<Renderer>().material.color = Color.green;
                    break;
                }
            case 4: //yellow?
                {
                    level2Upgrade.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                }
            default:
                break;
        }
        

        //add visual indication

        // TODO: Update upgrade requirements based on level

        // TODO: Update the mesh

        // Refresh the Ciy Panel
        InterfaceManager.Instance.RefreshCityPanel(this);
    }


    public override void Interact(PlayerController pc)
    {       
        InterfaceManager.Instance.ShowCityPanel(this);
    }
}
