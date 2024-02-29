using UnityEngine;

public class SheildPowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;
    [SerializeField] private GameObject _sheild;
    
    private bool _isActive = false;

    public void UnactiveSheild()
    {
        _isActive = false;
    }
    
    public void ActiveSheild()
    {
        if (!_isActive)
        {
            Instantiate(_sheild, transform);
            _isActive = true;
        }
        else
        {
            _sheild.GetComponent<LifeController>().AddLife(100);
        }
    }

    public void ActivePowerUp(ScriptablePowerUpItem scriptablePowerUpItem)
    {
        if (scriptablePowerUpItem == _scriptablePowerUpItem)
        {
            ActiveSheild();
        }
    }
}
