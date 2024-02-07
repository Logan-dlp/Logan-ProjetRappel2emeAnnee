using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInventory), menuName = "ScriptableObjects/Inventory")]
public class ScriptableInventory : ScriptableObject
{
    [SerializeField] private List<ScriptableItem> _inventoryList;
    public List<ScriptableItem> InventoryList
    {
        get => _inventoryList;
        set => _inventoryList = value;
    }
}
