using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    private Inventory inventory;
    
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            return;
        }
        inventoryUIPanel.SetActive(false);
        inventory.onChange += UpdateUI;
    }

    void Update()
    {   
        //Input.GetKeyDown(KeyCode.Q)
        if (CrossPlatformInputManager.GetButtonDown("Fire3"))
        {
            inventoryUIPanel.SetActive(!inventoryUIPanel.activeSelf);
            UpdateUI();
        }
        else if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
           inventoryUIPanel.SetActive(false);
            UpdateUI(); 
        }
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        for (int i=0; i<slots.Length; i++)
        {
            if (i<inventory.items.Count)
            {
                slots[i].SetItem(inventory.items[i]);
            }
            else
            {
                slots[i].Clear();
            }
        }
    }
}
