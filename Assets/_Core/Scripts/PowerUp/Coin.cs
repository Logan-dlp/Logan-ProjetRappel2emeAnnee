using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coin;
    [SerializeField] private UnityEvent<int> _callbacksCoin;

    public void AddCoin(int addCoin)
    {
        _coin += addCoin;
        _callbacksCoin?.Invoke(_coin);
    }

    public void LessCoin(int lessCoin)
    {
        _coin -= lessCoin;
        _callbacksCoin.Invoke(_coin);
    }

    public int GetCoin()
    {
        return _coin;
    }
}
