using UnityEngine;

public abstract class ScriptableItem : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;
}

