using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Bullet : MonoBehaviour
{
    public LayerMask TargetCollisionMask { get; set; }
    public Vector2 Direction;
    
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private int _damage = 0;
    
    private void Update()
    {
        transform.position += transform.up * _bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (TargetCollisionMask == (TargetCollisionMask & (1 << collider.gameObject.layer)))
        {
            collider.GetComponent<LifeController>().LessLife(_damage);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
