using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;

    private void Awake()
    {
        _scriptableInventory.InventoryList = new List<ScriptableInventoryItem>();
    }

    public void AddInInventory(ScriptableInventoryItem scriptableInventoryItem)
    {
        _scriptableInventory.InventoryList.Add(scriptableInventoryItem);
    }
}
