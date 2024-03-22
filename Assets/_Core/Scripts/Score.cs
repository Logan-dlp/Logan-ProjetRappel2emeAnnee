using System;
using UnityEngine;

public class Score : MonoBehaviour, ISerializable<ScoreDTO>
{
    [SerializeField] private ScriptableInt _scoreScriptableInt;

    private void Awake()
    {
        _scoreScriptableInt?.SetNumber(0);
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
        _scoreScriptableInt.SetNumber(dataTransferObject.score);
    }
}
