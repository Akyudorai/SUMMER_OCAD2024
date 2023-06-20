using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager Instance;

    [Header("City Interface")]
    public GameObject CityCanvas;
    public TMP_Text CityHeader;
    public TMP_Text CityDialogue;
    public GameObject CityShopPanel;
    public GameObject CityUpgradePanel;

    [Header("Prefabs")]
    public GameObject ShopButtonPrefab;
    public GameObject UpgradeButtonPrefab;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(this.gameObject);
        }

        ClearCityPanel();
    }

    public void ShowCityPanel(City c)
    {
        if (c == null) return;

        // Switch Cursor Mode
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        // Load the City Header
        CityHeader.text = c.CityName + " - Level " + c.CityLevel;

        // Load the City Dialogue
        CityDialogue.text = c.CityDialogue;        

        // Load the Shop Data
        foreach (ShopStock stock in c.CityShop.Inventory)
        {
            GameObject shopBtn = Instantiate(ShopButtonPrefab, CityShopPanel.transform);
            shopBtn.GetComponentInChildren<TMP_Text>().text = stock.Resource.ToString() + " ("+stock.Quantity+") - " + stock.Cost + "g"; 
            shopBtn.GetComponent<Button>().onClick.AddListener(delegate() { c.CityShop.Purchase(PlayerController.Main, stock); });
        }

        // Load the Upgrade Data       
        foreach (ItemCount ic in c.Requirement.Get())
        {
            GameObject upgradeBtn = Instantiate(UpgradeButtonPrefab, CityUpgradePanel.transform);
            upgradeBtn.GetComponentInChildren<TMP_Text>().text = ic.Resource.ToString() + "\n(" + ic.Quantity +")";
            upgradeBtn.GetComponent<Button>().onClick.AddListener(delegate() { c.Deposit(PlayerController.Main, ic.Resource); });
        }

        // Toggle The Canvas
        CityCanvas.SetActive(true);
    }
    
    public void RefreshCityPanel(City c)
    {
        ClearCityPanel();
        ShowCityPanel(c);
    }

    public void RefreshCityUpgrade(City c)
    {
        // Clear the Upgrade Data
        foreach (Transform child in CityUpgradePanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Load the Upgrade Data       
        foreach (ItemCount ic in c.Requirement.Get())
        {
            GameObject upgradeBtn = Instantiate(UpgradeButtonPrefab, CityUpgradePanel.transform);
            upgradeBtn.GetComponentInChildren<TMP_Text>().text = ic.Resource.ToString() + "\n(" + ic.Quantity + ")";
            upgradeBtn.GetComponent<Button>().onClick.AddListener(delegate () { c.Deposit(PlayerController.Main, ic.Resource); });
        }
    }

    public void RefreshShop(Shop s)
    {
        // Clear the Shop Data
        foreach (Transform child in CityShopPanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Load the Shop Data
        foreach (ShopStock stock in s.Inventory)
        {
            GameObject shopBtn = Instantiate(ShopButtonPrefab, CityShopPanel.transform);
            shopBtn.GetComponentInChildren<TMP_Text>().text = stock.Resource.ToString() + " (" + stock.Quantity + ") - " + stock.Cost + "g";
            shopBtn.GetComponent<Button>().onClick.AddListener(delegate () { s.Purchase(PlayerController.Main, stock); });
        }
    }

    public void ClearCityPanel()
    {
        // Switch Cursor Mode
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Clear the CityHeader
        CityHeader.text = "";

        // Clear the Dialogue
        CityDialogue.text = "";

        // Clear the Shop Data
        foreach (Transform child in CityShopPanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Clear the Upgrade Data
        foreach (Transform child in CityUpgradePanel.transform)
        {
            Destroy(child.gameObject);
        }

        // Toggle The Canvas
        CityCanvas.SetActive(false);
    }
}
