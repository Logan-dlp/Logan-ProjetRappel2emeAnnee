using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private ScriptableInventory _scriptableInventory;
    [SerializeField] private float _spriteDistance;

    private RectTransform _rectTransform;
    private const float _tau = 2 * Mathf.PI;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void RefreshInventory()
    {
        
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < _scriptableInventory.InventoryList.Count; i++)
        {
            float angle = _tau / _scriptableInventory.InventoryList.Count;
            angle *= i + 1;
            
            float x = _spriteDistance * Mathf.Cos(angle) + _rectTransform.position.x; 
            float y = _spriteDistance * Mathf.Sin(angle)+ _rectTransform.position.y;
            
            GameObject newItem = new GameObject(); 
            newItem.transform.SetParent(transform); 
            RectTransform newItemRectTransform = newItem.AddComponent<RectTransform>(); 
            Image newItemImage = newItem.AddComponent<Image>(); 
            newItemImage.sprite = _scriptableInventory.InventoryList[i].Sprite; 
            newItemRectTransform.position = new Vector2(x, y);
        }
    }
}
