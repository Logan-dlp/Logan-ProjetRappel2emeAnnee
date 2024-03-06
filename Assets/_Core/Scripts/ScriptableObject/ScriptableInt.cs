using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInt), menuName = "ScriptableObjects/Int")]
public class ScriptableInt : ScriptableObject
{
    public Action<int> ActionInt;
    public int Number { get; set; } = 0;

    public void InvokeEvent(int number)
    {
        Number = number;
        ActionInt?.Invoke(number);
    }

    public void AddNumberEvent(int number)
    {
        Number += number;
        ActionInt?.Invoke(Number);
    }
}
