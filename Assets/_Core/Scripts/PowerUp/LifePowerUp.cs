using System;
using UnityEngine;

[RequireComponent(typeof(LifeController))]
public class LifePowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;

    private LifeController _lifeController;

    private void Awake()
    {
        _lifeController = GetComponent<LifeController>();
    }

    public void ActivePowerUp(ScriptablePowerUpItem scriptablePowerUpItem)
    {
        if (scriptablePowerUpItem == _scriptablePowerUpItem)
        {
            _lifeController.AddLife(10);
        }
    }
}
