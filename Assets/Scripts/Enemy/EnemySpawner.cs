using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    [Header("Spawn Area")]
    public float minX = -10f;
    public float maxX = 10f;
    public float minZ = -10f;
    public float maxZ = 10f;

    [Header("Spawn Timing")]
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnRate);
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(minX, maxX),
            0f,
            Random.Range(minZ, maxZ)
        );

        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
