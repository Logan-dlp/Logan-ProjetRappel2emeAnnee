using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ScriptableIntController : MonoBehaviour
{
    [SerializeField] private ScriptableInt scriptableInt;
    [SerializeField] private UnityEvent<int> _callbacksCoin;

    private void Start()
    {
        scriptableInt.SetNumber(0);
    }

    public void Add(int addCoin)
    {
        scriptableInt.AddNumber(addCoin);
        _callbacksCoin?.Invoke(scriptableInt.Number);
    }

    public void Less(int lessCoin)
    {
        scriptableInt.SubstarctNumber(lessCoin);
        _callbacksCoin.Invoke(scriptableInt.Number);
    }
}
