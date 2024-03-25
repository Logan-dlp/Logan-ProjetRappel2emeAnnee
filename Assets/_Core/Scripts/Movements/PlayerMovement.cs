using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    public Vector2 Acceleration { get; set; }

    [SerializeField] private float _speedMovement = 3f;

    private Vector2 _movementClampMin;
    private Vector2 _movementClampMax;

    private void Awake()
    {
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        
        Camera mainCamera = Camera.main;
        float screenToWorldHeight = mainCamera.orthographicSize * 2.0f;
        float screenToWorldWidth = screenToWorldHeight * screenSize.x / screenSize.y;

        CircleCollider2D collider = GetComponent<CircleCollider2D>();

        _movementClampMin = new Vector2((-screenToWorldWidth * .5f) + collider.radius, 
                                        (-screenToWorldHeight * .5f) + collider.radius);
        _movementClampMax = new Vector2(screenToWorldWidth * .5f - collider.radius, 
                                        screenToWorldHeight * .5f - collider.radius);
    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + Acceleration.x * _speedMovement * Time.deltaTime, 
                                            _movementClampMin.x, _movementClampMax.x),
                                        Mathf.Clamp(transform.position.y + Acceleration.y * _speedMovement * Time.deltaTime, 
                                            _movementClampMin.y, _movementClampMax.y));
    }
}
