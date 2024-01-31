using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 Acceleration { get; set; }

    [SerializeField] private float _speedMovement = 3f;

    private void FixedUpdate()
    {
        Vector2 acceleration = new Vector2(-Acceleration.y, Acceleration.x);
        transform.Translate(acceleration * _speedMovement * Time.fixedDeltaTime);
    }
}
