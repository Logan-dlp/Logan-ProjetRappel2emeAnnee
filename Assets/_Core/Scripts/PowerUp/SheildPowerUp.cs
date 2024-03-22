using UnityEngine;

public class SheildPowerUp : MonoBehaviour, IPowerUp
{
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;
    [SerializeField] private GameObject _sheild;

    private GameObject _sheildInstance;
    private bool _isActive = false;

    public void UnactiveSheild()
    {
        _isActive = false;
    }
    
    public void ActiveSheild()
    {
        if (!_isActive)
        {
            _sheildInstance = Instantiate(_sheild, transform);
            _isActive = true;
        }
        else
        {
            _sheildInstance.GetComponent<LifeController>().AddLife(100);
        }
    }

    public void ActivePowerUp(ScriptableItem scriptableItem)
    {
        if (scriptableItem == _scriptablePowerUpItem)
        {
            ActiveSheild();
        }
    }
}
