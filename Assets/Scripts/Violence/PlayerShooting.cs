using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public float bulletSpeed = 0f;
    public Rigidbody bullet;
    public GameObject target;

    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.linearVelocity = transform.forward * bulletSpeed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "enemy")
        {

            Destroy(collision.gameObject);
        }


    }


}