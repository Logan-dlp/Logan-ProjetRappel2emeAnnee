using System;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIntWidthInt : MonoBehaviour
{
    [SerializeField] private ScriptableInt _scriptableInt;
    [SerializeField] private Text _text;

    private void LateUpdate()
    {
        _text.text = _scriptableInt.Number.ToString();
    }
}
