using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float number;

    [ContextMenu("set")]
    public void Set()
    {
        VariableStorageSystem.instance.SetFloat("number", number);
    }

    [ContextMenu("get")]
    public void Get()
    {
        Debug.Log(VariableStorageSystem.instance.GetFloat("number"));
    }
}
