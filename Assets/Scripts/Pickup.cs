using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public Item item;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            Debug.LogWarning("No se encontro el inventario");
        }
    }

    void OnMouseDown ()
    {
        Debug.Log("Levantando item");
        inventory.Add(item);
        Destroy(gameObject);    
    } 
}
