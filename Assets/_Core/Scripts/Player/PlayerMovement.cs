using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 Acceleration { get; set; }

    [SerializeField] private float _speedMovement = 3f;

    private void FixedUpdate()
    {
        transform.Translate(Acceleration * _speedMovement * Time.fixedDeltaTime);
    }
}
