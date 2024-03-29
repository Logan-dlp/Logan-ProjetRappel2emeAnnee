using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    private static SaveSystem _instance;

    public static SaveSystem Instance => _instance;

    private string _filePath;

    private void Awake()
    {
        _instance = this;
        _filePath = $"{Application.persistentDataPath}/shootem.json";
    }

    [ContextMenu("Save")]
    public void Save()
    {
        SaveData saveData = new()
        {
            inventoryDto = FindObjectOfType<Inventory>().Serialized(),
            scoreDto = FindObjectOfType<Score>().Serialized(),
            saveVarialbleStorageDto = FindObjectOfType<VariableStorageSystem>().Serialized(),
        };

        try
        {
            string json = JsonConvert.SerializeObject(saveData, Formatting.Indented);

            using FileStream stream = new(_filePath, FileMode.Create);
            using StreamWriter writer = new(stream);
            writer.Write(json);
        }
        catch (Exception ex)
        {
            Debug.LogError($"JSON serialization failed\n{ex}");
        }
    }

    [ContextMenu("Load")]
    public void Load()
    {
        try
        {
            using StreamReader reader = new(_filePath);
            string json = reader.ReadToEnd();

            SaveData saveData = JsonConvert.DeserializeObject<SaveData>(json);
            
            FindObjectOfType<Inventory>().Deserialized(saveData.inventoryDto);
            FindObjectOfType<Score>().Deserialized(saveData.scoreDto);
            FindObjectOfType<VariableStorageSystem>().Deserialized(saveData.saveVarialbleStorageDto);
        }
        catch (Exception ex)
        {
            Debug.LogError($"JSON deserialization failed\n{ex}");
        }
    }
}
