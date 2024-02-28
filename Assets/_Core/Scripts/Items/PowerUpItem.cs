using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(
    typeof(Collider2D),
    typeof(Rigidbody2D),
    typeof(SpriteRenderer))]
public class PowerUpItem : MonoBehaviour
{
    public ScriptablePowerUpItem ScriptablePowerUpItem
    {
        get => _scriptablePowerUpItem;
        set => _scriptablePowerUpItem = value;
    }
    
    [SerializeField] private ScriptablePowerUpItem _scriptablePowerUpItem;
}
