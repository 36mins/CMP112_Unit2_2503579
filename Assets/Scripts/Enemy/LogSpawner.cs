using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject Log;
    public float Height = 5f;
    public float fallForce = 15f;
    public float Lifetime = 4f;

    private bool hasSpawned = false;    //Stops the same log being spawned in twice

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)      //Checsks if the Log has already been spawned and if its the player
        {
            Vector3 spawnPosition = transform.position + Vector3.up * Height;  //Where to spawn the Log above the trap

            GameObject spawnedObject = Instantiate(Log, spawnPosition, Quaternion.identity); //Spawns in the Log
            
            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>(); 
            if (rb != null)
            {
                rb.AddForce(Vector3.down * fallForce, ForceMode.Acceleration);  //Uses force to push the Log down
            }

            Destroy(spawnedObject, Lifetime);   //Deletes the Log after a certain amount of time
            hasSpawned = true; //Marks the Log as spawned
        }
    }
}
