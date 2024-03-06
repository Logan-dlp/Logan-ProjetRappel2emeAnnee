using System;
using UnityEngine;

public class Score : MonoBehaviour, ISerializable<ScoreDTO>
{
    [SerializeField] private ScriptableInt _scoreScriptableInt;

    private void Awake()
    {
        _scoreScriptableInt?.InvokeEvent(0);
    }

    public ScoreDTO Serialized()
    {
        return new ScoreDTO()
        {
            score = _scoreScriptableInt.Number,
        };
    }

    public void Deserialized(ScoreDTO dataTransferObject)
    {
        _scoreScriptableInt.InvokeEvent(dataTransferObject.score);
    }
}
