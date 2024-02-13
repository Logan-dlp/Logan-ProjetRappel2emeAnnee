using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInt), menuName = "ScriptableObjects/Int")]
public class ScriptableInt : ScriptableObject
{
    public int Number { get; set; } = 0;
}
