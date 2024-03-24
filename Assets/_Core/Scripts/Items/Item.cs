using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected ScriptableItem _scriptableItem;
    public ScriptableItem ScriptableItem => _scriptableItem;

    [SerializeField] protected bool _isPowerUp;
    public bool IsPowerUp => _isPowerUp;
}
