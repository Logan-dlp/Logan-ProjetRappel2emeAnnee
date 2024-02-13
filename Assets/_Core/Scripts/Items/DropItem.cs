using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class DropItem : MonoBehaviour
{
    [SerializeField] private GameObject[] _itemArray;
    [SerializeField] private int _chanceNoHavingItems;
    
    public void DropItems()
    {
        int random = Random.Range(0, _itemArray.Length + _chanceNoHavingItems);
        if (random < _itemArray.Length)
        {
            Instantiate(_itemArray[random], transform.position, Quaternion.identity);
        }
    }
}
