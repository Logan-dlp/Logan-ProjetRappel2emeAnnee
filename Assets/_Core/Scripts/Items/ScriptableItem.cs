using UnityEngine;

public abstract class ScriptableItem : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
    }
}
