using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 Acceleration { get; set; }

    [SerializeField] private float _speedMovement = 3f;

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + Acceleration.x * _speedMovement * Time.deltaTime, -8, 8),
            Mathf.Clamp(transform.position.y + Acceleration.y * _speedMovement * Time.deltaTime, -5, 5));
    }
}
