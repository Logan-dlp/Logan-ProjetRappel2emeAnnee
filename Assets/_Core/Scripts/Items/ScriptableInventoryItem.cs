using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new_" + nameof(ScriptableInventoryItem), menuName = "ScriptableObjects/Inventory Items")]
public class ScriptableInventoryItem : ScriptableItem
{
    [SerializeField] private GameObject _buttonObject;
    public GameObject ButtonObject => _buttonObject;
}
