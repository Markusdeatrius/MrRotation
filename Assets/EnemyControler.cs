
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private int _enemyCount = 5;
    [SerializeField]
    private Transform _spawnTopLeft, _spawnTopRight, _spawnBottomLeft, _spawnBottomRight;
    void Start()
    {
        for (int i = 0; i < _enemyCount; i++)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = SelectRandomPosition();
        GameObject enemyObject = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 SelectRandomPosition()
    {
        Transform selectedTranform = null;
        int randomValue = Random.Range(0, 4);
        SpawnPointType spawnType = (SpawnPointType)randomValue;
        switch (spawnType)
        {
            case SpawnPointType.TopLeft:
                {
                    selectedTranform = _spawnTopLeft;
                    break;
                }
            case SpawnPointType.TopRight:
                {
                    selectedTranform = _spawnTopRight;
                    break;
                }
            case SpawnPointType.BottomLeft:
                {
                    selectedTranform = _spawnBottomLeft;
                    break;
                }
            case SpawnPointType.BottomRight:
                {
                    selectedTranform = _spawnBottomRight;
                    break;
                }
            default:
                {
                    selectedTranform = _spawnTopLeft;
                    break;
                }

        }
        return selectedTranform.position + (Vector3)Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public enum SpawnPointType
    {
        TopLeft = 0,
        TopRight = 1,
        BottomLeft = 2,
        BottomRight = 3
    }
}
