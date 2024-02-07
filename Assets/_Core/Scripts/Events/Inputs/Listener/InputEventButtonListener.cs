using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputEventButtonListener : MonoBehaviour
{
    [SerializeField] private InputEventButton _inputEventButton;
    [SerializeField] private UnityEvent _callbacks;

    private void OnEnable()
    {
        _inputEventButton.Action += InvokeEvent;
    }

    private void OnDisable()
    {
        _inputEventButton.Action -= InvokeEvent;
    }

    public void InvokeEvent()
    {
        _callbacks?.Invoke();
    }
}
