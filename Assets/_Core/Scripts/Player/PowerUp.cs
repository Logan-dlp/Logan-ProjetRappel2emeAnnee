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
        Debug.Log("add sheild");
    }
    
    public void Damage()
    {
        _callbaksDamage?.Invoke();
        Debug.Log("Add damage");
    }

    public void Life()
    {
        _callbaksLife?.Invoke();
        Debug.Log("add Life");
    }

    public void Coin()
    {
        _callbaksCoin?.Invoke();
        Debug.Log("add Coin");
    }
}
