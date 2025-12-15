using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    public float damageCooldown = 5f;

    float lastDamageTime;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) 
        {
            return;
        }

        if (Time.time < lastDamageTime + damageCooldown) 
        {
            return;
        }

        Health health = collision.gameObject.GetComponent<Health>();

        if (health != null)
        {
            health.Damage(damage);
            lastDamageTime = Time.time;
        }
    }
}
