using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public ScriptableInventoryItem ScriptablePowerUpItem
    {
        get => _scriptableInventoryItem;
        set => _scriptableInventoryItem = value;
    }
    
    [SerializeField] private ScriptableInventoryItem _scriptableInventoryItem;
    
    private SpriteRenderer _spriteRenderer;
    

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _scriptableInventoryItem.Sprite = _spriteRenderer.sprite;
    }
}
