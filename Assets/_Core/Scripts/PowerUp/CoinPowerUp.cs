using System;
using UnityEngine;

[RequireComponent(typeof(ScriptableIntController))]
public class CoinPowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;

    private ScriptableIntController _scriptableIntController;

    private void Awake()
    {
        _scriptableIntController = GetComponent<ScriptableIntController>();
    }

    public void ActivePowerUp(ScriptableItem scriptableItem)
    {
        if (scriptableItem == _scriptablePowerUpItem)
        {
            _scriptableIntController.Add(10);
        }
    }
}
