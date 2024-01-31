using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventVector2), menuName = "Events/Inputs/Vector2")]
public class InputEventVector2 : ScriptableObject
{
    public Action<Vector2> ActionVector2;

    public void InvokEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            ActionVector2?.Invoke(ctx.ReadValue<Vector2>());
        }
        else if (ctx.canceled)
        {
            ActionVector2?.Invoke(Vector2.zero);
        }
    }
}
