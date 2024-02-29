using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public ScriptableItem ScriptableItem
    {
        get => _scriptableItem;
        set => _scriptableItem = value;
    }

    public bool IsPowerUp => _isPowerUp;
    
    [SerializeField] protected ScriptableItem _scriptableItem;
    [SerializeField] protected bool _isPowerUp;
}
