using System;
using UnityEngine;
using UnityEngine.Events;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _life = 100;
    [SerializeField] private UnityEvent<int> _callbacksLife;
    [SerializeField] private UnityEvent _callbacksDeath;

    private void Update()
    {
        if (_life <= 0)
        {
            _callbacksDeath?.Invoke();
        }
    }

    public void AddLife(int addLife)
    {
        _life += addLife;
        _callbacksLife?.Invoke(_life);
    }

    public void LessLife(int lessLife)
    {
        _life -= lessLife;
        _callbacksLife?.Invoke(_life);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
