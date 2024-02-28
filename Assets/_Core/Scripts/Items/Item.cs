using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(
    typeof(Collider2D),
    typeof(Rigidbody2D),
    typeof(SpriteRenderer))]
public class Item : MonoBehaviour
{
    public ScriptableItem ScriptableItem
    {
        get => _scriptableItem;
        set => _scriptableItem = value;
    }
    
    [SerializeField] private ScriptableItem _scriptableItem;
    
    private SpriteRenderer _spriteRenderer;
    

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _scriptableItem.Sprite = _spriteRenderer.sprite;
    }
}
