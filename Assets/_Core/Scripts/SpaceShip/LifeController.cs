using System;
using UnityEngine;
using UnityEngine.Events;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _life = 100;
    [SerializeField] private UnityEvent<float> _callbacksLife;
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
        if (_life > 100)
        {
            _life = 100;
        }
        _callbacksLife?.Invoke(_life * .01f);
    }

    public void LessLife(int lessLife)
    {
        _life -= lessLife;
        if (_life < 0)
        {
            _life = 0;
        }
        _callbacksLife?.Invoke(_life * .01f);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
