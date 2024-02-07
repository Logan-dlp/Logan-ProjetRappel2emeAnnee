using System;
using UnityEngine;

[RequireComponent(
    typeof(Collider2D),
    typeof(Rigidbody2D))]
public class Item : MonoBehaviour
{
    public ScriptableItem _scriptableItem;
}
