using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(EventFloat), menuName = "Events/Float")]
public class EventFloat : ScriptableObject
{
    public Action<float> ActionFloat;

    public void InvokeEvent(float number)
    {
        ActionFloat?.Invoke(number);
    }
}
