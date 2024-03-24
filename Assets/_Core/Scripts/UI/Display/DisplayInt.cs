using System;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInt : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void DisplayIntNumber(int number)
    {
        _text.text = number.ToString();
    }
}
