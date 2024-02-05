using System;
using UnityEngine;

[RequireComponent(typeof(ShootBullet))]
public class SetEnnemyValue : MonoBehaviour
{
    private ShootBullet _shootBullet;

    [SerializeField] private ScriptableEnnemy _scriptableEnnemy;

    private void Awake()
    {
        _shootBullet = GetComponent<ShootBullet>();
    }

    private void Start()
    {
        _shootBullet.IsShoot = true;
        _shootBullet.BulletDamage = _scriptableEnnemy.EnnemyDamage;
    }
}
