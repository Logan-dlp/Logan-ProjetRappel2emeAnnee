using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private UnityEvent _callbaksSheild;
    [SerializeField] private UnityEvent _callbaksDamage;
    [SerializeField] private UnityEvent _callbaksLife;
    [SerializeField] private UnityEvent _callbaksCoin;
    
    public void Sheild()
    {
        _callbaksSheild?.Invoke();
    }
    
    public void Damage()
    {
        _callbaksDamage?.Invoke();
    }

    public void Life()
    {
        _callbaksLife?.Invoke();
    }

    public void Coin()
    {
        _callbaksCoin?.Invoke();
    }
}
