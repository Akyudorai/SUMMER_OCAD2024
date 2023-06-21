using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum CityEnum
{
    Avalora,
    Caledonia,
    Delphoria,
    Eldorana,
    Jinshu,
    Lumina,
    Maravinda,
    Mariposa,
    Nalanda,
    Novoria,
    Samarkanta,
    Solaterra,
    Sylvestria,
    Tyrovia,
    Virelia,
    Xanadune,
    Zemuria, 
    Zenithia
}

public class City : Interactable
{
    [Header("City Settings")]
    public CityEnum ID;
    public string CityName = "Default City";
    public string CityDialogue = "Welcome to our city!";
    public int CityLevel = 1;

    [Header("Upgrade Requirements")]
    public Inventory Requirement;

    [Header("Shop")]
    public Shop CityShop;

    [Header("Level Up Visuals")]
    public GameObject level2Upgrade;

    private void Start()
    {
        // Initialize City based on CityEnum
        Initialize(ID);   
    }

    private void Initialize(CityEnum id)
    {
        switch (id)
        {
            case CityEnum.Avalora: 
                CityName = Avalora.GetName();
                CityDialogue = Avalora.GetDescription();
                Requirement.Set(Avalora.GetLevelupRequirement(1));
                CityShop.Inventory = Avalora.GetShopStock(1);

                break;
            case CityEnum.Caledonia:
                CityName = Caledonia.GetName();
                CityDialogue = Caledonia.GetDescription();
                Requirement.Set(Caledonia.GetLevelupRequirement(1));
                CityShop.Inventory = Caledonia.GetShopStock(1); 
                break;
            case CityEnum.Delphoria:
                CityName = Delphoria.GetName();
                CityDialogue = Delphoria.GetDescription();
                Requirement.Set(Delphoria.GetLevelupRequirement(1));
                CityShop.Inventory = Delphoria.GetShopStock(1); 
                break;
            case CityEnum.Eldorana:
                CityName = Eldorana.GetName();
                CityDialogue = Eldorana.GetDescription();
                Requirement.Set(Eldorana.GetLevelupRequirement(1));
                CityShop.Inventory = Eldorana.GetShopStock(1); 
                break;
            case CityEnum.Jinshu:
                CityName = Jinshu.GetName();
                CityDialogue = Jinshu.GetDescription();
                Requirement.Set(Jinshu.GetLevelupRequirement(1));
                CityShop.Inventory = Jinshu.GetShopStock(1); 
                break;
            case CityEnum.Lumina:
                CityName = Lumina.GetName();
                CityDialogue = Lumina.GetDescription();
                Requirement.Set(Lumina.GetLevelupRequirement(1));
                CityShop.Inventory = Lumina.GetShopStock(1); 
                break;
            case CityEnum.Maravinda:
                CityName = Maravinda.GetName();
                CityDialogue = Maravinda.GetDescription();
                Requirement.Set(Maravinda.GetLevelupRequirement(1));
                CityShop.Inventory = Maravinda.GetShopStock(1); 
                break;
            case CityEnum.Mariposa:
                CityName = Mariposa.GetName();
                CityDialogue = Mariposa.GetDescription();
                Requirement.Set(Mariposa.GetLevelupRequirement(1));
                CityShop.Inventory = Mariposa.GetShopStock(1); 
                break;
            case CityEnum.Nalanda:
                CityName = Nalanda.GetName();
                CityDialogue = Nalanda.GetDescription();
                Requirement.Set(Nalanda.GetLevelupRequirement(1));
                CityShop.Inventory = Nalanda.GetShopStock(1); 
                break;
            case CityEnum.Novoria:
                CityName = Novoria.GetName();
                CityDialogue = Novoria.GetDescription();
                Requirement.Set(Novoria.GetLevelupRequirement(1));
                CityShop.Inventory = Novoria.GetShopStock(1); 
                break;
            case CityEnum.Samarkanta:
                CityName = Samarkanta.GetName();
                CityDialogue = Samarkanta.GetDescription();
                Requirement.Set(Samarkanta.GetLevelupRequirement(1));
                CityShop.Inventory = Samarkanta.GetShopStock(1); 
                break;
            case CityEnum.Solaterra:
                CityName = Solaterra.GetName();
                CityDialogue = Solaterra.GetDescription();
                Requirement.Set(Solaterra.GetLevelupRequirement(1));
                CityShop.Inventory = Solaterra.GetShopStock(1); 
                break;
            case CityEnum.Sylvestria:
                CityName = Sylvestria.GetName();
                CityDialogue = Sylvestria.GetDescription();
                Requirement.Set(Sylvestria.GetLevelupRequirement(1));
                CityShop.Inventory = Sylvestria.GetShopStock(1); 
                break;
            case CityEnum.Tyrovia:
                CityName = Tyrovia.GetName();
                CityDialogue = Tyrovia.GetDescription();
                Requirement.Set(Tyrovia.GetLevelupRequirement(1));
                CityShop.Inventory = Tyrovia.GetShopStock(1); 
                break;
            case CityEnum.Virelia:
                CityName = Virelia.GetName();
                CityDialogue = Virelia.GetDescription();
                Requirement.Set(Virelia.GetLevelupRequirement(1));
                CityShop.Inventory = Virelia.GetShopStock(1); 
                break;
            case CityEnum.Xanadune:
                CityName = Xanadune.GetName();
                CityDialogue = Xanadune.GetDescription();
                Requirement.Set(Xanadune.GetLevelupRequirement(1));
                CityShop.Inventory = Xanadune.GetShopStock(1); 
                break;
            case CityEnum.Zemuria:
                CityName = Zemuria.GetName();
                CityDialogue = Zemuria.GetDescription();
                Requirement.Set(Zemuria.GetLevelupRequirement(1));
                CityShop.Inventory = Zemuria.GetShopStock(1); 
                break;
            case CityEnum.Zenithia:
                CityName = Zenithia.GetName();
                CityDialogue = Zenithia.GetDescription();
                Requirement.Set(Zenithia.GetLevelupRequirement(1));
                CityShop.Inventory = Zenithia.GetShopStock(1); 
                break;
        }
    }

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
        CityShop.Inventory = Sylvestria.GetShopStock(CityLevel);
        
        // TODO: Update upgrade requirements based on level
        Requirement.Set(Sylvestria.GetLevelupRequirement(CityLevel));        


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

        // TODO: Update the mesh

        // Refresh the Ciy Panel
        InterfaceManager.Instance.RefreshCityPanel(this);
    }


    public override void Interact(PlayerController pc)
    {       
        InterfaceManager.Instance.ShowCityPanel(this);
    }
}
