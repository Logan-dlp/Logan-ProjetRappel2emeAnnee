using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScriptableIntValue : MonoBehaviour
{
    [SerializeField] private ScriptableInt _scriptableInt;
    [SerializeField] private TextMeshProUGUI _text;

    private void LateUpdate()
    {
        _text.text = _scriptableInt.Number.ToString();
    }
}
