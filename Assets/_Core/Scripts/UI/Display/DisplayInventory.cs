using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;

    public void RefreshInventory()
    {
        
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < _scriptableInventory.InventoryList.Count; i++)
        {
            GameObject newItemInventory = Instantiate(_scriptableInventory.InventoryList[i].ButtonObject, transform);
            newItemInventory.AddComponent<Image>().sprite = _scriptableInventory.InventoryList[i].Sprite;
            newItemInventory.GetComponent<ClickableInventory>().ScriptableInventoryItem = _scriptableInventory.InventoryList[i];
        }
    }
}
