using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public int BulletDamage
    {
        get => _bulletDamage;
        set => _bulletDamage = value;
    }
    public bool IsShoot { get; set; }
    
    [SerializeField] private GameObject _bullet;
    [SerializeField] private int _bulletDamage;
    [SerializeField] private float _spawnDistance;
    [SerializeField] private float _shootFrequency;
    [SerializeField] private LayerMask _targetShootMask;

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
            bulletComponent.Damage = _bulletDamage;
            _deltaShootTime = 0;
        }
    }

    public void AddDamage(int addDamage)
    {
        _bulletDamage += addDamage;
    }
}
