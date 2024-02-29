using UnityEngine;

public class InventoryItem : Item
{
    private SpriteRenderer _spriteRenderer;
    
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        base._scriptableItem.Sprite = _spriteRenderer.sprite;
    }
}
