using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour, ISerializable<InventoryDTO>
{
    [SerializeField] private ScriptableInventory _scriptableInventory;
    [SerializeField] private ScriptableInventoryItem[] _itemReferenceArray;

    private void Awake()
    {
        _scriptableInventory.InventoryList = new List<ScriptableInventoryItem>();
    }

    public void AddInInventory(ScriptableInventoryItem scriptableItem)
    {
        _scriptableInventory.InventoryList.Add(scriptableItem);
    }

    public InventoryDTO Serialized()
    {
        List<int> itemReference = new();

        for (int i = 0; i < _scriptableInventory.InventoryList.Count; i++)
        {
            for (int j = 0; j < _itemReferenceArray.Length; j++)
            {
                if (_scriptableInventory.InventoryList[i] == _itemReferenceArray[j])
                {
                    itemReference.Add(j);
                }
            }
        }
        
        return new InventoryDTO
        {
            itemNumberReference = itemReference
        };
    }

    public void Deserialized(InventoryDTO dataTransferObject)
    {
        if (dataTransferObject.itemNumberReference != null)
        {
            _scriptableInventory.InventoryList = new();
        }

        foreach (int i in dataTransferObject.itemNumberReference)
        {
            _scriptableInventory.InventoryList.Add(_itemReferenceArray[i]);
        }
    }

    public void RemoveInInventory(ScriptableInventoryItem scriptableInventoryItem)
    {
        _scriptableInventory.InventoryList.Remove(scriptableInventoryItem);
    }
}
