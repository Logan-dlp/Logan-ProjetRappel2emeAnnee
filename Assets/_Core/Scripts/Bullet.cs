using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Bullet : MonoBehaviour
{
    public LayerMask TargetCollisionMask { get; set; }
    public int Damage { get; set; }
    
    [SerializeField] private float _bulletSpeed;
    
    private void Update()
    {
        transform.position += transform.up * _bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (TargetCollisionMask == (TargetCollisionMask & (1 << collider.gameObject.layer)))
        {
            collider.GetComponent<LifeController>().LessLife(Damage);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
