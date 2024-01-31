using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Bullet : MonoBehaviour
{
    public LayerMask TargetCollisionMask { get; set; }
    
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private int _damage = 0;
    
    private void FixedUpdate()
    {
        transform.Translate(-transform.right * _bulletSpeed * Time.fixedDeltaTime);
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
