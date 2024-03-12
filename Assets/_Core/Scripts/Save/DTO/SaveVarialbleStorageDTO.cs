using System.Collections.Generic;

public class SaveVarialbleStorageDTO : DataTransferObject
{
    public Dictionary<string, float> saveFloats;
    public Dictionary<string, string> saveStrings;
    public Dictionary<string, bool> saveBools;
}
