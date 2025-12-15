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


        if (collision.gameObject.CompareTag("Log"))
        {
            PlayerHealth.Damage(25);
        }
    }
}

