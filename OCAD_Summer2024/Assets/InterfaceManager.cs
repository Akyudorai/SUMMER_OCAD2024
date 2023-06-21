using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager Instance;

    [Header("Player Dialogue")]
    public GameObject DialogueBox;
    public TMP_Text PlayerDialogue;
    public bool DialogueActive = false;
    private int DialogueID = 0;
    private int DialogueIndex = 0;    

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

    private void Start()
    {
        LoadOpeningDialogue(0);
    }

    private void Update()
    {
        if (DialogueActive)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                DialogueIndex++;
                
                switch (DialogueID)
                {
                    case 1: LoadOpeningDialogue(DialogueIndex);
                        break;
                }
            }
        }
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


    // Dialogue ID == 1;
    public void LoadOpeningDialogue(int sequence)
    {
        string result = "";

        DialogueActive = true;
        DialogueID = 1;
        DialogueIndex = sequence;

        bool endDialogue = false;
        switch (sequence)
        {
            case 0: result = "As the wind fills the sails, I feel the thrill of hitting the open seas, a vast expanse of untamed adenvture stretching out before me!"; break;
            case 1: result = "Embracing my new career as an importer of goods, I navigate the intricate web of trade routes, weaving connections between cities and cultures, bridging worlds with each shipment."; break;
            case 2: result = "The time has come to make my mark, to prove myself in this realm of commerce. It is at the nearby port that I shall embark on my first trade, laying the foundation for a prosperous future."; break;
            default: endDialogue = true; break;
        }

        if (endDialogue)
        {
            DialogueBox.SetActive(false);
            PlayerDialogue.text = "";
            
            DialogueActive = false;
            DialogueID = 0;
            DialogueIndex = 0;
        } 
        
        else
        {
            if (!DialogueBox.activeInHierarchy)
            {
                DialogueBox.SetActive(true);
            }
            
            PlayerDialogue.text = result;            
        }
        
        
    }
}
