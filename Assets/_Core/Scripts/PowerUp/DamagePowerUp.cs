using System;
using UnityEngine;

[RequireComponent(typeof(ShootBullet))]
public class DamagePowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;

    private ShootBullet _shootBullet;

    private void Awake()
    {
        _shootBullet = GetComponent<ShootBullet>();
    }

    public void ActivePowerUp(ScriptableItem scriptableItem)
    {
        if (scriptableItem == _scriptablePowerUpItem)
        {
            _shootBullet.AddDamage(1);
        }
    }
}
