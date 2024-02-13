using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class AddScriptableInt : MonoBehaviour
{
    [SerializeField] private ScriptableInt scriptableInt;
    [SerializeField] private UnityEvent<int> _callbacksCoin;

    public void Add(int addCoin)
    {
        scriptableInt.Number += addCoin;
        _callbacksCoin?.Invoke(scriptableInt.Number);
    }

    public void Less(int lessCoin)
    {
        scriptableInt.Number -= lessCoin;
        _callbacksCoin.Invoke(scriptableInt.Number);
    }
}
