using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 

    [Header("Spawn Area")]
    public float minX = -10f;
    public float maxX = 10f;
    public float minZ = -10f;
    public float maxZ = 10f; //Defines where enemies can spawn in

    [Header("Spawn Timing")]
    public float spawnRate = 0.5f; //The rate enemies spawn in

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnRate);  //Calls SpawnEnemy and repeats every SpawnRates second
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 0f, Random.Range(minZ, maxZ)); //creates a random range using Min and Max to determine where the enemy will spawn
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity); //Spawns in the enemy at a random postion
    }
}
