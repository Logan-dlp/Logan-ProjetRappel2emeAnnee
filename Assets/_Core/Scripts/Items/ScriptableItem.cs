using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableItem), menuName = "ScriptableObject/Items")]
public class ScriptableItem : ScriptableObject
{
    public ItemsType ItemsType => _itemsType;
    
    [SerializeField] private ItemsType _itemsType;
}
