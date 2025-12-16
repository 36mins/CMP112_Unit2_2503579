using UnityEngine;

public class FallingLog : MonoBehaviour
{

    public Health PlayerHealth;

    void Start()
    {
        PlayerHealth = GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.Damage(40);  //if the player is hit they take damage 
        }
    }
}

