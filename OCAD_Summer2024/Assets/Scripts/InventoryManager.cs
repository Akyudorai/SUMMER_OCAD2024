using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    

    public List<TMP_Text> itemSlots;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i< itemSlots.Count; i++)
        {
            itemSlots[i].text = ""; //empty text to start with, no items
        }
    }

    public void AddToSlot(string item)
    {
        //find next available empty slot
        //probably more efficient way to do this, but for now, just do it like this
        for (int i=0; i< itemSlots.Count; i++)
        {
            //if the text is empty
            if (itemSlots[i].text == "")
            {
                //place the item here
                itemSlots[i].text = item;
                //break so we don't add any more
                break;
            }
        }
       
    }

    public void RemoveFromSlot(string item)
    {
        //find where this item is
        //probably more efficient way to do this, but for now, just do it like this
        //take it frm behind
        for (int i=0; i<itemSlots.Count; i++)
        {
            //if this text has the item we want to remove
            if (itemSlots[itemSlots.Count-1-i].text == item)
            {
                //empty this slot
                itemSlots[itemSlots.Count-1-i].text = "";
                //break so we don't continue
                break;
            }
        }
    }
}
