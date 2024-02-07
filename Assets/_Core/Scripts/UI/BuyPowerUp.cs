using UnityEngine;
using UnityEngine.Events;

public class BuyPowerUp : MonoBehaviour
{
    [SerializeField] private int _price;
    [SerializeField] private ScriptableCoin _scriptableCoin;
    [SerializeField] private UnityEvent<int> _callbacks;

    public void InvokeEvent()
    {
        if (_price <= _scriptableCoin.Coin)
        {
            _callbacks?.Invoke(_price);
        }
    }
}
