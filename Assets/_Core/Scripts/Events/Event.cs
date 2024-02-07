using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(Event), menuName = "Events/Event")]
public class Event : ScriptableObject
{
    public Action Action;

    public void InvokeEvent()
    {
        Action?.Invoke();
    }
}
