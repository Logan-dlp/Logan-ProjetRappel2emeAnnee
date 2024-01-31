using System;
using UnityEngine;
using UnityEngine.Events;

public class EventFloatListener : MonoBehaviour
{
    [SerializeField] private EventFloat _eventFloat;
    [SerializeField] private UnityEvent<float> _callbacks;

    private void OnEnable()
    {
        _eventFloat.ActionFloat += InvokEvent;
    }

    public void InvokEvent(float number)
    {
        _callbacks?.Invoke(number);
    }
}
