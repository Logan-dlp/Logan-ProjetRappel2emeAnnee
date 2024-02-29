using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RecoveryItem : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;
    
    private IPowerUp[] _powerUpArray;
    
    private void Awake()
    {
        _powerUpArray = GetComponents<IPowerUp>();
        _scriptableInventory.InventoryList = new List<ScriptableInventoryItem>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<PowerUpItem>(out PowerUpItem powerUpItem))
        {
            foreach (IPowerUp powerUp in _powerUpArray)
            {
                powerUp.ActivePowerUp(powerUpItem.ScriptablePowerUpItem);
            }
            
            Destroy(collider.gameObject);
        }
        else if (collider.TryGetComponent<InventoryItem>(out InventoryItem inventoryItem))
        {
            _scriptableInventory.InventoryList.Add(inventoryItem.ScriptablePowerUpItem);
            Destroy(collider.gameObject);
        }
    }
}
