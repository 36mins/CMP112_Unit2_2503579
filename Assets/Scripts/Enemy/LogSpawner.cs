using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float heightAboveTrigger = 5f;
    public float fallForce = 15f;
    public float lifetime = 4f;

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            Vector3 spawnPosition = transform.position + Vector3.up * heightAboveTrigger;

            GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.down * fallForce, ForceMode.Acceleration);
            }

            Destroy(spawnedObject, lifetime);
            hasSpawned = true;
        }
    }
}
