using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string[] _loadSceneInAwake;

    private void Awake()
    {
        foreach (string scenesNames in _loadSceneInAwake)
        {
            SceneManager.LoadScene(scenesNames, LoadSceneMode.Additive);
        }
    }
}
