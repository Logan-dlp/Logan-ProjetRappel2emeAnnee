using System;
using UnityEngine;
using UnityEngine.Events;

public class InputEventVector2Listener : MonoBehaviour
{
    [SerializeField] private InputEventVector2 _inputEventVector2;
    [SerializeField] private UnityEvent<Vector2> _callbacks;

    private void OnEnable()
    {
        _inputEventVector2.ActionVector2 += InvokeEvent;
    }

    public void InvokeEvent(Vector2 axis)
    {
        _callbacks?.Invoke(axis);
    }
}
