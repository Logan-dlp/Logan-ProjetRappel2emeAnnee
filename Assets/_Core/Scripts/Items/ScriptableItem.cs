using UnityEngine;

public abstract class ScriptableItem : ScriptableObject
{
    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
    }
    
    [SerializeField] private Sprite _sprite;
}
