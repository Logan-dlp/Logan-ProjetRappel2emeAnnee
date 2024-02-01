using System;
using System.Collections;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    
    [SerializeField] private GameObject _bullet;
    [SerializeField] private bool _isShoot = false;
    [SerializeField] private float _spawnDistance;
    [SerializeField] private float _shootFrequency;
    [SerializeField] private LayerMask _targetShootMask;

    public bool IsShoot
    {
        get => _isShoot;
        set => _isShoot = value;
    }

    private float _deltaShootTime = 1;


    private void Update()
    {
        if (_deltaShootTime <= 1)
        {
            _deltaShootTime += Time.deltaTime * _shootFrequency;
        }
        
        if (IsShoot && _deltaShootTime >= 1)
        {
            GameObject bullet = Instantiate(_bullet, transform.position + transform.up * _spawnDistance, transform.rotation);
            Bullet bulletComponent = bullet.GetComponent<Bullet>();
            bulletComponent.TargetCollisionMask = _targetShootMask;
            _deltaShootTime = 0;
        }
    }
}
