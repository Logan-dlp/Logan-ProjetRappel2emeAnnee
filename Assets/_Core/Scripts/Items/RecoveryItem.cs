using System;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(PowerUp))]
public class RecoveryItem : MonoBehaviour
{
    private PowerUp _powerUp;
    
    private void Awake()
    {
        _powerUp = GetComponent<PowerUp>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Item>(out Item item))
        {
            switch (item.ItemsType)
            {
                case ItemsType.Sheild:
                    _powerUp.Sheild();
                    break;
                case ItemsType.Damage:
                    _powerUp.Damage();
                    break;
                case ItemsType.Life:
                    _powerUp.Life();
                    break;
                case ItemsType.Coin:
                    _powerUp.Coin();
                    break;
                
            }
            Destroy(collider.gameObject);
        }
    }
}
