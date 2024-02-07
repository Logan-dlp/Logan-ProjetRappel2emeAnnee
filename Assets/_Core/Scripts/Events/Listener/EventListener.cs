using System;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField] private Event _event;
    [SerializeField] private UnityEvent _callbaks;

    private void OnEnable()
    {
        _event.Action += InvokeEvent;
    }

    public void InvokeEvent()
    {
        _callbaks?.Invoke();
    }
}
