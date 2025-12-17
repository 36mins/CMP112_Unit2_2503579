using System.Collections;
using UnityEngine;

public class DamageOverTimeTrigger : MonoBehaviour
{
    public int DOT = 2;
    public float Interval = 1f;

    Coroutine damageRoutine;

    private void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponentInParent<Health>();
        if (health != null)
        {
            damageRoutine = StartCoroutine(DamageLoop(health));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Health health = other.GetComponentInParent<Health>();
        if (health != null && damageRoutine != null)
        {
            StopCoroutine(damageRoutine);
            damageRoutine = null;
        }
    }

    IEnumerator DamageLoop(Health health)
    {
        while (true)
        {
            health.Damage(DOT);
            yield return new WaitForSeconds(Interval);
        }
    }
}
