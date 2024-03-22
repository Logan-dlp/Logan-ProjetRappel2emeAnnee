using System;
using UnityEngine;

[RequireComponent(typeof(ShootBullet))]
public class SetEnnemyValue : MonoBehaviour
{
    [SerializeField] private ScriptableEnnemy _scriptableEnnemy;

    private ShootBullet _shootBullet;
    
    private void Awake()
    {
        _shootBullet = GetComponent<ShootBullet>();
    }

    private void Start()
    {
        _shootBullet.BulletDamage = _scriptableEnnemy.EnnemyDamage;
    }
}
