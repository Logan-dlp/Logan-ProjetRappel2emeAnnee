using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class VariableStorageSystem
{
    private static VariableStorageSystem _instance;

    public static VariableStorageSystem Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new();
            }

            return _instance;
        }
    }
    
    private string _filePath = $"{Application.persistentDataPath}/VariableStorageSystem.json";

    private Dictionary<string, float> _saveFloats = new();
    private Dictionary<string, string> _saveStrings = new();
    private Dictionary<string, bool> _saveBools = new();

    public void SetFloat(string name, float value)
    {
        try
        {
            LoadVariableStorage();
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Create file system\n{ex}");
        }
        finally
        {
            bool haveKey= false;
            foreach (KeyValuePair<string,float> keyValuePair in _saveFloats)
            {
                if (keyValuePair.Key == name)
                {
                    haveKey = true;
                }
            }

            if (haveKey)
            {
                _saveFloats.Remove(name);
            }
            _saveFloats.Add(name, value);
            SaveVariableStorage();
        }
    }

    public void SetString(string name, string value)
    {
        try
        {
            LoadVariableStorage();
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Create file system\n{ex}");
        }
        finally
        {
            bool haveKey= false;
            foreach (KeyValuePair<string,string> keyValuePair in _saveStrings)
            {
                if (keyValuePair.Key == name)
                {
                    haveKey = true;
                }
            }

            if (haveKey)
            {
                _saveStrings.Remove(name);
            }
            _saveStrings.Add(name, value);
            SaveVariableStorage();
        }
    }

    public void SetBool(string name, bool value)
    {
        try
        {
            LoadVariableStorage();
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Create file system\n{ex}");
        }
        finally
        {
            bool haveKey= false;
            foreach (KeyValuePair<string,bool> keyValuePair in _saveBools)
            {
                if (keyValuePair.Key == name)
                {
                    haveKey = true;
                }
            }

            if (haveKey)
            {
                _saveBools.Remove(name);
            }
            _saveBools.Add(name, value);
            SaveVariableStorage();
        }
    }

    public float GetFloat(string name)
    {
        try
        {
            LoadVariableStorage();
            foreach (KeyValuePair<string,float> keyValuePair in _saveFloats)
            {
                if (keyValuePair.Key == name)
                {
                    return keyValuePair.Value;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"GetFloat failed\n{ex}");
        }

        return 0;
    }

    public string GetString(string name)
    {
        try
        {
            LoadVariableStorage();
            foreach (KeyValuePair<string,string> keyValuePair in _saveStrings)
            {
                if (keyValuePair.Key == name)
                {
                    return keyValuePair.Value;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"GetString failed\n{ex}");
        }

        return null;
    }

    public bool GetBool(string name)
    {
        try
        {
            LoadVariableStorage();
            foreach (KeyValuePair<string,bool> keyValuePair in _saveBools)
            {
                if (keyValuePair.Key == name)
                {
                    return keyValuePair.Value;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"GetString failed\n{ex}");
        }

        return false;
    }

    private void SaveVariableStorage()
    {
        SaveVarialbleStorage saveVarialbleStorage = new()
        {
            saveFloats = _saveFloats,
            saveStrings = _saveStrings,
            saveBools = _saveBools,
        };
        
        string json = JsonConvert.SerializeObject(saveVarialbleStorage, Formatting.Indented);

        using FileStream stream = new(_filePath, FileMode.Create);
        using StreamWriter writer = new(stream);
        writer.Write(json);
    }

    private void LoadVariableStorage()
    {
        using StreamReader reader = new(_filePath);
        string json = reader.ReadToEnd();

        SaveVarialbleStorage saveVarialbleStorage = JsonConvert.DeserializeObject<SaveVarialbleStorage>(json);

        _saveFloats = saveVarialbleStorage.saveFloats;
        _saveStrings = saveVarialbleStorage.saveStrings;
        _saveBools = saveVarialbleStorage.saveBools;
    }
}
