using System;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(PowerUp))]
public class RecoveryItem : MonoBehaviour
{
    [SerializeField] private ScriptableItem _sheildScriptableItem;
    [SerializeField] private ScriptableItem _damageScriptableItem;
    [SerializeField] private ScriptableItem _lifeScriptableItem;
    [SerializeField] private ScriptableItem _coinScriptableItem;
    
    private PowerUp _powerUp;
    
    private void Awake()
    {
        _powerUp = GetComponent<PowerUp>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Item>(out Item item))
        {
            if (item._scriptableItem == _sheildScriptableItem)
            {
                _powerUp.Sheild();
            }
            else if (item._scriptableItem == _damageScriptableItem)
            {
                _powerUp.Damage();
            }
            else if (item._scriptableItem == _lifeScriptableItem)
            {
                _powerUp.Life();
            }
            else if (item._scriptableItem == _coinScriptableItem)
            {
                _powerUp.Coin();
            }
            Destroy(collider.gameObject);
        }
    }
}
