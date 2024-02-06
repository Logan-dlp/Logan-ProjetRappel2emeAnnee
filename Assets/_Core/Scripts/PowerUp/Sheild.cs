using UnityEngine;

public class Sheild : MonoBehaviour
{
    [SerializeField] private GameObject _sheild;
    
    private bool _isActive = false;

    public void ActiveSheild()
    {
        if (!_isActive)
        {
            Instantiate(_sheild, transform);
            _isActive = true;
        }
    }
}
