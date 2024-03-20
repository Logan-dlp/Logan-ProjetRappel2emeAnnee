using UnityEngine;
using UnityEngine.UI;

public class DisplayInt : MonoBehaviour
{
    [SerializeField] private Text _text;
    
    public void DisplayIntNumber(int number)
    {
        _text.text = number.ToString();
    }
}
