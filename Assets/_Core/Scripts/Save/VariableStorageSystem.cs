using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class VariableStorageSystem : MonoBehaviour
{
    public static VariableStorageSystem instance;

    private string _filePath;

    private Dictionary<string, float> _saveFloats = new();
    private Dictionary<string, string> _saveStrings = new();
    private Dictionary<string, bool> _saveBools = new();

    private void Awake()
    {
        instance = this;
        _filePath = $"{Application.persistentDataPath}/VariableStorageSystem.save";
    }

    public void SetFloat(string name, float value)
    {
        try
        {
            Load();
        }
        catch
        {
            
        }
        finally
        {
            foreach (KeyValuePair<string,float> keyValuePair in _saveFloats)
            {
                if (keyValuePair.Key == name)
                {
                    _saveFloats.Remove(keyValuePair.Key);
                }
            }
            _saveFloats.Add(name, value);
            Save();
        }
    }

    public void SetString(string name, string value)
    {
        try
        {
            Load();
        }
        finally
        {
            foreach (KeyValuePair<string,string> keyValuePair in _saveStrings)
            {
                if (keyValuePair.Key == name)
                {
                    _saveStrings.Remove(keyValuePair.Key);
                }
            }
            _saveStrings.Add(name, value);
            Save();
        }
    }

    public void SetBool(string name, bool value)
    {
        try
        {
            Load();
        }
        finally
        {
            foreach (KeyValuePair<string,bool> keyValuePair in _saveBools)
            {
                if (keyValuePair.Key == name)
                {
                    _saveBools.Remove(keyValuePair.Key);
                }
            }
            _saveBools.Add(name, value);
            Save();
        }
    }

    public float GetFloat(string name)
    {
        try
        {
            Load();
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
            Load();
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
            Load();
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

    private void Save()
    {
        SaveVarialbleStorage saveVarialbleStorage = new()
        {
            saveFloats = _saveFloats,
            saveStrings = _saveStrings,
            saveBools = _saveBools,
        };

        try
        {
            string json = JsonConvert.SerializeObject(saveVarialbleStorage, Formatting.Indented);

            using FileStream stream = new(_filePath, FileMode.Create);
            using StreamWriter writer = new(stream);
            writer.Write(json);
        }
        catch (Exception ex)
        {
            Debug.LogError($"JSON serialization failed\n{ex}");
        }
    }

    private void Load()
    {
        try
        {
            using StreamReader reader = new(_filePath);
            string json = reader.ReadToEnd();

            SaveVarialbleStorage saveVarialbleStorage = JsonConvert.DeserializeObject<SaveVarialbleStorage>(json);

            _saveFloats = saveVarialbleStorage.saveFloats;
            _saveStrings = saveVarialbleStorage.saveStrings;
            _saveBools = saveVarialbleStorage.saveBools;
        }
        catch (Exception ex)
        {
            Debug.LogError($"JSON deserialization failed\n{ex}");
        }
    }
}
