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
            _inventory.AddInInventory(inventoryItem.ScriptablePowerUpItem);
            Destroy(collider.gameObject);
        }
    }
}
