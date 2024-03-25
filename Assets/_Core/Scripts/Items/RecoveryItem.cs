using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RecoveryItem : MonoBehaviour
{
    private IPowerUp[] _powerUpArray;
    private Inventory _inventory;
    
    private void Awake()
    {
        _powerUpArray = GetComponents<IPowerUp>();
        _inventory = GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Item>(out Item item))
        {
            if (item.IsPowerUp)
            {
                foreach (IPowerUp powerUp in _powerUpArray)
                {
                    powerUp.ActivePowerUp(item.ScriptableItem);
                }
            }
            else
            {
                var scriptableInventoryItem = (ScriptableInventoryItem)item.ScriptableItem;
                _inventory.AddInInventory(scriptableInventoryItem);
            }
            
            Destroy(collider.gameObject);
        }
    }
}
