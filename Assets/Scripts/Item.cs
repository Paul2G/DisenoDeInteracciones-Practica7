using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Sword,
    Axe
}

[CreateAssetMenu(fileName = "Nuevo Item", menuName = "inventario/Generic item")]
public class Item : ScriptableObject
{
    public Sprite icon = null;

    public virtual void Use()
    {
        Debug.Log("Usando item: " + name);
    }
}
