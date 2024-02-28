using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnnemy : MonoBehaviour
{
    [SerializeField] private ScriptableInt _handles;
    [SerializeField] private float _timeWaitAfterHandles;
    [SerializeField] private GameObject[] _ennemyPrefabs;
    
    private int _ennemyNumber = 0;

    private void Start()
    {
        _handles.Number = 0;
        StartCoroutine(SpawnEnnemyCoroutine());
    }

    private void AddEnnemy()
    {
        int rand = Random.Range(0, _ennemyPrefabs.Length);
        Instantiate(_ennemyPrefabs[rand], transform.position, Quaternion.identity);
        _ennemyNumber++;
    }

    public void LessEnnemyNumber()
    {
        _ennemyNumber--;
        if (_ennemyNumber <= 0)
        {
            StartCoroutine(SpawnEnnemyCoroutine());
        }
    }

    IEnumerator SpawnEnnemyCoroutine()
    {
        yield return new WaitForSeconds(_timeWaitAfterHandles);
        _handles.Number++;
        if (_handles.Number * 2 < 6)
        {
            for (int i = 0; i < _handles.Number; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    AddEnnemy();
                }
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                AddEnnemy();
            }
        }
    }
}
