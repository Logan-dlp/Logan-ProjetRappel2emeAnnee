using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;

    private void Awake()
    {
        _scriptableInventory.InventoryList = new List<ScriptableItem>();
    }

    public void AddInInventory(ScriptableItem scriptableItem)
    {
        _scriptableInventory.InventoryList.Add(scriptableItem);
    }
}
