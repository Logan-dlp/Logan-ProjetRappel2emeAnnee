using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(EventInt), menuName = "Events/Int")]
public class EventInt : ScriptableObject
{
    public Action<int> ActionInt;

    public void InvokeEvent(int number)
    {
        ActionInt?.Invoke(number);
    }
}
