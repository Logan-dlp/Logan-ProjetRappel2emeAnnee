using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventButton), menuName = "Events/Inputs/Button")]
public class InputEventButton : ScriptableObject
{
    public Action Action;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Action?.Invoke();
        }
    }
}
