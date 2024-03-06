using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInt), menuName = "ScriptableObjects/Int")]
public class ScriptableInt : ScriptableObject
{
    public Action<int> ActionInt;

    private int _number = 0;
    public int Number => _number;

    public void SetNumber(int number)
    {
        _number = number;
        ActionInt?.Invoke(number);
    }

    public void AddNumber(int number)
    {
        _number += number;
        ActionInt?.Invoke(Number);
    }
    
    public void SubstarctNumber(int number)
    {
        _number -= number;
        ActionInt?.Invoke(Number);
    }
}
