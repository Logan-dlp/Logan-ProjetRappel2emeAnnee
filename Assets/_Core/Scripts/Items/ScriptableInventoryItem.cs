using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInventoryItem), menuName = "ScriptableObjects/Inventory Items")]
public class ScriptableInventoryItem : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
    }
}
