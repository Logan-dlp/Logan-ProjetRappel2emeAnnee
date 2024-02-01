using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventBool), menuName = "Events/Inputs/Bool")]
public class InputEventBool : ScriptableObject
{
    public Action<bool> ActionBool;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ActionBool?.Invoke(true);
        }
        else if (ctx.canceled)
        {
            ActionBool?.Invoke(false);
        }
    }
}
