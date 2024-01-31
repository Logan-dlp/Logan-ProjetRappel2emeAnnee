using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private Vector2 _spaceMovementMin;
    [SerializeField] private Vector2 _spaceMovementMax;

    private Vector2[] _randomPosition;

    private void Start()
    {
        _randomPosition = new Vector2[5];
        for (int i = 0; i < _randomPosition.Length; i++)
        {
            _randomPosition[i] = new Vector2(Random.Range(_spaceMovementMin.x, _spaceMovementMax.x),
                                                Random.Range(_spaceMovementMin.y, _spaceMovementMax.y));
        }
    }

    private void Update()
    {
        for (int i = 0; i < _randomPosition.Length;)
        {
            transform.position = Vector2.Lerp(transform.position, _randomPosition[i], _speedMovement);
            if (Vector2.Distance(transform.position, _randomPosition[i]) < .3f)
            {
                i++;
            }
        }
    }
}
