using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class BuyPowerUp : MonoBehaviour
{
    [SerializeField] private int _price;
    [SerializeField] private ScriptableInt scriptableInt;
    [SerializeField] private UnityEvent<int> _callbacks;

    public void InvokeEvent()
    {
        if (_price <= scriptableInt.Number)
        {
            _callbacks?.Invoke(_price);
        }
    }
}
