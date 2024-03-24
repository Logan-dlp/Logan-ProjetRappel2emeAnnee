using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string[] _loadSceneInAwake;

    private void Awake()
    {
        foreach (string scenesName in _loadSceneInAwake)
        {
            SceneManager.LoadScene(scenesName, LoadSceneMode.Additive);
        }
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
