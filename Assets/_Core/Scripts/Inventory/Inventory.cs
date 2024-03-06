using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, ISerializable<InventoryDTO>
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

    public InventoryDTO Serialized()
    {
        return new InventoryDTO
        {
            scriptableInventory = _scriptableInventory,
        };
    }

    public void Deserialized(InventoryDTO dataTransferObject)
    {
        _scriptableInventory = dataTransferObject.scriptableInventory;
    }
}
