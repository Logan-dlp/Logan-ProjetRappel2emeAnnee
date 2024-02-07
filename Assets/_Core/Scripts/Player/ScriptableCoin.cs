using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableCoin), menuName = "ScriptableObjects/Coin")]
public class ScriptableCoin : ScriptableObject
{
    public int Coin { get; set; } = 0;
}
