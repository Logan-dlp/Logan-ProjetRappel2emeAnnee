using System;
using UnityEngine;
using UnityEngine.Events;

public class ScriptableIntListener : MonoBehaviour
{
    [SerializeField] private ScriptableInt _scriptableInt;
    [SerializeField] private UnityEvent<int> _callbacks;

    private void OnEnable()
    {
        _scriptableInt.ActionInt += InvokeEvent;
    }

    private void OnDisable()
    {
        _scriptableInt.ActionInt -= InvokeEvent;
    }

    private void InvokeEvent(int number)
    {
        _callbacks?.Invoke(number);
    }
}
