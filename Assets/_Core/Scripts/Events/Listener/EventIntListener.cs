using System;
using UnityEngine;
using UnityEngine.Events;

public class EventIntListener : MonoBehaviour
{
    [SerializeField] private EventInt _eventInt;
    [SerializeField] private UnityEvent<int> _callbacks;

    private void OnEnable()
    {
        _eventInt.ActionInt += InvokeEvent;
    }

    public void InvokeEvent(int number)
    {
        _callbacks?.Invoke(number);
    }
}
