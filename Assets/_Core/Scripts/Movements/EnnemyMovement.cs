using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _rotationOffset;
    [SerializeField] private Vector2 _spaceMovementMin;
    [SerializeField] private Vector2 _spaceMovementMax;

    private Transform _playerTransform;
    private Vector2[] _randomPosition;
    private int _increment = 0;

    private void Start()
    {
        _playerTransform = GameObject.FindAnyObjectByType<PlayerMovement>().transform;
        
        _randomPosition = new Vector2[5];
        for (int i = 0; i < _randomPosition.Length; i++)
        {
            _randomPosition[i] = new Vector2(Random.Range(_spaceMovementMin.x, _spaceMovementMax.x),
                                                Random.Range(_spaceMovementMin.y, _spaceMovementMax.y));
        }
    }

    private void Update()
    {
        // Position
        transform.position =
            Vector2.Lerp(transform.position, _randomPosition[_increment], _speedMovement * Time.deltaTime);

        if (Vector2.Distance(transform.position, _randomPosition[_increment]) < .3f)
        {
            if (_increment+1 >= _randomPosition.Length)
            {
                _increment = 0;
            }
            else
            {
                _increment++;
            }
        }
        
        // Rotation
        Vector2 direction = (_playerTransform.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(transform.forward * (angle - _rotationOffset));
    }
}
