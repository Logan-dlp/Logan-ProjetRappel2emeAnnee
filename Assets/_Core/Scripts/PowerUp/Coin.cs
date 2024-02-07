using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] private ScriptableCoin _scriptableCoin;
    [SerializeField] private UnityEvent<int> _callbacksCoin;

    public void AddCoin(int addCoin)
    {
        _scriptableCoin.Coin += addCoin;
        _callbacksCoin?.Invoke(_scriptableCoin.Coin);
    }

    public void LessCoin(int lessCoin)
    {
        _scriptableCoin.Coin -= lessCoin;
        _callbacksCoin.Invoke(_scriptableCoin.Coin);
    }
}
