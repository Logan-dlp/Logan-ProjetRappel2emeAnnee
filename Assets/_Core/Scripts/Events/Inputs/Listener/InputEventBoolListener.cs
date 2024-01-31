using System;
using UnityEngine;
using UnityEngine.Events;

public class InputEventBoolListener : MonoBehaviour
{
    [SerializeField] private InputEventBool _inputEventBool;
    [SerializeField] private UnityEvent<bool> _callbacks;

    private void OnEnable()
    {
        _inputEventBool.ActionBool += InvokeEvent;
    }

    public void InvokeEvent(bool istrue)
    {
        _callbacks?.Invoke(istrue);
    }
}
