using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(PowerUp))]
public class RecoveryItem : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;
    
    [SerializeField] private ScriptableItem _sheildScriptableItem;
    [SerializeField] private ScriptableItem _damageScriptableItem;
    [SerializeField] private ScriptableItem _lifeScriptableItem;
    [SerializeField] private ScriptableItem _coinScriptableItem;
    
    private PowerUp _powerUp;
    
    private void Awake()
    {
        _powerUp = GetComponent<PowerUp>();
        _scriptableInventory.InventoryList = new List<ScriptableItem>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Item>(out Item item))
        {
            if (item.ScriptableItem == _sheildScriptableItem)
            {
                _powerUp.Sheild();
            }
            else if (item.ScriptableItem == _damageScriptableItem)
            {
                _powerUp.Damage();
            }
            else if (item.ScriptableItem == _lifeScriptableItem)
            {
                _powerUp.Life();
            }
            else if (item.ScriptableItem == _coinScriptableItem)
            {
                _powerUp.Coin();
            }
            else
            {
                _scriptableInventory.InventoryList.Add(item.ScriptableItem);
            }
            Destroy(collider.gameObject);
        }
    }
}
