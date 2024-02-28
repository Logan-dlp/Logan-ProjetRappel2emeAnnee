using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(PowerUp))]
public class RecoveryItem : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;
    
    [SerializeField] private ScriptablePowerUpItem sheildScriptablePowerUpItem;
    [SerializeField] private ScriptablePowerUpItem damageScriptablePowerUpItem;
    [SerializeField] private ScriptablePowerUpItem lifeScriptablePowerUpItem;
    [SerializeField] private ScriptablePowerUpItem coinScriptablePowerUpItem;
    
    private PowerUp _powerUp;
    
    private void Awake()
    {
        _powerUp = GetComponent<PowerUp>();
        _scriptableInventory.InventoryList = new List<ScriptableInventoryItem>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<PowerUpItem>(out PowerUpItem powerUpItem))
        {
            if (powerUpItem.ScriptablePowerUpItem == sheildScriptablePowerUpItem)
            {
                _powerUp.Sheild();
            }
            else if (powerUpItem.ScriptablePowerUpItem == damageScriptablePowerUpItem)
            {
                _powerUp.Damage();
            }
            else if (powerUpItem.ScriptablePowerUpItem == lifeScriptablePowerUpItem)
            {
                _powerUp.Life();
            }
            else if (powerUpItem.ScriptablePowerUpItem == coinScriptablePowerUpItem)
            {
                _powerUp.Coin();
            }
            
            Destroy(collider.gameObject);
        }else if (collider.TryGetComponent<InventoryItem>(out InventoryItem inventoryItem))
        {
            _scriptableInventory.InventoryList.Add(inventoryItem.ScriptablePowerUpItem);
            Destroy(collider.gameObject);
        }
    }
}
