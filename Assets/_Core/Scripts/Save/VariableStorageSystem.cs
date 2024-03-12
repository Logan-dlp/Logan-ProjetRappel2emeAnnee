using System.Collections.Generic;
using UnityEngine;

public class VariableStorageSystem : MonoBehaviour, ISerializable<SaveVarialbleStorageDTO>
{
    private Dictionary<string, float> _saveFloats = new();
    private Dictionary<string, string> _saveStrings = new();
    private Dictionary<string, bool> _saveBools = new();

    public void SetFloat(string name, float value)
    {
        if (_saveFloats.ContainsKey(name))
        {
            _saveFloats.Remove(name);
        }
        
        _saveFloats.Add(name, value);
    }

    public void SetString(string name, string value)
    {
        if (_saveStrings.ContainsKey(name))
        {
            _saveStrings.Remove(name);
        }
        
        _saveStrings.Add(name, value);
    }

    public void SetBool(string name, bool value)
    {
        if (_saveBools.ContainsKey(name))
        {
            _saveBools.Remove(name);
        }
        
        _saveBools.Add(name, value);
    }

    public float GetFloat(string name)
    {

        if (_saveFloats.ContainsKey(name))
        {
            return _saveFloats[name];
        }
        else
        {
            return 0;
        }
    }

    public string GetString(string name)
    {
        if (_saveStrings.ContainsKey(name))
        {
            return _saveStrings[name];
        }
        else
        {
            return null;
        }
    }

    public bool GetBool(string name)
    {
        if (_saveBools.ContainsKey(name))
        {
            return _saveBools[name];
        }
        else
        {
            return false;
        }
    }

    public SaveVarialbleStorageDTO Serialized()
    {
        return new()
        {
            saveFloats = _saveFloats,
            saveStrings = _saveStrings,
            saveBools = _saveBools,
        };
    }

    public void Deserialized(SaveVarialbleStorageDTO dataTransferObject)
    {
        _saveFloats = dataTransferObject.saveFloats;
        _saveStrings = dataTransferObject.saveStrings;
        _saveBools = dataTransferObject.saveBools;
    }
}
