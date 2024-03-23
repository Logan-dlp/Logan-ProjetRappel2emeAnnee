using UnityEngine;

public class OnClickInventory : MonoBehaviour, IOnClickInventoryItem
{
    [SerializeField] private ScriptableInventoryItem _scriptableInventoryItem;
    public ScriptableInventoryItem ScriptableInventoryItem
    {
        get => _scriptableInventoryItem;
        set => _scriptableInventoryItem = value;
    }
    
    public void OnClick()
    {
        GameObject.FindObjectOfType<Inventory>().RemoveInInventory(_scriptableInventoryItem);
        Destroy(gameObject);
    }
}
