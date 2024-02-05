using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class RecoveryItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Item>(out Item item))
        {
            switch (item.ItemsType)
            {
                case ItemsType.Sheild:
                    Sheild(); 
                    break;
                case ItemsType.Damage:
                    Damage();
                    break;
                case ItemsType.Life:
                    Life();
                    break;
                case ItemsType.Coin:
                    Coin();
                    break;
                
            }
            Destroy(collider.gameObject);
        }
    }

    private void Sheild()
    {
        Debug.Log("add sheild");
    }

    private void Damage()
    {
        Debug.Log("Add damage");
    }

    private void Life()
    {
        Debug.Log("add Life");
    }

    private void Coin()
    {
        Debug.Log("add Coin");
    }
}
