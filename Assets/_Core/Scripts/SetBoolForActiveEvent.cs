using System;
using UnityEngine;
using UnityEngine.Events;

public class SetBoolForActiveEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _callbacksBool1;
    [SerializeField] private UnityEvent _callbacksBool2;
    [SerializeField] private UnityEvent _callbacksBool3;
    [SerializeField] private UnityEvent _callbacksBoolUnactive;
    
    private bool _eventAcitve1 = false;
    private bool _eventAcitve2 = false;
    private bool _eventAcitve3 = false;

    public void SetEventActive1()
    {
        _eventAcitve1 = !_eventAcitve1;
        if (_eventAcitve1)
        {
            _eventAcitve2 = false;
            _eventAcitve3 = false;
        }
        RefreshCallBacks();
    }
    
    public void SetEventActive2()
    {
        _eventAcitve2 = !_eventAcitve2;
        if (_eventAcitve2)
        {
            _eventAcitve1 = false;
            _eventAcitve3 = false;
        }
        RefreshCallBacks();
    }
    
    public void SetEventActive3()
    {
        _eventAcitve3 = !_eventAcitve3;
        if (_eventAcitve3)
        {
            _eventAcitve2 = false;
            _eventAcitve1 = false;
        }
        RefreshCallBacks();
    }

    private void RefreshCallBacks()
    {
        if (_eventAcitve1)
        {
            _callbacksBool1?.Invoke();
        }
        if (_eventAcitve2)
        {
            _callbacksBool2?.Invoke();
        }
        if (_eventAcitve3)
        {
            _callbacksBool3?.Invoke();
        }
        if (!_eventAcitve1 && !_eventAcitve2 && !_eventAcitve3)
        {
            _callbacksBoolUnactive?.Invoke();
        }
    }

    private void Start()
    {
        RefreshCallBacks();
    }
}
