using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableItem), menuName = "ScriptableObjects/Items")]
public class ScriptableItem : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
    }
}
