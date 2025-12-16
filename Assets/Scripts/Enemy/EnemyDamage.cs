using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;                 //damage the player takes
    public float damageCooldown = 5f;       //time since last hit(so the player cant get hit back to back)

    float lastDamageTime;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) 
        {
            return;     //if they are not taged player do nothing
        }

        if (Time.time < lastDamageTime + damageCooldown) 
        {
            return;         //if hit and still has a cooldown does nothing
        }

        Health health = collision.gameObject.GetComponent<Health>(); //Finds the players health script

        if (health != null)
        {
            health.Damage(damage);  //calls damage from the health script and reduces the health by the damage amount
            lastDamageTime = Time.time; //Saves the Time for the damageCooldown
        }
    }
}
