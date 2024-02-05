using System;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(Rigidbody2D))]
public class Item : MonoBehaviour
{
    public ItemsType ItemsType { get; set; }
    
    [SerializeField] private ScriptableItem _scriptableItem;

    private void Start()
    {
        ItemsType = _scriptableItem.ItemsType;
    }
}
